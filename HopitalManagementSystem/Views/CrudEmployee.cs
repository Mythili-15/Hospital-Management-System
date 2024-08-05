using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.Models;

namespace HopitalManagementSystem
{
    public partial class CrudEmployee : Form, IDisposable
    {
        public Func<string, string, MessageBoxButtons, MessageBoxIcon, DialogResult> MessageBoxOverride;

        private readonly IDatabaseOps _databaseOps;
        public CrudEmployee(IDatabaseOps databaseOps)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            _databaseOps = databaseOps;
            display();
        }
        private void ShowMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            if (MessageBoxOverride != null)
                MessageBoxOverride(text, caption, buttons, icon);
            else
                MessageBox.Show(text, caption, buttons, icon);
        }

        public void buttonInsert_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                Employee employee = new Employee()
                {
                    Name = textBoxName.Text,
                    Gender = comboBoxGender.Text,
                    Designation = rolecbx.SelectedItem.ToString(),
                    Department = depcbx.SelectedItem.ToString(),
                    Pass = password.Text,
                    Email = textBoxEmail.Text,
                    Address = textBoxAddress.Text,
                    Tel = textBoxTel.Text
                };


                _databaseOps.insert(employee);
                display();
            }
            else
            {
                ShowMessageBox("Please fill in all fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void display()
        {
            dataGridView1.DataSource = _databaseOps.display("EMPLOYEE");
            _databaseOps.Showincbx(depcbx, "Department", "DepartmentName");
            _databaseOps.Showincbx(rolecbx, "EmployeeRoles", "RoleName");
        }

        public void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                Employee employee = new Employee()
                {
                    ID = textBoxid.Text,
                    Name = textBoxName.Text,
                    Gender = comboBoxGender.Text,
                    Designation = rolecbx.SelectedItem.ToString(),
                    Pass = password.Text,
                    Department = depcbx.SelectedItem.ToString(),
                    Email = textBoxEmail.Text,
                    Address = textBoxAddress.Text,
                    Tel = textBoxTel.Text
                };

                _databaseOps.update(employee);
                display();
            }
            else
            {
                ShowMessageBox("Please fill in all fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxid.Text.Length != 0)
            {
                _databaseOps.delete("EMPLOYEE", textBoxid.Text);
                display();
            }
            else
            {
                ShowMessageBox("Unable to delete Data, Select a row which you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            display();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = _databaseOps.search("EMPLOYEE", textBoxSearch.Text, comboBoxSearchBy.Text);

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "Male")
            {
                comboBoxGender.Text = "Male";
            }
            else
            {
                comboBoxGender.Text = "Female";
            }
            password.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            depcbx.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxTel.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBoxEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBoxAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            rolecbx.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

        }
        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(comboBoxGender.Text) ||
                rolecbx.SelectedItem == null ||
                depcbx.SelectedItem == null ||
                string.IsNullOrWhiteSpace(password.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxAddress.Text) ||
                string.IsNullOrWhiteSpace(textBoxTel.Text))
            {
                return false; 
            }

            return true; 
        }

        
    }
}
