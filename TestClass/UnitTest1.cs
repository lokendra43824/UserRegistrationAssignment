using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void Name_Should_startWith_Caps_lengthIsGreaterThan3()
        {
            //arrange
            Validation obj = new Validation();
            bool expected = true;
            string name = "Karan";

            //act
            bool actual = obj.validate(name, "(^[A-Z]{1}[a-z]{2,}$)");

            //assert
            Assert.AreEqual(expected, actual);

        }



        [TestMethod]
        //true
        [DataRow("lokendra@gmail.com")]
        [DataRow("lokendra_123@gmail.com")]
        [DataRow("lokendra+abc@gmail.com")]
        [DataRow("lokendra_loki@gmail.com")]
        [DataRow("lokendra@gmail.com.in")]
        //false
        [DataRow("lokendra..@gmail.com.in")]
        [DataRow("+lokendra@gmail.com")]
        [DataRow("lokendra@.com")]
        [DataRow("lokendra@gmail..com")]
        [DataRow("lokendra.com")]

        public void TestMethod2(string email)
        {
            //arrange
            Validation obj = new Validation();
            bool expected = true;

            //act
            bool actual = obj.validate(email, "(^[a-zA-Z0-9]{1,}([+-_.][a-zA-Z0-9]{1,}){0,}@[a-zA-Z0-9]{1,}(\\.[a-zA-Z]{1,}){0,1}(\\.[a-zA-Z]{2,})$)");

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        public void MobileNumber_StartWith_CountryCode_10Digits()
        {
            //arrange
            Validation obj = new Validation();
            bool expected = true;
            string phoneNumber = "+91 9866256666";

            //act
            bool actual = obj.validate(phoneNumber, "(^[+[1-9]{1,}[0-9\\-]{0,}[ ]{1}[1-9]{1}[0-9]{9}$)");

            //assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]

        public void Passsword_ShouldBe_Strong()
        {
            //arrange
            Validation obj = new Validation();
            bool expected = true;
            string password = "lokendra@123";

            //act
            bool actual = obj.validate(password, "(^(?=.{8,}$)((?=.*[A-Z])(?=.*[0-9])([a-zA-Z0-9]*[!@#$^&*()-+=]{1}[a-zA-Z0-9]*))$)");

            //assert
            Assert.AreEqual(expected, actual);

        }




    }
}
