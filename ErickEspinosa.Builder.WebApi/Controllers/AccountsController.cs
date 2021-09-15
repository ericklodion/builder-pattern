using ErickEspinosa.Builder.Domain.AccountAggregate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErickEspinosa.Builder.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAccounts()
        {
            var accounts = new List<Account>();

            var accountOne = new AccountBuilder()
                .BuildName("Frank Stuart")
                .BuildUsername("frankst")
                .Build();

            var accountTwo = new AccountBuilder()
                .BuildName("Mark Zuck")
                .BuildUsername("zuck")
                .Build();

            accounts.Add(accountOne);
            accounts.Add(accountTwo);

            return Ok(accounts);
        }

        [HttpGet]
        [Route("{username}/contacts")]
        public IActionResult GetContacts(string username)
        {
            var contactOne = new ContactBuilder()
                .BuildType(eContactType.Fone)
                .BuildInfo("351555698451")
                .Build();

            var contactTwo = new ContactBuilder()
                .BuildType(eContactType.Email)
                .BuildInfo("markzuck@facebook.com")
                .Build();

            var account = new AccountBuilder()
                .BuildName("Frank Stuart")
                .BuildUsername("frankst")
                .BuildContacts(new List<Contact> { contactOne, contactTwo })
                .Build();

            return Ok(account.Contacts);
        }
    }
}
