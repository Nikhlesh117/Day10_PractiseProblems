using System;
namespace TestAgeValidator
{
    public class Tests
    {
        private AgeValidator ageValidator;

        [SetUp]
        public void Setup()
        {
            ageValidator = new AgeValidator();
        }

        [Test]
        public void GetCategory_ChildrenAge_ReturnsChildren()
        {
            // Arrange
            int age = 10;
            string expectedCategory = "Children";

            // Act
            string actualCategory = ageValidator.GetCategory(age);

            // Assert
            Assert.AreEqual(expectedCategory, actualCategory);
        }

        [Test]
        public void GetCategory_YouthAge_ReturnsYouth()
        {
            // Arrange
            int age = 20;
            string expectedCategory = "Youth";

            // Act
            string actualCategory = ageValidator.GetCategory(age);

            // Assert
            Assert.AreEqual(expectedCategory, actualCategory);
        }

        [Test]
        public void GetCategory_AdultsAge_ReturnsAdults()
        {
            // Arrange
            int age = 30;
            string expectedCategory = "Adults";

            // Act
            string actualCategory = ageValidator.GetCategory(age);

            // Assert
            Assert.AreEqual(expectedCategory, actualCategory);
        }

        [Test]
        public void GetCategory_SeniorsAge_ReturnsSeniors()
        {
            // Arrange
            int age = 70;
            string expectedCategory = "Seniors";

            // Act
            string actualCategory = ageValidator.GetCategory(age);

            // Assert
            Assert.AreEqual(expectedCategory, actualCategory);
        }
    }
}