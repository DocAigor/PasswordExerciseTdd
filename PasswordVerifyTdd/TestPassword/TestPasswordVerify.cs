using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPassword
{
    [TestFixture]
    public class TestPasswordVerify
    {
        private Password pass;
        [SetUp]
        public void SetUp(){
            pass= new Password();
        }

        [TestCase("12345678")]
        public void TestLenght(string password){
            var result = pass.Verify(password);
            Assert.IsTrue(result);
            Assert.GreaterOrEqual(password.Length,8);
        }
    }
}
