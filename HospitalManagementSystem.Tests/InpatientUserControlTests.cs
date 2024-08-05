using HopitalManagementSystem;
using Moq;
using NUnit.Framework;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace HospitalManagementSystem.Tests
{
    [TestFixture]
    public class InpatientUserControlTests
    {
        private Mock<IDatabaseOps> _mockDatabaseOps;
        private InpatientUserControl _inpatientUserControl;

        [SetUp]
        public void Setup()
        {
            _mockDatabaseOps = new Mock<IDatabaseOps>();
            _inpatientUserControl = new InpatientUserControl(_mockDatabaseOps.Object);
        }

        [TearDown]
        public void TearDown()
        {
            _inpatientUserControl?.Dispose();
        }

        [Test]
        public void roomList_ShouldCallRoomListWithCorrectRoomType()
        {
            // Arrange
            _inpatientUserControl.comboBoxRType.Text = "Single";

            // Act
            _inpatientUserControl.roomList();

            // Assert
            _mockDatabaseOps.Verify(m => m.roomList("Single"), Times.Once);
        }

        [Test]
        public void patientList_ShouldPopulateComboBoxWithPatients()
        {
            // Arrange
            DataTable patientsTable = new DataTable();
            patientsTable.Columns.Add("ID");
            patientsTable.Columns.Add("PAT_NAME");
            patientsTable.Rows.Add(1, "John Doe");
            patientsTable.Rows.Add(2, "Jane Smith");

            _mockDatabaseOps.Setup(m => m.patientList()).Returns(patientsTable);

            // Act
            _inpatientUserControl.patientList();

            // Assert
            Assert.That(_inpatientUserControl.comboBoxPatient.DataSource,Is.EqualTo(patientsTable));
            Assert.That(_inpatientUserControl.comboBoxPatient.DisplayMember,Is.EqualTo("PAT_NAME"));
            Assert.That(_inpatientUserControl.comboBoxPatient.ValueMember,Is.EqualTo("ID"));
        }

        [Test]
        public void buttonRoomInsert_Click_ShouldInsertInpatientAndDisplayData()
        {
            // Arrange
            // Initialize ComboBoxPatient and set up necessary values
            var patientID = 1;
            var roomno = "101";
            var doa = DateTime.Today;
            var dod = DateTime.Today.AddDays(1);
            var total= 1000;

            // Set up data source for comboBoxPatient
            var patientTable = new DataTable();
            patientTable.Columns.Add("ID", typeof(int));
            patientTable.Columns.Add("PAT_NAME", typeof(string));
            patientTable.Rows.Add(1, "John Doe");

            _inpatientUserControl.comboBoxPatient.DisplayMember = "PAT_NAME";
            _inpatientUserControl.comboBoxPatient.ValueMember = "ID";
            _inpatientUserControl.comboBoxPatient.DataSource = patientTable;
           
            // Set up data source for comboBoxRNo
            var roomTable = new DataTable();
            roomTable.Columns.Add("RoomID", typeof(string));  // Assuming RoomID is string type
            roomTable.Columns.Add("RoomName", typeof(string));  // Assuming RoomName is string type
            roomTable.Rows.Add("101", "101");

            _inpatientUserControl.comboBoxRNo.DisplayMember = "RoomName";
            _inpatientUserControl.comboBoxRNo.ValueMember = "RoomID";
            _inpatientUserControl.comboBoxRNo.DataSource = roomTable;


            _inpatientUserControl.comboBoxPatient.SelectedValue = 1;
            _inpatientUserControl.comboBoxRNo.SelectedValue = "101";

            // Set other necessary values
            _inpatientUserControl.dateTimePickerDOA.Value = DateTime.Today;
            _inpatientUserControl.dateTimePickerDOD.Value = DateTime.Today.AddDays(1);
            _inpatientUserControl.textBox1.Text = "1000";

            _mockDatabaseOps.Setup(m => m.insert(It.IsAny<Inpatient>()));
            _mockDatabaseOps.Setup(m => m.displayInPat()).Returns(new DataTable());

            // Act
            _inpatientUserControl.buttonRoomInsert_Click(null, EventArgs.Empty);

            // Assert
            _mockDatabaseOps.Verify(m => m.insert(It.Is<Inpatient>(i =>
                i.PatID == patientID &&
                i.RoomNo == roomno &&
                i.Admission == doa &&
                i.Discharge == dod &&
                i.TotalAmount == total
            )), Times.Once);
            _mockDatabaseOps.Verify(m => m.displayInPat(), Times.AtLeastOnce);
        }


        [Test]
        public void buttonRoomUpdate_Click_ShouldUpdateInpatientAndDisplayData()
        {
            // Arrange
            // Initialize ComboBoxPatient and set up necessary values
            var patientID = 1;
            var roomno = "101";
            var doa = DateTime.Today;
            var dod = DateTime.Today.AddDays(1);
            var total = 1000;

            // Set up data source for comboBoxPatient
            var patientTable = new DataTable();
            patientTable.Columns.Add("ID", typeof(int));
            patientTable.Columns.Add("PAT_NAME", typeof(string));
            patientTable.Rows.Add(1, "John Doe");

            _inpatientUserControl.comboBoxPatient.DisplayMember = "PAT_NAME";
            _inpatientUserControl.comboBoxPatient.ValueMember = "ID";
            _inpatientUserControl.comboBoxPatient.DataSource = patientTable;

            // Set up data source for comboBoxRNo
            var roomTable = new DataTable();
            roomTable.Columns.Add("RoomID", typeof(string));  // Assuming RoomID is string type
            roomTable.Columns.Add("RoomName", typeof(string));  // Assuming RoomName is string type
            roomTable.Rows.Add("101", "101");

            _inpatientUserControl.comboBoxRNo.DisplayMember = "RoomName";
            _inpatientUserControl.comboBoxRNo.ValueMember = "RoomID";
            _inpatientUserControl.comboBoxRNo.DataSource = roomTable;

            _inpatientUserControl.textBoxInpatientID.Text = "1";
            _inpatientUserControl.comboBoxPatient.SelectedValue = patientID;
            _inpatientUserControl.comboBoxRNo.SelectedValue = roomno;
            _inpatientUserControl.dateTimePickerDOA.Value = doa;
            _inpatientUserControl.dateTimePickerDOD.Value = dod;
            _inpatientUserControl.textBox1.Text = total.ToString();

            var inpatient = new Inpatient
            {
                InPatID = 1,
                PatID = patientID,
                RoomNo = roomno,
                Admission = doa,
                Discharge = dod,
                TotalAmount = total
            };

            _mockDatabaseOps.Setup(m => m.update(It.IsAny<Inpatient>()));
            _mockDatabaseOps.Setup(m => m.displayInPat()).Returns(new DataTable());

            // Act
            _inpatientUserControl.buttonRoomUpdate_Click(null, EventArgs.Empty);

            // Assert
            _mockDatabaseOps.Verify(m => m.update(It.Is<Inpatient>(i =>
                i.InPatID == inpatient.InPatID &&
                i.PatID == inpatient.PatID &&
                i.RoomNo == inpatient.RoomNo &&
                i.Admission == inpatient.Admission &&
                i.Discharge == inpatient.Discharge &&
                i.TotalAmount == inpatient.TotalAmount
            )), Times.Once);
            _mockDatabaseOps.Verify(m => m.displayInPat(), Times.AtLeastOnce);
        }

        [Test]
        public void buttonRoomDelete_Click_ShouldDeleteInpatientAndDisplayData()
        {
            // Arrange
            _inpatientUserControl.textBoxInpatientID.Text = "1";

            _mockDatabaseOps.Setup(m => m.delete("INPATIENT", "1"));
            _mockDatabaseOps.Setup(m => m.displayInPat()).Returns(new DataTable());

            // Act
            _inpatientUserControl.buttonRoomDelete_Click(null, EventArgs.Empty);

            // Assert
            _mockDatabaseOps.Verify(m => m.delete("INPATIENT", "1"), Times.Once);
            _mockDatabaseOps.Verify(m => m.displayInPat(), Times.AtLeastOnce);
        }

        

        [Test]
        public void textBoxSearchVal_TextChanged_ShouldSearchAndDisplayData()
        {
            // Arrange
            _inpatientUserControl.textBoxSearchVal.Text = "search";
            _inpatientUserControl.comboBoxSearchBy.Text = "PAT_NAME";

            _mockDatabaseOps.Setup(m => m.search("INPATIENTS", "search", "PAT_NAME")).Returns(new DataTable());

            // Act
            _inpatientUserControl.textBoxSearchVal_TextChanged(null, EventArgs.Empty);

            // Assert
            _mockDatabaseOps.Verify(m => m.search("INPATIENTS", "search", "PAT_NAME"), Times.Once);
        }
    }
}
