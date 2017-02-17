using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Password
{
    public class PasswordVerifier
    {
        List<string> dictionary = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        public bool Verify(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;

            var containsUpper = (from c in dictionary
                                where password.Contains(c.ToUpper())
                                select c).Any();      
            return (containsUpper && password.Length >= 8);
        }
    }
}
