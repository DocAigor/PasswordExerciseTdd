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

        [TestCase("12345678")]
        public void TestLenght(string password){
            var result = pass.Verify(password);
            Assert.IsTrue(result);
            Assert.GreaterOrEqual(password.Length,8);
        }
    }
}
