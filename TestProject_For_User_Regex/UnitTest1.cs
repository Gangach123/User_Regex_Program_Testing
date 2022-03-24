using Microsoft.VisualStudio.TestTools.UnitTesting;
using Regex_Problems;

namespace TestProject_For_User_Regex
{
    [TestClass]
    public class UnitTest1
    {
        Validation validation = new Validation();
        [TestMethod]
        public void IfGiven_Name_Is_True_ReturnTrue()
        {
            bool actual = validation.ValidateFirstName("Ganga");
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IfGiven_Name_Is_False_ReturnFalse()
        {
            bool actual = validation.ValidateFirstName("Ga");
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IfGiven_lastName_Is_True_ReturnTrue()
        {
            bool actual = validation.ValidateLastName("Chilamakooru");
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IfGiven_lastName_Is_False_ReturnFalse()
        {
            bool actual = validation.ValidateLastName("2h6");
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IfGiven_mail_Is_True_ReturnTrue()
        {
            bool actual = validation.Validating_Email("chilamakooru.gangaiiit@gmail.com");
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IfGiven_mail_Is_False_ReturnFalse()
        {
            bool actual = validation.Validating_Email("chila@12@gmail.com");
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IfGiven_number_Is_True_ReturnTrue()
        {
            bool actual = validation.ValidatingNumber("91 7702173235");
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IfGiven_number_Is_False_ReturnFalse()
        {
            bool actual = validation.ValidatingNumber("09 0977021732");
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
    }
}