using System;

namespace Api.Gateway.Models.Common
{
    public class Enums
    {
        public enum OrderStatus
        {
            Cancel,
            Pending,
            Approved
        }

        public enum OrderPayment
        {
            CredditCard,
            Paypal,
            BankTransfer
        }
    }
}
