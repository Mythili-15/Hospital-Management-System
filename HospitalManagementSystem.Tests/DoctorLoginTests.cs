using HopitalManagementSystem;
using Moq;
using NUnit.Framework;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalManagementSystem.Tests
{
    [TestFixture]
    public class DoctorLoginTests
    {
        private Mock<IDatabaseOps> _mockDatabaseOps;
        private DoctorLogin _doctorLoginForm;

        [SetUp]
        public void SetUp()
        {
            _mockDatabaseOps = new Mock<IDatabaseOps>();
            _doctorLoginForm = new DoctorLogin(_mockDatabaseOps.Object);

            // Initialize the form and controls
            _doctorLoginForm.InitializeComponent();
            _doctorLoginForm.Show(); // Ensure the form is shown to trigger control events
            _doctorLoginForm.textboxError.Visible = false; // Initialize error visibility to false
        }

        [TearDown]
        public void TearDown()
        {
            _doctorLoginForm?.Dispose();
        }

        [Test]
        public void Button1_Click_ShouldCallLogin_WhenCredentialsAreProvided()
        {
            // Arrange
            _doctorLoginForm.textBoxUsername.Text = "validDoctor";
            _doctorLoginForm.textBoxPass.Text = "validPass";
            var expectedUserLogin = new UserLogin
            {
                Username = "validDoctor",
                Pass = "validPass"
            };

            // Act
            _doctorLoginForm.button1_Click(null, null);

            // Assert
            _mockDatabaseOps.Verify(db => db.login(It.Is<UserLogin>(
                ul => ul.Username == expectedUserLogin.Username && ul.Pass == expectedUserLogin.Pass),
                "doctorLogin"), Times.Once);
        }

        [Test]
        public void Button1_Click_ShouldShowError_WhenUsernameIsMissing()
        {
            // Arrange
            _doctorLoginForm.textBoxUsername.Text = "";
            _doctorLoginForm.textBoxPass.Text = "validPass";

            // Act
            _doctorLoginForm.button1_Click(null, null);

            // Assert
            Assert.IsTrue(_doctorLoginForm.textboxError.Visible);
            Assert.That(_doctorLoginForm.button1.BackColor, Is.EqualTo(Color.FromArgb(_doctorLoginForm.textboxError.ForeColor.ToArgb())));
            _mockDatabaseOps.Verify(db => db.login(It.IsAny<UserLogin>(), It.IsAny<string>()), Times.Never);
        }

        [Test]
        public void Button1_Click_ShouldShowError_WhenPasswordIsMissing()
        {
            // Arrange
            _doctorLoginForm.textBoxUsername.Text = "validDoctor";
            _doctorLoginForm.textBoxPass.Text = "";

            // Act
            _doctorLoginForm.button1_Click(null, null);

            // Assert
            Assert.IsTrue(_doctorLoginForm.textboxError.Visible);
            Assert.That(_doctorLoginForm.button1.BackColor, Is.EqualTo(Color.FromArgb(_doctorLoginForm.textboxError.ForeColor.ToArgb())));
            _mockDatabaseOps.Verify(db => db.login(It.IsAny<UserLogin>(), It.IsAny<string>()), Times.Never);
        }
    }
}
