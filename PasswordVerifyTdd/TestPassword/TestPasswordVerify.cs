using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Password;

namespace TestPassword
{
    [TestFixture]
    public class TestPasswordVerify
    {
        private PasswordVerifier pass;
        [SetUp]
        public void SetUp(){
            pass = new PasswordVerifier();
        }

        /// <summary>
        /// Test the lenght (at least 8)
        /// </summary>
        /// <param name="password"></param>
        [TestCase("1234567A")]
        public void TestLenght(string password){
            var result = pass.Verify(password);
            Assert.IsTrue(result);
            Assert.GreaterOrEqual(password.Length,8);
        }

        /// <summary>
        /// Test string null or empty
        /// </summary>
        /// <param name="password"></param>
        [TestCase("")]
        [TestCase(null)]
        public void TestStringNull(string password)
        {
            var result = pass.Verify(password);
            Assert.IsFalse(result);
        }

        [TestCase("12345678",false)]
        [TestCase("12345678", false)]
        [TestCase("1234567A", true)]
        public void TestMustContainUpper(string password,bool expected)
        {
            var result = pass.Verify(password);
            Assert.AreEqual(result,expected);
        }
    }
}
