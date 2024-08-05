using HopitalManagementSystem;
using HospitalManagementSystem.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Threading;
using System.Windows.Forms;

namespace HospitalManagementSystem.Tests
{
    [TestFixture]
    public class PatientCRUDTests
    {
        private Mock<IDatabaseOps> _mockDatabaseOps;
        private PatientCRUD _patientCRUDForm;

        [SetUp]
        public void Setup()
        {
            _mockDatabaseOps = new Mock<IDatabaseOps>();
            _patientCRUDForm = new PatientCRUD("1", _mockDatabaseOps.Object);
        }

        [TearDown]
        public void TearDown()
        {
            _patientCRUDForm?.Dispose();
        }

        [Test]
        public void buttonPATInsert_Click_ValidData_CallsInsertAndDisplays()
        {
            // Arrange
            _patientCRUDForm.textBoxPATName.Text = "John Doe";
            _patientCRUDForm.comboBoxPATGender.Text = "Male";
            _patientCRUDForm.textBoxPATTel.Text = "1234567890";
            _patientCRUDForm.employeeid.Text = "1";
            _patientCRUDForm.emailt.Text = "john.doe@example.com";
            _patientCRUDForm.textBoxPATAddress.Text = "123 Main St, City";

            // Act
            _patientCRUDForm.buttonPATInsert_Click(null, EventArgs.Empty);

            // Assert
            _mockDatabaseOps.Verify(m => m.insert(It.IsAny<Patient>()), Times.Once);
            _mockDatabaseOps.Verify(m => m.display("PATIENTS"), Times.Exactly(2)); // Including the call in the constructor
        }

        [Test]
        public void buttonPATInsert_Click_IncompleteData_ShowsMessageBox()
        {
            // Arrange
            _patientCRUDForm.textBoxPATName.Text = "John Doe";

            bool messageBoxShown = false;

            _patientCRUDForm.MessageBoxOverride = (text, caption, buttons, icon) =>
            {
                messageBoxShown = true;
                return DialogResult.OK;
            };

            // Act
            _patientCRUDForm.buttonPATInsert_Click(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(messageBoxShown);
            _mockDatabaseOps.Verify(m => m.insert(It.IsAny<Patient>()), Times.Never);
            _mockDatabaseOps.Verify(m => m.display("PATIENTS"), Times.Once);
        }

        [Test]
        public void buttonPATUpdate_Click_ValidData_CallsUpdateAndDisplays()
        {
            // Arrange
            _patientCRUDForm.textBoxPATID.Text = "1";
            _patientCRUDForm.textBoxPATName.Text = "John Doe";
            _patientCRUDForm.comboBoxPATGender.Text = "Male";
            _patientCRUDForm.textBoxPATTel.Text = "1234567890";
            _patientCRUDForm.employeeid.Text = "1";
            _patientCRUDForm.emailt.Text = "john.doe@example.com";
            _patientCRUDForm.textBoxPATAddress.Text = "123 Main St, City";

            var expectedPatient = new Patient
            {
                ID = "1",
                Name = "John Doe",
                Gender = "Male",
                Tel = "1234567890",
                CreatedBy = 1,
                Email = "john.doe@example.com",
                Address = "123 Main St, City",
                
            };

            // Act
            _patientCRUDForm.buttonPATUpdate_Click(null, EventArgs.Empty);

            // Assert
            _mockDatabaseOps.Verify(m => m.update(It.Is<Patient>(p =>
                p.ID == expectedPatient.ID &&
                p.Name == expectedPatient.Name &&
                p.Gender == expectedPatient.Gender &&
                p.Tel == expectedPatient.Tel &&
                p.CreatedBy == expectedPatient.CreatedBy &&
                p.Email == expectedPatient.Email &&
                p.Address == expectedPatient.Address
            )), Times.Once);
            _mockDatabaseOps.Verify(m => m.display("PATIENTS"), Times.Exactly(2)); // Including the call in the constructor
        }

        [Test]
        public void buttonPATUpdate_Click_IncompleteData_ShowsMessageBox()
        {
            // Arrange
            _patientCRUDForm.textBoxPATID.Text = "1";
            _patientCRUDForm.textBoxPATName.Text = "John Doe";
            

            bool messageBoxShown = false;

            _patientCRUDForm.MessageBoxOverride = (text, caption, buttons, icon) =>
            {
                messageBoxShown = true;
                return DialogResult.OK;
            };

            // Act
            _patientCRUDForm.buttonPATUpdate_Click(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(messageBoxShown);
            _mockDatabaseOps.Verify(m => m.update(It.IsAny<Patient>()), Times.Never);
            _mockDatabaseOps.Verify(m => m.display("PATIENTS"), Times.Once); // Only the initial call in the constructor
        }

        [Test]
        public void buttonPATDelete_Click_ValidData_CallsDeleteAndDisplays()
        {
            // Arrange
            _patientCRUDForm.textBoxPATID.Text = "1";

            // Act
            _patientCRUDForm.buttonPATDelete_Click(null, EventArgs.Empty);

            // Assert
            _mockDatabaseOps.Verify(m => m.delete("PATIENTS", "1"), Times.Once);
            _mockDatabaseOps.Verify(m => m.display("PATIENTS"), Times.Exactly(3)); // Including the call in the constructor
        }

        [Test]
        public void buttonPATDelete_Click_NoID_InvokesMessageBox()
        {
            // Arrange
            _patientCRUDForm.textBoxPATID.Text = "";

            bool messageBoxInvoked = false;

            _patientCRUDForm.MessageBoxOverride = (text, caption, buttons, icon) =>
            {
                messageBoxInvoked = true;
                return DialogResult.OK;
            };

            // Act
            _patientCRUDForm.buttonPATDelete_Click(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(messageBoxInvoked);
            _mockDatabaseOps.Verify(m => m.delete("PATIENTS", It.IsAny<string>()), Times.Never);
            _mockDatabaseOps.Verify(m => m.display("PATIENTS"), Times.Exactly(2)); // Only the initial call in the constructor
        }

        [Test]
        public void textBoxSearchVal_TextChanged_CallsSearch()
        {
            // Arrange
            _patientCRUDForm.textBoxSearchVal.Text = "SearchValue";
            _patientCRUDForm.comboBoxSearchBy.Text = "ColumnName";

            // Act
            _patientCRUDForm.textBoxSearchVal_TextChanged(null, EventArgs.Empty);

            // Assert
            _mockDatabaseOps.Verify(m => m.search("PATIENTS", "SearchValue", "ColumnName"), Times.Once);
        }
    }
}
