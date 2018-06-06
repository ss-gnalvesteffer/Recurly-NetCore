using System;

namespace Recurly.NetCore.Example
{
    class Program
    {
        private static void Main(string[] args)
        {
            var recurlyClient = new RecurlyClient("91e61f4431184fcbb557f24f041a2e71", "shipstation-dev");
            var accounts = recurlyClient.GetAccounts(10);
        }
    }
}
