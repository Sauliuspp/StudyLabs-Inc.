using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Text.RegularExpressions;


namespace WebApplication3
{
    /// <summary>
    /// Summary description for RegexChecker1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RegexChecker1 : System.Web.Services.WebService
    {
        [WebMethod]
        public bool CheckNickname(string input)
        {
            Regex nicknameRegex = new Regex(@"^[a-zA-Z]{3,16}$");
            if (nicknameRegex.IsMatch(input))
            {
                return true;
            }
            else return false;
        }
        [WebMethod]
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
