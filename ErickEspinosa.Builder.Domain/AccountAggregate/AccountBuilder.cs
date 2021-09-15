using System;
using System.Collections.Generic;
using System.Text;

namespace ErickEspinosa.Builder.Domain.AccountAggregate
{
    public class AccountBuilder
    {
        private Account _account;

        public AccountBuilder()
        {
            _account = new Account();
        }

        public AccountBuilder BuildContacts(List<Contact> contacts)
        {
            _account.Contacts = contacts;
            return this;
        }

        public AccountBuilder BuildName(string name)
        {
            _account.Name = name;
            return this;
        }

        public AccountBuilder BuildUsername(string username)
        {
            _account.Username = username;
            return this;
        }

        public Account Build()
        {
            return _account;
        }
    }
}
