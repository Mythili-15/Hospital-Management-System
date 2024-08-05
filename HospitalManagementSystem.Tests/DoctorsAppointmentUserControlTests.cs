using System;
using System.Data;
using System.Windows.Forms;
using Moq;
using NUnit.Framework;
using HopitalManagementSystem;
namespace HospitalManagementSystem.Tests
{
    [TestFixture]
    public class DoctorsAppointmentUserControlTests
    {
        private DoctorsAppointmentUserControl _doctorsAppointmentUserControl;
        private Mock<IDatabaseOps> _mockDatabaseOps;

        [SetUp]
        public void SetUp()
        {
            _mockDatabaseOps = new Mock<IDatabaseOps>();
            _doctorsAppointmentUserControl = new DoctorsAppointmentUserControl(_mockDatabaseOps.Object);
        }
        [TearDown]
        public void TearDown()
        {
            _doctorsAppointmentUserControl?.Dispose();
        }

        [Test]
        public void DataGridViewINP_RowHeaderMouseClick_ShouldUpdateFieldsWithSelectedData()
        {
            // Arrange
            var dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Doctor");
            dataTable.Columns.Add("Patient");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("SlotStart");
            dataTable.Columns.Add("SlotEnd");
            dataTable.Rows.Add("123", "Dr. Smith", "John Doe", DateTime.Now.ToString(), "9:00 AM", "10:00 AM");
            _doctorsAppointmentUserControl.dataGridViewINP.DataSource = dataTable;

            var cellMouseEventArgs = new DataGridViewCellMouseEventArgs(0, 0, 0, 0, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));

            // Act
            _doctorsAppointmentUserControl.dataGridViewINP_RowHeaderMouseClick(null, cellMouseEventArgs);

            // Assert
            // Assert
            Assert.That(_doctorsAppointmentUserControl.textBoxAppointmentID.Text, Is.EqualTo("123"));
            Assert.That(_doctorsAppointmentUserControl.comboBoxDoctor.Text, Is.EqualTo("Dr. Smith"));
            Assert.That(_doctorsAppointmentUserControl.comboBoxpatient.Text, Is.EqualTo("John Doe"));

        }

        [Test]
        public void ButtonCancelAppointment_Click_ShouldCancelAppointment_WhenValidAppointmentIdIsProvided()
        {
            // Arrange
            var appointmentId = "123";
            _doctorsAppointmentUserControl.textBoxAppointmentID.Text = appointmentId;
            var oldSlotId = 1;

            _mockDatabaseOps.Setup(db => db.gettimeslotidfromappointment(appointmentId)).Returns(oldSlotId);

            // Act
            _doctorsAppointmentUserControl.buttonCancelAppointment_Click(null, null);

            // Assert
            _mockDatabaseOps.Verify(db => db.gettimeslotidfromappointment(appointmentId), Times.Once);
            _mockDatabaseOps.Verify(db => db.updatetimeslotavailability(oldSlotId, 1), Times.Once);
            _mockDatabaseOps.Verify(db => db.delete("APPOINTMENT", appointmentId), Times.Once);
            _mockDatabaseOps.Verify(db => db.doctorAppointment(), Times.Once);
        }

        [Test]
        public void ButtonCancelAppointment_Click_ShouldShowError_WhenNoAppointmentIdIsProvided()
        {
            // Arrange
            _doctorsAppointmentUserControl.textBoxAppointmentID.Text = string.Empty;
            var messageBoxShown = false;

            _doctorsAppointmentUserControl.MessageBoxOverride = (text, caption, buttons, icon) =>
            {
                messageBoxShown = true;
                return DialogResult.OK;
            };

            // Act
            _doctorsAppointmentUserControl.buttonCancelAppointment_Click(null, null);

            // Assert
            Assert.IsTrue(messageBoxShown);
            _mockDatabaseOps.Verify(db => db.gettimeslotidfromappointment(It.IsAny<string>()), Times.Never);
        }

        [Test]
        public void ButtonReschedule_Click_ShouldRescheduleAppointment_WhenValidDataIsProvided()
        {
            // Arrange
            var appointmentId = "123";
            var doctorId = 1;
            var patientId = 2;
            var slotId = 3;
            var oldSlotId = 4;
            var newDate = DateTime.Now.Date; 

            // Set up data sources for the ComboBoxes
            var doctorTable = new DataTable();
            doctorTable.Columns.Add("ID", typeof(int));
            doctorTable.Columns.Add("DOC_NAME", typeof(string));
            doctorTable.Rows.Add(doctorId, "Dr. Smith");

            var patientTable = new DataTable();
            patientTable.Columns.Add("ID", typeof(int));
            patientTable.Columns.Add("PAT_NAME", typeof(string));
            patientTable.Rows.Add(patientId, "John Doe");

            var slotTable = new DataTable();
            slotTable.Columns.Add("id", typeof(int));
            slotTable.Columns.Add("slotdec", typeof(string));
            slotTable.Rows.Add(slotId, "9:00 AM - 10:00 AM");

            _doctorsAppointmentUserControl.comboBoxDoctor.DisplayMember = "DOC_NAME";
            _doctorsAppointmentUserControl.comboBoxDoctor.ValueMember = "ID";
            _doctorsAppointmentUserControl.comboBoxDoctor.DataSource = doctorTable;

            _doctorsAppointmentUserControl.comboBoxpatient.DisplayMember = "PAT_NAME";
            _doctorsAppointmentUserControl.comboBoxpatient.ValueMember = "ID";
            _doctorsAppointmentUserControl.comboBoxpatient.DataSource = patientTable;

            _doctorsAppointmentUserControl.comboBoxslots.DisplayMember = "slotdec";
            _doctorsAppointmentUserControl.comboBoxslots.ValueMember = "id";
            _doctorsAppointmentUserControl.comboBoxslots.DataSource = slotTable;

            // Set selected values for the ComboBoxes
            _doctorsAppointmentUserControl.textBoxAppointmentID.Text = appointmentId;
            _doctorsAppointmentUserControl.comboBoxDoctor.SelectedValue = doctorId;
            _doctorsAppointmentUserControl.comboBoxpatient.SelectedValue = patientId;
            _doctorsAppointmentUserControl.comboBoxslots.SelectedValue = slotId;
            _doctorsAppointmentUserControl.dateTimePicker1.Value = newDate;

            _mockDatabaseOps.Setup(db => db.gettimeslotidfromappointment(appointmentId)).Returns(oldSlotId);

            // Act
            _doctorsAppointmentUserControl.buttonReschedule_Click(null, null);

            // Assert
            _mockDatabaseOps.Verify(db => db.gettimeslotidfromappointment(appointmentId), Times.Once);
            _mockDatabaseOps.Verify(db => db.updatetimeslotavailability(oldSlotId, 1), Times.Once);
            _mockDatabaseOps.Verify(db => db.updatetimeslotavailability(slotId, 0), Times.Once);
            _mockDatabaseOps.Verify(db => db.update(It.Is<Appointment>(a =>
                a.AppointmentID == appointmentId &&
                a.AppointmentDate == newDate &&
                a.TimeslotID == slotId &&
                a.DoctorID == doctorId &&
                a.PatientID == patientId
            )), Times.Once);
            _mockDatabaseOps.Verify(db => db.doctorAppointment(), Times.Once);
        }



        [Test]
        public void Button1_Click_ShouldInsertAppointment_WhenValidDataIsProvided()
        {
            // Arrange
            var doctorId = 1;
            var patientId = 2;
            var slotId = 3;
            var date = DateTime.Now;
            //var newAppointmentId = "456";

            // Set up data sources for the ComboBoxes
            var doctorTable = new DataTable();
            doctorTable.Columns.Add("ID", typeof(int));
            doctorTable.Columns.Add("DOC_NAME", typeof(string));
            doctorTable.Rows.Add(doctorId, "Dr. Smith");

            var patientTable = new DataTable();
            patientTable.Columns.Add("ID", typeof(int));
            patientTable.Columns.Add("PAT_NAME", typeof(string));
            patientTable.Rows.Add(patientId, "John Doe");

            var slotTable = new DataTable();
            slotTable.Columns.Add("id", typeof(int));
            slotTable.Columns.Add("slotdec", typeof(string));
            slotTable.Rows.Add(slotId, "9:00 AM - 10:00 AM");

            _doctorsAppointmentUserControl.comboBoxDoctor.DisplayMember = "DOC_NAME";
            _doctorsAppointmentUserControl.comboBoxDoctor.ValueMember = "ID";
            _doctorsAppointmentUserControl.comboBoxDoctor.DataSource = doctorTable;

            _doctorsAppointmentUserControl.comboBoxpatient.DisplayMember = "PAT_NAME";
            _doctorsAppointmentUserControl.comboBoxpatient.ValueMember = "ID";
            _doctorsAppointmentUserControl.comboBoxpatient.DataSource = patientTable;

            _doctorsAppointmentUserControl.comboBoxslots.DisplayMember = "slotdec";
            _doctorsAppointmentUserControl.comboBoxslots.ValueMember = "id";
            _doctorsAppointmentUserControl.comboBoxslots.DataSource = slotTable;

            // Set selected values for the ComboBoxes
            _doctorsAppointmentUserControl.comboBoxDoctor.SelectedValue = doctorId;
            _doctorsAppointmentUserControl.comboBoxpatient.SelectedValue = patientId;
            _doctorsAppointmentUserControl.comboBoxslots.SelectedValue = slotId;

            _doctorsAppointmentUserControl.dateTimePicker1.Value = date;

            _mockDatabaseOps.Setup(db => db.insert(It.IsAny<Appointment>()));

            // Act
            _doctorsAppointmentUserControl.button1_Click(null, null);

            // Assert
            _mockDatabaseOps.Verify(db => db.insert(It.Is<Appointment>(a =>
                a.DoctorID == doctorId &&
                a.PatientID == patientId &&
                a.TimeslotID == slotId &&
                a.AppointmentDate == date)), Times.Once);
            _mockDatabaseOps.Verify(db => db.updatetimeslotavailability(slotId, 0), Times.Once);
            _mockDatabaseOps.Verify(db => db.doctorAppointment(), Times.Once);
        }
 
    }
}
