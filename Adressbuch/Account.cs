using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressbuch
{
    class Account
    {

        protected string _emailAdress;
        protected string _name;


        public string EmailAddress
        {
            get { return _emailAdress; }
            set { _emailAdress = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public List<Addressbook> Uses { get; set; }

    }
}
