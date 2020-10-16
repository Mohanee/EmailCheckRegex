using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmailCheck;

namespace TestCases
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        [DataRow("Mohanee")]
        [DataRow("monu")]
        [DataRow("prom")]
        [DataRow("Prudhvi")]
        public void Valid_FirstName_Should_Return_True(string message)
        {
            ValidateEntry v = new ValidateEntry();

            var result = v.ValidateFirstName(message);

            Assert.IsTrue(result);
        }


        [TestMethod]
        [DataRow("Dammu")]
        [DataRow("Ra")]
        [DataRow("ram")]
        public void Valid_LastName_Should_Return_True(string message)
        {
            ValidateEntry v = new ValidateEntry();

            var result = v.ValidateLastName(message);

            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("9672917619")]
        [DataRow("91 9827470809")]
        [DataRow("45283293")]
        [DataRow("jhvkyjved")]
        [DataRow("926 8936393")]
        public void Valid_MobileNumber_Should_Return_True(string message)
        {
            ValidateEntry v = new ValidateEntry();

            var result = v.ValidateMobileNumber(message);

            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("ab@c@.com.my")]
        [DataRow("abc..2002@gmail.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("mohanee99@gmail.com")]
        public void Valid_Email_Should_Return_True(string message)
        {
            ValidateEntry v = new ValidateEntry();

            var result = v.ValidateEmail(message);

            Assert.IsTrue(result);
        }


        [TestMethod]
        [DataRow("monu@1708")]
        [DataRow("Monu@1708")]
        [DataRow("!@@#nkjbd")]
        [DataRow("Monu018392")]
        public void Valid_Password_Should_Return_True(string message)
        {
            ValidateEntry v = new ValidateEntry();

            var result = v.ValidatePassword(message);

            Assert.IsTrue(result);
        }

    }
}
