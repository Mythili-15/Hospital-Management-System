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
    public class RoomCRUDTests
    {
        private Mock<IDatabaseOps> _mockDatabaseOps;
        private RoomCRUD _roomCRUDForm;

        [SetUp]
        public void Setup()
        {
            _mockDatabaseOps = new Mock<IDatabaseOps>();
            _roomCRUDForm = new RoomCRUD(_mockDatabaseOps.Object);
        }

        [TearDown]
        public void TearDown()
        {
            _roomCRUDForm?.Dispose();
        }

        [Test]
        public void buttonRoomInsert_Click_ValidData_CallsInsertAndDisplays()
        {
            // Arrange
            _roomCRUDForm.textBoxRoomNo.Text = "101";
            _roomCRUDForm.comboBoxFloorNo.Text = "1";
            // Act
            _roomCRUDForm.buttonRoomInsert_Click(null, EventArgs.Empty);
            // Assert
            _mockDatabaseOps.Verify(m => m.insert(It.IsAny<Room>()), Times.Once);
            _mockDatabaseOps.Verify(m => m.display("ROOM"), Times.Exactly(2)); // Including the call in the constructor
        }

        [Test]
        public void buttonRoomInsert_Click_IncompleteData_ShowsMessageBox()
        {
            // Arrange
            _roomCRUDForm.textBoxRoomNo.Text = "101";

            bool messageBoxShown = false;

            _roomCRUDForm.MessageBoxOverride = (text, caption, buttons, icon) =>
            {
                messageBoxShown = true;
                return DialogResult.OK;
            };

            // Act
            _roomCRUDForm.buttonRoomInsert_Click(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(messageBoxShown);
            _mockDatabaseOps.Verify(m => m.insert(It.IsAny<Room>()), Times.Never);
            _mockDatabaseOps.Verify(m => m.display("ROOM"), Times.Once);
        }

        [Test]
        public void buttonRoomUpdate_Click_ValidData_CallsUpdateAndDisplays()
        {
            // Arrange
            _roomCRUDForm.textBoxRoomNo.Text = "101";
            _roomCRUDForm.comboBoxFloorNo.Text = "1";

            // Act
            _roomCRUDForm.buttonRoomUpdate_Click(null, EventArgs.Empty);

            // Assert
            _mockDatabaseOps.Verify(m => m.update(It.IsAny<Room>()), Times.Once);
            _mockDatabaseOps.Verify(m => m.display("ROOM"), Times.Exactly(2)); // Including the call in the constructor
        }

        [Test]
        public void buttonRoomUpdate_Click_IncompleteData_ShowsMessageBox()
        {
            // Arrange
            _roomCRUDForm.textBoxRoomNo.Text = "101";

            bool messageBoxShown = false;

            // Hook into MessageBox to check if the warning is shown
            _roomCRUDForm.MessageBoxOverride = (text, caption, buttons, icon) =>
            {
                messageBoxShown = true;
                return DialogResult.OK;
            };

            // Act
            _roomCRUDForm.buttonRoomUpdate_Click(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(messageBoxShown);
            _mockDatabaseOps.Verify(m => m.update(It.IsAny<Room>()), Times.Never);
            _mockDatabaseOps.Verify(m => m.display("ROOM"), Times.Once); // Only the initial call in the constructor
        }

        [Test]
        public void buttonRoomDelete_Click_ValidData_CallsDeleteAndDisplays()
        {
            // Arrange
            _roomCRUDForm.textBoxRoomID.Clear(); // Clear any existing text
            _roomCRUDForm.textBoxRoomID.Text = "101"; // Set the ID appropriately

            // Act
            _roomCRUDForm.buttonRoomDelete_Click(null, EventArgs.Empty);

            // Assert
            _mockDatabaseOps.Verify(m => m.delete("ROOM", "101"), Times.Once);
            _mockDatabaseOps.Verify(m => m.display("ROOM"), Times.Exactly(2)); // Including the call in the constructor
        }



        [Test]
        public void buttonRoomDelete_Click_NoID_InvokesMessageBox()
        {
            // Arrange
            _roomCRUDForm.textBoxRoomID.Text = "";

            bool messageBoxInvoked = false;

            // Hook into MessageBox to check if the error message is invoked
            _roomCRUDForm.MessageBoxOverride = (text, caption, buttons, icon) =>
            {
                messageBoxInvoked = true;
                return DialogResult.OK;
            };

            // Act
            _roomCRUDForm.buttonRoomDelete_Click(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(messageBoxInvoked);
            _mockDatabaseOps.Verify(m => m.delete("ROOM", It.IsAny<string>()), Times.Never);
            _mockDatabaseOps.Verify(m => m.display("ROOM"), Times.Once); // Only the initial call in the constructor
        }

        [Test]
        public void textBoxSearchValue_TextChanged_CallsSearch()
        {
            // Arrange
            _roomCRUDForm.textBoxSearchValue.Text = "SearchValue";
            _roomCRUDForm.comboBoxSearchBy.Text = "ColumnName";

            // Act
            _roomCRUDForm.textBoxSearchValue_TextChanged(null, EventArgs.Empty);

            // Assert
            _mockDatabaseOps.Verify(m => m.search("SearchValue", "ColumnName"), Times.Once);
        }

    }
}
