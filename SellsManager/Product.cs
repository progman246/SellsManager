using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Product
    {
        public int RecordNumber { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public override string ToString()
        {
            return $"{RecordNumber}|{ProductId}|{Price}|{Quantity}";
        }

    }
}
