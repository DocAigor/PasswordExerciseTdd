using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Password
{
    public class PasswordVerifier
    {
        List<string> alphabet = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        List<string> numbers = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        List<string> specialChars = new List<string> { "\\", "|", "!", "£", "$", "%", "/", "(", ")", "=", "?", "'", "\"", "^", "@", "#", "[", "]", "<", ">", ",", ":", ".", ";", "-", "_", "*", "+" };
        
        public bool Verify(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;

            var containsUpperLower = (from c in alphabet
                                      where password.Contains(c.ToUpper()) &&
                                            password.Contains(c)
                                      select c).Any();
            var containsNumber = (from n in numbers
                                  where password.Contains(n)
                                  select n).Any();
            var containsSpecialChars = (from s in specialChars
                                        where password.Contains(s)
                                        select s).Any();
            return (containsSpecialChars && containsNumber && containsUpperLower && password.Length >= 8);
        }
    }
}
