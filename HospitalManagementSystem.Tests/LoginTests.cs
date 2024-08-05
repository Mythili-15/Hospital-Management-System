using HopitalManagementSystem;
using Moq;
using NUnit.Framework;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalManagementSystem.Tests
{
    [TestFixture]
    public class LoginTests
    {
        private Mock<IDatabaseOps> _mockDatabaseOps;
        private IServiceProvider _serviceProvider;
        private Login _loginForm;

        [SetUp]
        public void SetUp()
        {
            _mockDatabaseOps = new Mock<IDatabaseOps>();
            _serviceProvider = new Mock<IServiceProvider>().Object;
            _loginForm = new Login(_serviceProvider, _mockDatabaseOps.Object);

            // Initialize the form and controls
            _loginForm.InitializeComponent();
            _loginForm.Show(); 
            _loginForm.textboxError.Visible = false; 
        }

        [TearDown]
        public void TearDown()
        {
            _loginForm?.Dispose();
        }

        [Test]
        public void Button1_Click_ShouldCallLogin_WhenCredentialsAreProvided()
        {
            // Arrange
            _loginForm.textBoxUsername.Text = "validUser";
            _loginForm.textBoxPass.Text = "validPass";
            var expectedUserLogin = new UserLogin
            {
                Username = "validUser",
                Pass = "validPass"
            };

            // Act
            _loginForm.button1_Click(null, null);

            // Assert
            _mockDatabaseOps.Verify(db => db.login(It.Is<UserLogin>(
                ul => ul.Username == expectedUserLogin.Username && ul.Pass == expectedUserLogin.Pass),
                "employeeLogin"), Times.Once);
        }

        [Test]
        public void Button1_Click_ShouldShowError_WhenUsernameIsMissing()
        {
            // Arrange
            _loginForm.textBoxUsername.Text = "";
            _loginForm.textBoxPass.Text = "validPass";

            // Act
            _loginForm.button1_Click(null, null);

            // Assert
            Assert.IsTrue(_loginForm.textboxError.Visible);
            Assert.That(_loginForm.button1.BackColor, Is.EqualTo(Color.FromArgb(_loginForm.textboxError.ForeColor.ToArgb())));
            _mockDatabaseOps.Verify(db => db.login(It.IsAny<UserLogin>(), It.IsAny<string>()), Times.Never);
        }

        [Test]
        public void Button1_Click_ShouldShowError_WhenPasswordIsMissing()
        {
            // Arrange
            _loginForm.textBoxUsername.Text = "validUser";
            _loginForm.textBoxPass.Text = "";

            // Act
            _loginForm.button1_Click(null, null);

            // Assert
            Assert.IsTrue(_loginForm.textboxError.Visible);
            Assert.That(_loginForm.button1.BackColor, Is.EqualTo(Color.FromArgb(_loginForm.textboxError.ForeColor.ToArgb())));
            _mockDatabaseOps.Verify(db => db.login(It.IsAny<UserLogin>(), It.IsAny<string>()), Times.Never);
        }
    }
}