using System;
using System.Collections.Generic;
using System.Text;

namespace ErickEspinosa.Builder.Domain.AccountAggregate
{
    public class Contact
    {
        public eContactType Type { get; set; }
        public string Info { get; set; }
    }
}
