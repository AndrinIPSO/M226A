﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressbuch
{
    class Addressbook
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<Contact> Contains { get; set; }

        public List<ContactGroup> ConntainsGroup { get; set; }



    }
}
