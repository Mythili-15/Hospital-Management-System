using HopitalManagementSystem;
using Moq;
using NUnit.Framework;
using System;
using System.Data;
using System.Windows.Forms;

namespace HospitalManagementSystem.Tests
{
    [TestFixture]
    public class DocappointmentTests
    {
        private Mock<IDatabaseOps> _mockDatabaseOps;
        private Docappointment _docappointment;

        [SetUp]
        public void Setup()
        {
            _mockDatabaseOps = new Mock<IDatabaseOps>();
            _docappointment = new Docappointment(1, _mockDatabaseOps.Object);
        }

        [TearDown]
        public void TearDown()
        {
            _docappointment?.Dispose();
        }

        [Test]
        public void comboBoxSearchBy_SelectedIndexChanged_1_SetsDataSource_CurrentAppointments()
        {
            // Arrange
            var expectedData = new DataTable(); // Mocked data
            _mockDatabaseOps.Setup(m => m.GetAppointmentofDoctor(1, "Current Appointment")).Returns(expectedData);
            _docappointment.comboBoxSearchBy.SelectedIndex = 0; // "Current Appointments" is at index 0

            // Act
            _docappointment.comboBoxSearchBy_SelectedIndexChanged_1(null, EventArgs.Empty);

            // Assert
            Assert.That(_docappointment.dataGridViewINP.DataSource, Is.EqualTo(expectedData));
            _mockDatabaseOps.Verify(m => m.GetAppointmentofDoctor(1, "Current Appointment"), Times.Exactly(2));
        }

        [Test]
        public void comboBoxSearchBy_SelectedIndexChanged_1_SetsDataSource_AllAppointments()
        {
            // Arrange
            var expectedData = new DataTable(); // Mocked data
            _mockDatabaseOps.Setup(m => m.GetAppointmentofDoctor(1)).Returns(expectedData);
            _docappointment.comboBoxSearchBy.SelectedIndex = 1; // "All Appointments" is at index 1

            // Act
            _docappointment.comboBoxSearchBy_SelectedIndexChanged_1(null, EventArgs.Empty);

            // Assert
            Assert.That(_docappointment.dataGridViewINP.DataSource, Is.EqualTo(expectedData));
            _mockDatabaseOps.Verify(m => m.GetAppointmentofDoctor(1), Times.Exactly(3));

        }
    }
}
