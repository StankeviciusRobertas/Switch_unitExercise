

using Switch_unitExercise;

namespace Switch_unitTesting
{
    [TestClass]
    public class SwitchTests
    {
        [TestMethod]
        public void TestResultForMoksleivis()
        {
            // Arrange
            int age = 15;
            string expected = "Moksleivis";

            // Act
            string actual = Program.WhoAreYouByAge(age);
            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestResultForPensininkas()
        {
            // Arrange
            int age = 15;
            string expected = "Pensininkas";

            // Act
            string actual = Program.WhoAreYouByAge(age);
            // Assert

            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void TestFromIntToMonthString()
        {
            // Arrange
            int month = 15;
            string expected = "Vasaris";

            // Act
            string actual = Program.monthByNumber(month);
            // Assert

            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void TestFromIntToMonthStringNotExist()
        {
            // Arrange
            int month = 2;
            string expected = "Vasaris";

            // Act
            string actual = Program.monthByNumber(month);
            // Assert

            Assert.AreEqual(expected, actual);
        }
    }
}