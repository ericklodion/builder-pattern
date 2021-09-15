using System;
using System.Collections.Generic;
using System.Text;

namespace ErickEspinosa.Builder.Domain.AccountAggregate
{
    public class Account
    {
        public IEnumerable<Contact> Contacts { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
    }
}
