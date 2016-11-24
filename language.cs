using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLanguages
{
    public class language
    {
        HRegsiter.Settings settings = new HRegsiter.Settings();
        public string current;
        INIFile ini;

        public string position
        {
            get
            {
                return ini.ReadValue("initilize", "position");
            }
        }
        string mainSection = "words";
        public string UserName
        {
            get
            {
                return ini.ReadValue(mainSection, "UserName");
            }
        }
        public string Password
        {
            get
            {
                return ini.ReadValue(mainSection, "Password");
            }
        }
        public string LoginPanel
        {
            get
            {
                return ini.ReadValue(mainSection, "LoginPanel");
            }
        }
        public language()
        {
            current = settings.language;
            ini = new INIFile(string.Format("Languages\\{0}.ini", current));
        }

    }
}
