using System.Linq;
using Flurl.Http;
using Flurl.Http.Xml;
using Recurly.NetCore.Models;

namespace Recurly.NetCore
{
    public class RecurlyClient
    {
        private readonly IFlurlClient _flurlClient;
        private readonly string _apiKey;

        public RecurlyClient(string apiKey, string subdomain)
        {
            _apiKey = apiKey;
            _flurlClient = new FlurlClient($"https://{subdomain}.recurly.com/v2");
        }

        public Accounts GetAccounts(int resultsPerPage = 50)
        {
            var accounts = CreateNewRequest(ResourceEndpoints.Accounts)
                .SetQueryParam("per_page", resultsPerPage)
                .GetXmlAsync<Accounts>()
                .Result;

            return accounts; // ToDo: Implement paging of account data.
        }

        public Account GetAccount(string accountCode)
        {
            var account = CreateNewRequest(ResourceEndpoints.Accounts, accountCode)
                .GetXmlAsync<Account>()
                .Result;

            return account;
        }

        private IFlurlRequest CreateNewRequest(params string[] urlSegments)
        {
            return _flurlClient.Request(urlSegments)
                .WithBasicAuth(_apiKey, string.Empty)
                .WithHeader("Accept", "application/xml");
        }
    }
}
