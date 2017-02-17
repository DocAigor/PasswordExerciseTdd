using NUnit.Framework;
using System;
using System.Text;
using Password;

namespace TestPassword
{
    [TestFixture]
    public class TestPasswordVerify
    {
        private PasswordVerifier pass;
        [SetUp]
        public void SetUp()
        {
            pass = new PasswordVerifier();
        }

        /// <summary>
        /// Test the lenght (at least 8)
        /// </summary>
        /// <param name="password"></param>
        [TestCase("12345@aA")]
        public void TestLenght(string password)
        {
            var result = pass.Verify(password);
            Assert.IsTrue(result);
            Assert.GreaterOrEqual(password.Length, 8);
        }

        /// <summary>
        /// Test string has at least one upper letter, 
        /// one tolower letter, one number
        /// and not is null or empty
        /// ------------------------
        /// features: should be contains a special char
        /// NO SPACE
        /// </summary>
        /// <param name="password"></param>
        /// <param name="expected"></param>
        [TestCase("", false)]
        [TestCase(null, false)]
        [TestCase("123Aa!", false)]
        [TestCase("12Ab!$", false)]
        [TestCase("12345678", false)]
        [TestCase("123456aA", false)]
        [TestCase("1234567A", false)]
        [TestCase("123456aA", false)]
        [TestCase("AaBbCcDd", false)]
        [TestCase("Aa12Cc34", false)]
        [TestCase("Aa12Cc!@", true)]
        public void TestPassword(string password, bool expected)
        {
            var result = pass.Verify(password);
            Assert.AreEqual(result, expected);
        }
    }
}
