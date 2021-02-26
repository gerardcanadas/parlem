using System;
using System.Collections.Generic;
using System.Text;

namespace parlem.domain.Models.Product
{
    public class Product
    {
        private int _productId;
        private string _productName;
        private string _productTypeName;
        private long _terminalNumeration;
        private DateTime _soldAt;

        public int ProductId { get => _productId; set => _productId = value; }
        public string ProductName { get => _productName; set => _productName = value; }
        public string ProductTypeName { get => _productTypeName; set => _productTypeName = value; }
        public long TerminalNumeration { get => _terminalNumeration; set => _terminalNumeration = value; }
        public DateTime SoldAt { get => _soldAt; set => _soldAt = value; }
    }
}
