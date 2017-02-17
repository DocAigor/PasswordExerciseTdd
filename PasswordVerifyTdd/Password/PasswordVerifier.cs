using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Password
{
    public class PasswordVerifier
    {
        public bool Verify(string password)
        {
            return (password.Length >= 8);
        }
    }
}
