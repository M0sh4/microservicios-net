﻿using System;

namespace Order.Common
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
