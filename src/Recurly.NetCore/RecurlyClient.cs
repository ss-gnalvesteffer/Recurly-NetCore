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
            var accounts = CreateNewRequest("accounts")
                .SetQueryParam("per_page", resultsPerPage)
                .GetXmlAsync<Accounts>()
                .Result;

            return accounts;
        }

        private IFlurlRequest CreateNewRequest(string resource)
        {
            return _flurlClient.Request(resource)
                .WithBasicAuth(_apiKey, string.Empty)
                .WithHeader("Accept", "application/xml");
        }
    }
}
