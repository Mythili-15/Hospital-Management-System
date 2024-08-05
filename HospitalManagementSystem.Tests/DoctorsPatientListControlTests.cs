using System;
using System.Data;
using System.Windows.Forms;
using HopitalManagementSystem;
using Moq;
using NUnit.Framework;

namespace HospitalManagementSystem.Tests
{
    [TestFixture]
    public class DoctorsPatientListControlTests
    {
        private Mock<IDatabaseOps> _mockDatabaseOps;
        private DoctorsPatientListControl _doctorsPatientListControl;

        [SetUp]
        public void Setup()
        {
            _mockDatabaseOps = new Mock<IDatabaseOps>();
            _doctorsPatientListControl = new DoctorsPatientListControl("1", _mockDatabaseOps.Object);
        }

        [TearDown]
        public void TearDown()
        {
            _doctorsPatientListControl?.Dispose();
        }

        [Test]
        public void display_CallsDatabaseOps_DoctorsPatient()
        {
            // Arrange
            var expectedData = new DataTable();
            _mockDatabaseOps.Setup(m => m.doctorsPatient(It.IsAny<string>())).Returns(expectedData);

            // Act
            _doctorsPatientListControl.display();

            // Assert
            _mockDatabaseOps.Verify(m => m.doctorsPatient("1"), Times.Once);
            Assert.That(_doctorsPatientListControl.dataGridViewINP.DataSource, Is.EqualTo(expectedData));

        }

        [Test]
        public void DoctorsPatientListControl_Load_CallsDisplay()
        {
            // Arrange
            var expectedData = new DataTable();
            _mockDatabaseOps.Setup(m => m.doctorsPatient(It.IsAny<string>())).Returns(expectedData);

            // Act
            _doctorsPatientListControl.DoctorsPatientListControl_Load(null, EventArgs.Empty);

            // Assert
            _mockDatabaseOps.Verify(m => m.doctorsPatient("1"), Times.Once);
            Assert.That(_doctorsPatientListControl.dataGridViewINP.DataSource,Is.EqualTo(expectedData));
        }

        [Test]
        public void dataGridViewINP_RowHeaderMouseClick_SetsTextBoxes()
        {
            // Arrange
            var dataTable = new DataTable();
            dataTable.Columns.Add("InpatientID");
            dataTable.Columns.Add("PatientName");
            dataTable.Rows.Add("123", "John Doe");
            _doctorsPatientListControl.dataGridViewINP.DataSource = dataTable;

            // Act
            var cellMouseEventArgs = new DataGridViewCellMouseEventArgs(0, 0, 0, 0, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
            _doctorsPatientListControl.dataGridViewINP_RowHeaderMouseClick(null, cellMouseEventArgs);

            // Assert
            // Assert
            Assert.That(_doctorsPatientListControl.textBoxInpatientID.Text, Is.EqualTo("123"));
            Assert.That(_doctorsPatientListControl.textBoxPatientName.Text, Is.EqualTo("John Doe"));
        }

        //[Test]
        //public void buttonPATDelete_Click_WithValidInpatientID_CallsDeleteAndDisplay()
        //{
        //    // Arrange
        //    _doctorsPatientListControl.textBoxInpatientID.Text = "123";
        //    var expectedData = new DataTable();
        //    _mockDatabaseOps.Setup(m => m.doctorsPatient(It.IsAny<string>())).Returns(expectedData);

        //    // Act
        //    _doctorsPatientListControl.buttonPATDelete_Click(null, EventArgs.Empty);

        //    // Assert
        //    _mockDatabaseOps.Verify(m => m.delete("PATIENTS", "123"), Times.Once);
        //    _mockDatabaseOps.Verify(m => m.doctorsPatient("1"), Times.Once); // Including the call in display method
        //}

        //[Test]
        //public void buttonPATDelete_Click_WithEmptyInpatientID_ShowsMessageBox()
        //{
        //    // Arrange
        //    _doctorsPatientListControl.textBoxInpatientID.Text = "";
        //    bool messageBoxShown = false;

        //    // Hook into MessageBox to check if the warning is shown
        //    _doctorsPatientListControl.MessageBoxOverride = (text, caption, buttons, icon) =>
        //    {
        //        messageBoxShown = true;
        //        return DialogResult.OK;
        //    };

        //    // Act
        //    _doctorsPatientListControl.buttonPATDelete_Click(null, EventArgs.Empty);

        //    // Assert
        //    Assert.IsTrue(messageBoxShown);
        //    _mockDatabaseOps.Verify(m => m.delete(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
        //}

        [Test]
        public void textBoxSearchValue_TextChanged_CallsSearchPat()
        {
            // Arrange
            _doctorsPatientListControl.textBoxSearchValue.Text = "John";
            _doctorsPatientListControl.comboBoxSearchBy.Text = "Name";
            var expectedData = new DataTable();
            _mockDatabaseOps.Setup(m => m.searchPat(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(expectedData);

            // Act
            _doctorsPatientListControl.textBoxSearchValue_TextChanged(null, EventArgs.Empty);

            // Assert
            _mockDatabaseOps.Verify(m => m.searchPat("John", "Name", "1"), Times.Once);
            Assert.That(_doctorsPatientListControl.dataGridViewINP.DataSource,Is.EqualTo(expectedData));
        }
    }

}
