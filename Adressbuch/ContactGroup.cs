using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressbuch
{
    class ContactGroup
    {
        protected string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        protected List<Contact> Hät { get; set; }
        protected List<ContactGroup> Child { get; set; }

    }
}
