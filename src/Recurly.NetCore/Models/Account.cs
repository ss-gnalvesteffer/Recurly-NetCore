using System.Xml.Serialization;

namespace Recurly.NetCore.Models
{
    [XmlRoot(ElementName = "adjustments")]
    public class Adjustments
    {
        [XmlAttribute(AttributeName = "href")]
        public string Href { get; set; }
    }

    [XmlRoot(ElementName = "account_acquisition")]
    public class Account_acquisition
    {
        [XmlAttribute(AttributeName = "href")]
        public string Href { get; set; }
    }

    [XmlRoot(ElementName = "account_balance")]
    public class Account_balance
    {
        [XmlAttribute(AttributeName = "href")]
        public string Href { get; set; }
    }

    [XmlRoot(ElementName = "billing_info")]
    public class Billing_info
    {
        [XmlAttribute(AttributeName = "href")]
        public string Href { get; set; }
    }

    [XmlRoot(ElementName = "invoices")]
    public class Invoices
    {
        [XmlAttribute(AttributeName = "href")]
        public string Href { get; set; }
    }

    [XmlRoot(ElementName = "shipping_addresses")]
    public class Shipping_addresses
    {
        [XmlAttribute(AttributeName = "href")]
        public string Href { get; set; }
    }

    [XmlRoot(ElementName = "subscriptions")]
    public class Subscriptions
    {
        [XmlAttribute(AttributeName = "href")]
        public string Href { get; set; }
    }

    [XmlRoot(ElementName = "transactions")]
    public class Transactions
    {
        [XmlAttribute(AttributeName = "href")]
        public string Href { get; set; }
    }

    [XmlRoot(ElementName = "vat_number")]
    public class Vat_number
    {
        [XmlAttribute(AttributeName = "nil")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "tax_exempt")]
    public class Tax_exempt
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "address2")]
    public class Address2
    {
        [XmlAttribute(AttributeName = "nil")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "phone")]
    public class Phone
    {
        [XmlAttribute(AttributeName = "nil")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "address")]
    public class Address
    {
        [XmlElement(ElementName = "address1")]
        public string Address1 { get; set; }

        [XmlElement(ElementName = "address2")]
        public Address2 Address2 { get; set; }

        [XmlElement(ElementName = "city")]
        public string City { get; set; }

        [XmlElement(ElementName = "state")]
        public string State { get; set; }

        [XmlElement(ElementName = "zip")]
        public string Zip { get; set; }

        [XmlElement(ElementName = "country")]
        public string Country { get; set; }

        [XmlElement(ElementName = "phone")]
        public Phone Phone { get; set; }
    }

    [XmlRoot(ElementName = "accept_language")]
    public class Accept_language
    {
        [XmlAttribute(AttributeName = "nil")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "created_at")]
    public class Created_at
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "updated_at")]
    public class Updated_at
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "closed_at")]
    public class Closed_at
    {
        [XmlAttribute(AttributeName = "nil")]
        public string Nil { get; set; }
    }

    [XmlRoot(ElementName = "has_live_subscription")]
    public class Has_live_subscription
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "has_active_subscription")]
    public class Has_active_subscription
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "has_future_subscription")]
    public class Has_future_subscription
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "has_canceled_subscription")]
    public class Has_canceled_subscription
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "has_past_due_invoice")]
    public class Has_past_due_invoice
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "account")]
    public class Account
    {
        [XmlElement(ElementName = "adjustments")]
        public Adjustments Adjustments { get; set; }

        [XmlElement(ElementName = "account_acquisition")]
        public Account_acquisition Account_acquisition { get; set; }

        [XmlElement(ElementName = "account_balance")]
        public Account_balance Account_balance { get; set; }

        [XmlElement(ElementName = "billing_info")]
        public Billing_info Billing_info { get; set; }

        [XmlElement(ElementName = "invoices")]
        public Invoices Invoices { get; set; }

        [XmlElement(ElementName = "shipping_addresses")]
        public Shipping_addresses Shipping_addresses { get; set; }

        [XmlElement(ElementName = "subscriptions")]
        public Subscriptions Subscriptions { get; set; }

        [XmlElement(ElementName = "transactions")]
        public Transactions Transactions { get; set; }

        [XmlElement(ElementName = "account_code")]
        public string Account_code { get; set; }

        [XmlElement(ElementName = "state")]
        public string State { get; set; }

        [XmlElement(ElementName = "username")]
        public string Username { get; set; }

        [XmlElement(ElementName = "email")]
        public string Email { get; set; }

        [XmlElement(ElementName = "cc_emails")]
        public string Cc_emails { get; set; }

        [XmlElement(ElementName = "first_name")]
        public string First_name { get; set; }

        [XmlElement(ElementName = "last_name")]
        public string Last_name { get; set; }

        [XmlElement(ElementName = "company_name")]
        public string Company_name { get; set; }

        [XmlElement(ElementName = "vat_number")]
        public Vat_number Vat_number { get; set; }

        [XmlElement(ElementName = "tax_exempt")]
        public Tax_exempt Tax_exempt { get; set; }

        [XmlElement(ElementName = "address")]
        public Address Address { get; set; }

        [XmlElement(ElementName = "accept_language")]
        public Accept_language Accept_language { get; set; }

        [XmlElement(ElementName = "hosted_login_token")]
        public string Hosted_login_token { get; set; }

        [XmlElement(ElementName = "created_at")]
        public Created_at Created_at { get; set; }

        [XmlElement(ElementName = "updated_at")]
        public Updated_at Updated_at { get; set; }

        [XmlElement(ElementName = "closed_at")]
        public Closed_at Closed_at { get; set; }

        [XmlElement(ElementName = "has_live_subscription")]
        public Has_live_subscription Has_live_subscription { get; set; }

        [XmlElement(ElementName = "has_active_subscription")]
        public Has_active_subscription Has_active_subscription { get; set; }

        [XmlElement(ElementName = "has_future_subscription")]
        public Has_future_subscription Has_future_subscription { get; set; }

        [XmlElement(ElementName = "has_canceled_subscription")]
        public Has_canceled_subscription Has_canceled_subscription { get; set; }

        [XmlElement(ElementName = "has_past_due_invoice")]
        public Has_past_due_invoice Has_past_due_invoice { get; set; }

        [XmlAttribute(AttributeName = "href")]
        public string Href { get; set; }
    }

    [XmlRoot(ElementName = "accounts")]
    public class Accounts
    {
        [XmlElement(ElementName = "account")]
        public Account Account { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }
}
