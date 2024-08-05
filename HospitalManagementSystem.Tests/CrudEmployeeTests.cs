using HopitalManagementSystem;
using HospitalManagementSystem.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Threading;
using System.Windows.Forms;

[assembly: Apartment(ApartmentState.STA)]
namespace HospitalManagementSystem.Tests
{
    [TestFixture]
    public class CrudEmployeeTests
    {
        private Mock<IDatabaseOps> _mockDatabaseOps;
        private CrudEmployee _crudEmployeeForm;

        [SetUp]
        public void Setup()
        {
            _mockDatabaseOps = new Mock<IDatabaseOps>();
            _crudEmployeeForm = new CrudEmployee(_mockDatabaseOps.Object);
        }

        [TearDown]
        public void TearDown()
        {
            _crudEmployeeForm?.Dispose();  
        }

        [Test]
        public void buttonInsert_Click_ValidData_CallsInsertAndDisplays()
        {
            // Arrange
            _crudEmployeeForm.textBoxName.Text = "John Doe";
            _crudEmployeeForm.comboBoxGender.Text = "Male";

            // Add items to rolecbx and depcbx
            _crudEmployeeForm.rolecbx.Items.Add("Admin");
            _crudEmployeeForm.rolecbx.SelectedItem = "Admin";

            _crudEmployeeForm.depcbx.Items.Add("Oncology");
            _crudEmployeeForm.depcbx.SelectedItem = "Oncology";

            _crudEmployeeForm.password.Text = "securepassword";
            _crudEmployeeForm.textBoxEmail.Text = "john.doe@example.com";
            _crudEmployeeForm.textBoxAddress.Text = "123 Main St, City";
            _crudEmployeeForm.textBoxTel.Text = "1234567890";

            // Act
            _crudEmployeeForm.buttonInsert_Click(null, EventArgs.Empty);

            // Assert
            _mockDatabaseOps.Verify(m => m.insert(It.IsAny<Employee>()), Times.Once);
            _mockDatabaseOps.Verify(m => m.display("EMPLOYEE"), Times.Exactly(2)); // Including the call in the constructor
        }

        [Test]
        public void buttonInsert_Click_IncompleteData_ShowsMessageBox()
        {
            // Arrange
            _crudEmployeeForm.textBoxName.Text = "John Doe";

            bool messageBoxShown = false;

            // Hook into MessageBox to check if the warning is shown
            _crudEmployeeForm.MessageBoxOverride = (text, caption, buttons, icon) =>
            {
                messageBoxShown = true;
                return DialogResult.OK;
            };

            // Act
            _crudEmployeeForm.buttonInsert_Click(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(messageBoxShown);
            _mockDatabaseOps.Verify(m => m.insert(It.IsAny<Employee>()), Times.Never);
            
            _mockDatabaseOps.Verify(m => m.display("EMPLOYEE"), Times.Once);
        }

        [Test]
        public void buttonUpdate_Click_ValidData_CallsUpdateAndDisplays()
        {
            // Arrange
            _crudEmployeeForm.textBoxid.Text = "1";
            _crudEmployeeForm.textBoxName.Text = "John Doe";
            _crudEmployeeForm.comboBoxGender.Text = "Male";

            _crudEmployeeForm.rolecbx.Items.Add("Admin");
            _crudEmployeeForm.rolecbx.SelectedItem = "Admin";

            _crudEmployeeForm.depcbx.Items.Add("Oncology");
            _crudEmployeeForm.depcbx.SelectedItem = "Oncology";

            _crudEmployeeForm.password.Text = "securepassword";
            _crudEmployeeForm.textBoxEmail.Text = "john.doe@example.com";
            _crudEmployeeForm.textBoxAddress.Text = "123 Main St, City";
            _crudEmployeeForm.textBoxTel.Text = "1234567890";

            var expectedEmployee = new Employee
            {
                ID = "1",
                Name = "John Doe",
                Gender = "Male",
                Designation = "Admin",
                Pass = "securepassword",
                Department = "Oncology",
                Email = "john.doe@example.com",
                Address = "123 Main St, City",
                Tel = "1234567890"
            };

            // Act
            _crudEmployeeForm.buttonUpdate_Click(null, EventArgs.Empty);

            // Assert
            _mockDatabaseOps.Verify(m => m.update(It.Is<Employee>(e =>
                e.ID == expectedEmployee.ID &&
                e.Name == expectedEmployee.Name &&
                e.Gender == expectedEmployee.Gender &&
                e.Designation == expectedEmployee.Designation &&
                e.Pass == expectedEmployee.Pass &&
                e.Department == expectedEmployee.Department &&
                e.Email == expectedEmployee.Email &&
                e.Address == expectedEmployee.Address &&
                e.Tel == expectedEmployee.Tel
            )), Times.Once);
            _mockDatabaseOps.Verify(m => m.display("EMPLOYEE"), Times.Exactly(2)); // Including the call in the constructor
        }

        [Test]
        public void buttonUpdate_Click_IncompleteData_ShowsMessageBox()
        {
            // Arrange
            _crudEmployeeForm.textBoxid.Text = "1";
            _crudEmployeeForm.textBoxName.Text = "John Doe";
           

            bool messageBoxShown = false;

           
            _crudEmployeeForm.MessageBoxOverride = (text, caption, buttons, icon) =>
            {
                messageBoxShown = true;
                return DialogResult.OK;
            };

            // Act
            _crudEmployeeForm.buttonUpdate_Click(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(messageBoxShown);
            _mockDatabaseOps.Verify(m => m.update(It.IsAny<Employee>()), Times.Never);
            _mockDatabaseOps.Verify(m => m.display("EMPLOYEE"), Times.Once); // Only the initial call in the constructor
        }
        [Test]
        public void buttonDelete_Click_ValidData_CallsDeleteAndDisplays()
        {
            // Arrange
            _crudEmployeeForm.textBoxid.Text = "1";

            // Act
            _crudEmployeeForm.buttonDelete_Click(null, EventArgs.Empty);

            // Assert
            _mockDatabaseOps.Verify(m => m.delete("EMPLOYEE", "1"), Times.Once);
            _mockDatabaseOps.Verify(m => m.display("EMPLOYEE"), Times.Exactly(2)); // Including the call in the constructor
        }

        [Test]
        public void buttonDelete_Click_NoID_InvokesMessageBox()
        {
            // Arrange
            _crudEmployeeForm.textBoxid.Text = "";

            bool messageBoxInvoked = false;

            
            _crudEmployeeForm.MessageBoxOverride = (text, caption, buttons, icon) =>
            {
                messageBoxInvoked = true;
                return DialogResult.OK;
            };

            // Act
            _crudEmployeeForm.buttonDelete_Click(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(messageBoxInvoked);
            _mockDatabaseOps.Verify(m => m.delete("EMPLOYEE", It.IsAny<string>()), Times.Never);
            _mockDatabaseOps.Verify(m => m.display("EMPLOYEE"), Times.Once); // Only the initial call in the constructor
        }


    }
}
