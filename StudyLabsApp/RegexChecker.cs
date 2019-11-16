using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudyLabsApp
{
    public class RegexChecker
    {
        public delegate bool StringChecker(Regex regex, string input);

        public bool CheckNickname(string input, StringChecker checkValidity)
        {
            Regex nicknameRegex = new Regex(@"^[a-zA-Z]{3,16}$");
            return checkValidity(nicknameRegex, input);
        }

        public bool CheckLink(string input, StringChecker checkValidity)
        { 
            Regex linkRegex = new Regex(@"^www\.facebook\.com/");
            return checkValidity(linkRegex, input);
        }
    }
}
