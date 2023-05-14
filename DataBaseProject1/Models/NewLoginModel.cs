using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProject1.Models
{
    internal class NewLoginModel
    {
        public int userId { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string authenticatorKey { get; set; }
        public string uri { get; set; }
        public int favorite { get; set; }
        public int masterPswdRePrompt { get; set; }
        public string notes { get; set; }
    }
}
