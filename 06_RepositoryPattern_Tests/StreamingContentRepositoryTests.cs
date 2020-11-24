﻿using System;
using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        private StreamingContentRepository _repo;
        private StreamingContent _content;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Rubber", "A car cones to life with the power to make people explode and goes on a murderous rampage through the Californian Desert", "R", 5.8, false, GenreType.Drama);

            _repo.AddContentToList(_content);
        }

        // Add Method
        [TestMethod]
        public void AddToList_ShouldGetNotNull()
        {
            // Arrange --> Setting up the playing field
            StreamingContent content = new StreamingContent();
            content.Title = "Toy Story";
            StreamingContentRepository repository = new StreamingContentRepository();

            // Act --> Get/run the code we want to test
            repository.AddContentToList(content);
            StreamingContent contentFromDirectory = repository.GetContentByTitle("Toy Story");

            // Assert --> Use the assert class to verify the expected outcome
            Assert.IsNotNull(contentFromDirectory);
        }

        // Update
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            // Arrange
            // TestInitialize
            StreamingContent newContent = new StreamingContent("Rubber 2", "A car cones to life with the power to make people explode and goes on a murderous rampage through the Californian Desert", "R", 10, false, GenreType.RomCom);

            // Act
            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);

            // Assert
            Assert.IsTrue(updateResult);
        }

        [DataTestMethod]
        [DataRow("Rubber", true)]
        [DataRow("Toy Story", false)]
        public void UpdateExistingContent_ShouldMatchGivenBool(string originalTitle, bool shouldUpdate)
        {
            // Arrange
            // TestInitialize
            StreamingContent newContent = new StreamingContent("Rubber 2", "A car cones to life with the power to make people explode and goes on a murderous rampage through the Californian Desert", "R", 10, false, GenreType.RomCom);

            // Act
            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);

            // Assert
            Assert.AreEqual(shouldUpdate, updateResult);
        }

        [TestMethod]
        public void DeleteContent_ShouldReturnTrue()
        {
            // Arrange

            // Act
            bool deleteResult = _repo.RemoveContentFromList(_content.Title);

            // Assert
            Assert.IsTrue(deleteResult);
        }

        [DataTestMethod]
        [DataRow("Rubber", true)]
        
        public void DeleteContent_ShouldMatchGivenBool(string originalTitle, bool shouldUpdate)
        {
            // Arrange

            // Act
            bool deleteResult = _repo.RemoveContentFromList(_content.Title);

            // Assert
            Assert.AreEqual(shouldUpdate, deleteResult);
        }
    }
}
