using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudentEnumerator.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void NumberOfStudentsMatchExpectation()
        {
            var sr = new StudentRepository();
            var expectedCount = 0;

            var count = sr.GetNumberOfStudents();

            Assert.AreEqual(expectedCount, count, "Antalet studenter är inte det förväntade");
        }

        [TestMethod]
        public void AddOneStudentAndCheckNumberOfStudents()
        {
            var sr = new StudentRepository();
            var person = new Teacher("Fredrik");
            var expectedCount = 1;

            sr.Add(person);
            var count = sr.GetNumberOfStudents();

            Assert.AreEqual(expectedCount, count, "Antalet studenter är inte det förväntade");
        }

        [TestMethod]
        public void TestSayGoodMorning()
        {
            var sr = new StudentRepository();
            var person = new Teacher("Fredrik");
            var expectedCount = 1;

            sr.Add(person);
            var result = sr.SayGoodMorning();

            Assert.AreEqual(expectedCount, result.Count);
        }
    }
}
