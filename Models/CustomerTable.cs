using System;
using System.Collections.Generic;

namespace CustomerManagement.Models
{
    public partial class CustomerTable
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustAddress { get; set; }
        public int CustBarrowedBooks { get; set; }
        public string CustPhoto { get; set; }
    }
}
