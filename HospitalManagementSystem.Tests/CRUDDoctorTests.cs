using HopitalManagementSystem;
using Moq;
using NUnit.Framework;
using System;
using System.Threading;
using System.Windows.Forms;

namespace HospitalManagementSystem.Tests
{
    [TestFixture]
    public class CRUDDoctorTests
    {
        private Mock<IDatabaseOps> _mockDatabaseOps;
        private CRUDDoctor _crudDoctorForm;

        [SetUp]
        public void Setup()
        {
            _mockDatabaseOps = new Mock<IDatabaseOps>();
            _crudDoctorForm = new CRUDDoctor(_mockDatabaseOps.Object);
        }

        [TearDown]
        public void TearDown()
        {
            _crudDoctorForm?.Dispose();
        }

        [Test]
        public void buttonInsert_Click_ValidData_CallsInsertAndDisplays()
        {
            // Arrange
            _crudDoctorForm.textBoxName.Text = "Dr. John Doe";
            _crudDoctorForm.comboBoxGender.Text = "Male";
            _crudDoctorForm.rolecbx.Items.Add("Surgeon");
            _crudDoctorForm.rolecbx.SelectedItem = "Surgeon";
            _crudDoctorForm.depcbx.Items.Add("Surgery");
            _crudDoctorForm.depcbx.SelectedItem = "Surgery";
            _crudDoctorForm.textBoxEmail.Text = "john.doe@example.com";
            _crudDoctorForm.textBoxAddress.Text = "456 Hospital Ave, City";
            _crudDoctorForm.textBoxTel.Text = "9876543210";
            _crudDoctorForm.priceperappointment.Text = "100";

            // Act
            _crudDoctorForm.buttonInsert_Click(null, EventArgs.Empty);

            // Assert
            _mockDatabaseOps.Verify(m => m.insert(It.IsAny<Doctor>()), Times.Once);
            _mockDatabaseOps.Verify(m => m.display("DOCTORS"), Times.Exactly(2)); // Including the call in the constructor
        }

        [Test]
        public void buttonInsert_Click_IncompleteData_ShowsMessageBox()
        {
            // Arrange
            _crudDoctorForm.textBoxName.Text = "Dr. John Doe";

            bool messageBoxShown = false;

            // Hook into MessageBox to check if the warning is shown
            _crudDoctorForm.MessageBoxOverride = (text, caption, buttons, icon) =>
            {
                messageBoxShown = true;
                return DialogResult.OK;
            };

            // Act
            _crudDoctorForm.buttonInsert_Click(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(messageBoxShown);
            _mockDatabaseOps.Verify(m => m.insert(It.IsAny<Doctor>()), Times.Never);
            // Verify that display was called only once (the initial call in the constructor)
            _mockDatabaseOps.Verify(m => m.display("DOCTORS"), Times.Once);
        }

        [Test]
        public void buttonUpdate_Click_ValidData_CallsUpdateAndDisplays()
        {
            // Arrange
            _crudDoctorForm.textBoxid.Text = "1";
            _crudDoctorForm.textBoxName.Text = "Dr. John Doe";
            _crudDoctorForm.comboBoxGender.Text = "Male";
            _crudDoctorForm.rolecbx.Items.Add("Surgeon");
            _crudDoctorForm.rolecbx.SelectedItem = "Surgeon";
            _crudDoctorForm.depcbx.Items.Add("Surgery");
            _crudDoctorForm.depcbx.SelectedItem = "Surgery";
            _crudDoctorForm.textBoxEmail.Text = "john.doe@example.com";
            _crudDoctorForm.textBoxAddress.Text = "456 Hospital Ave, City";
            _crudDoctorForm.textBoxTel.Text = "9876543210";
            _crudDoctorForm.priceperappointment.Text = "100";

            var expectedDoctor = new Doctor
            {
                ID = "1",
                Name = "Dr. John Doe",
                Gender = "Male",
                Designation = "Surgeon",
                Department = "Surgery",
                Email = "john.doe@example.com",
                Address = "456 Hospital Ave, City",
                Tel = "9876543210",
                PricePerAppointment = 100
            };

            // Act
            _crudDoctorForm.buttonUpdate_Click(null, EventArgs.Empty);

            // Assert
            _mockDatabaseOps.Verify(m => m.update(It.Is<Doctor>(d =>
                d.ID == expectedDoctor.ID &&
                d.Name == expectedDoctor.Name &&
                d.Gender == expectedDoctor.Gender &&
                d.Designation == expectedDoctor.Designation &&
                d.Department == expectedDoctor.Department &&
                d.Email == expectedDoctor.Email &&
                d.Address == expectedDoctor.Address &&
                d.Tel == expectedDoctor.Tel &&
                d.PricePerAppointment == expectedDoctor.PricePerAppointment
            )), Times.Once);
            _mockDatabaseOps.Verify(m => m.display("DOCTORS"), Times.Exactly(2)); // Including the call in the constructor
        }

        [Test]
        public void buttonUpdate_Click_IncompleteData_ShowsMessageBox()
        {
            // Arrange
            _crudDoctorForm.textBoxid.Text = "1";
            _crudDoctorForm.textBoxName.Text = "Dr. John Doe";
            // Not setting other fields to simulate missing data

            bool messageBoxShown = false;

            // Hook into MessageBox to check if the warning is shown
            _crudDoctorForm.MessageBoxOverride = (text, caption, buttons, icon) =>
            {
                messageBoxShown = true;
                return DialogResult.OK;
            };

            // Act
            _crudDoctorForm.buttonUpdate_Click(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(messageBoxShown);
            _mockDatabaseOps.Verify(m => m.update(It.IsAny<Doctor>()), Times.Never);
            _mockDatabaseOps.Verify(m => m.display("DOCTORS"), Times.Once); // Only the initial call in the constructor
        }

        [Test]
        public void buttonDelete_Click_ValidData_CallsDeleteAndDisplays()
        {
            // Arrange
            _crudDoctorForm.textBoxid.Text = "1";

            // Act
            _crudDoctorForm.buttonDelete_Click(null, EventArgs.Empty);

            // Assert
            _mockDatabaseOps.Verify(m => m.DeleteTimeSlots(It.IsAny<int>()), Times.Once);
            _mockDatabaseOps.Verify(m => m.delete("DOCTORS", "1"), Times.Once);
            _mockDatabaseOps.Verify(m => m.display("DOCTORS"), Times.Exactly(2)); // Including the call in the constructor
        }

        [Test]
        public void buttonDelete_Click_NoID_InvokesMessageBox()
        {
            // Arrange
            _crudDoctorForm.textBoxid.Text = "";

            bool messageBoxInvoked = false;

            // Hook into MessageBox to check if the error message is invoked
            _crudDoctorForm.MessageBoxOverride = (text, caption, buttons, icon) =>
            {
                messageBoxInvoked = true;
                return DialogResult.OK;
            };

            // Act
            _crudDoctorForm.buttonDelete_Click(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(messageBoxInvoked);
            _mockDatabaseOps.Verify(m => m.DeleteTimeSlots(It.IsAny<int>()), Times.Never);
            _mockDatabaseOps.Verify(m => m.delete("DOCTORS", It.IsAny<string>()), Times.Never);
            _mockDatabaseOps.Verify(m => m.display("DOCTORS"), Times.Once); // Only the initial call in the constructor
        }

       
    }
}
