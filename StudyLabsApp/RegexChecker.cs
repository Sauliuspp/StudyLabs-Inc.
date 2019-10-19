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
        public bool CheckNickname(string input)
        {
            Regex nicknameRegex = new Regex(@"^[a-zA-Z]{3,16}$");
            if (nicknameRegex.IsMatch(input))
            {
                return true;
            }
            else return false;
        }

        public bool CheckLink(string input)
        { 
            Regex linkRegex = new Regex(@"^www\.facebook\.com/");
            if (linkRegex.IsMatch(input))
            {
                return true;
            }
            else return false;
        }
    }
}
