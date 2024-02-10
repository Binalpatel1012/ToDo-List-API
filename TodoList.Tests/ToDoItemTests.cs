using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoList.Models;
using System;

namespace TodoList.Tests
{
    [TestClass]
    public class ToDoItemTests
    {
        [TestMethod]
        public void CanInstantiateToDoItemWithDefaultValues()
        {
            // Arrange & Act
            var item = new ToDoItem();

            // Assert
            Assert.IsNotNull(item);
            Assert.AreEqual(default, item.Id);
            Assert.IsNull(item.DueDate);
            Assert.IsNull(item.CompletedDate);
            Assert.IsNull(item.Description);
        }

        [TestMethod]
        public void CanAssignAndRetrieveProperties()
        {
            // Arrange
            var item = new ToDoItem();
            var dueDate = DateTime.Now.AddDays(1);
            var completedDate = DateTime.Now;
            var description = "Test ToDoItem";

            // Act
            item.DueDate = dueDate;
            item.CompletedDate = completedDate;
            item.Description = description;

            // Assert
            Assert.AreEqual(dueDate, item.DueDate);
            Assert.AreEqual(completedDate, item.CompletedDate);
            Assert.AreEqual(description, item.Description);
        }

        [TestMethod]
        public void DueDateCanBeSetToFuture()
        {
            // Arrange
            var item = new ToDoItem();
            var futureDate = DateTime.Now.AddDays(10);

            // Act
            item.DueDate = futureDate;

            // Assert
            Assert.IsTrue(item.DueDate > DateTime.Now);
        }

        [TestMethod]
        public void CompletingToDoItemSetsCompletedDate()
        {
            // Arrange
            var item = new ToDoItem();

            // Act
            item.CompletedDate = DateTime.Now;

            // Assert
            Assert.IsNotNull(item.CompletedDate);
        }
    }
}
