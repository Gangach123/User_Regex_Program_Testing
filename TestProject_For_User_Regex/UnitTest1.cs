using Microsoft.VisualStudio.TestTools.UnitTesting;
using Regex_Problems;
using User_Regestartion;

namespace TestProject_For_User_Regex
{
    [TestClass]
    public class UnitTest1
    {
        Validation validation = new Validation();
        [TestMethod]
        public void GivenRight_FirstName_ReturnTrue()
        {
            string actual = validation.ValidateFirstName("Ganga");
            string expected = "Valid firstName";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenWrong_FirstName_ReturnFalse()
        {
            try
            {
                string actual = validation.ValidateFirstName("ganga");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Invalid firstName", ex.Message);
            }
        }


        [TestMethod]
        public void GivenRight_LastName_ReturnTrue()
        {
            string actual = validation.ValidateLastName("Shiva");
            string expected = "Valid lastName";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenWrong_LastName_ReturnFalse()
        {
            try
            {
                string actual = validation.ValidateLastName("Ch");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Invalid lastName", ex.Message);
            }

        }

        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void GivenRight_Email_ReturnTrue(string EmailId)
        {
            try
            {
                string actual = validation.ValidateEmail(EmailId);
  

            }

            catch (CustomException ex)
            {
                Assert.AreEqual("Valid email", ex.Message);
            }
        }

        [TestMethod]
        [DataRow("abc@.com.my")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc..2002@gmail.com")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@gmail.com.aa.au")]
        public void GivenWrong_Email_ReturnFalse(string EmailId1)
        {
            try
            {
                string actual = validation.ValidateEmail(EmailId1);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Invalid email", ex.Message);
            }
        }


        [TestMethod]
        public void GivenRight_mobileNo_ReturnTrue()
        {
            string actual = validation.ValidateMobileNo("91 7702173235");
            string expected = "Valid mobileNo";

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GivenWrong_mobileNo_ReturnFalse()
        {
            try
            {
                string actual = validation.ValidateMobileNo("7 702173235");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Invalid mobileNo", ex.Message);
            }
        }



        [TestMethod]
        public void GivenRight_Password_ReturnTrue()
        {
            try
            {
                string actual = validation.ValidatePassword("abcDE#1234");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Valid password", ex.Message);
            }
            
        }

        [TestMethod]
        public void GivenWrong_Password_ReturnFalse()
        {
            try
            {
                string actual = validation.ValidatePassword("abCD12");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Invalid password", ex.Message);
            }
        }
    }
}