using System;
using System.Collections.Generic;
using System.Text;

namespace ErickEspinosa.Builder.Domain.AccountAggregate
{
    public class ContactBuilder
    {
        private Contact _contact;
        public ContactBuilder()
        {
            _contact = new Contact();
        }

        public ContactBuilder BuildInfo(string info)
        {
            _contact.Info = info;
            return this;
        }

        public ContactBuilder BuildType(eContactType type)
        {
            _contact.Type = type;
            return this;
        }

        public Contact Build()
        {
            return _contact;
        }

    }
}
