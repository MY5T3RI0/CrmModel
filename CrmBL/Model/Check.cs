using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class Check
    {
        public int CheckId { get; set; }

        public DateTime Created { get; set; }

        public int SellerId { get; set; }

        public virtual Seller Seller { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public int SellId { get; set; }

        public virtual Sell Sell { get; set; }

        public override string ToString()
        {
            return $"Чек №{CheckId} от {Created.ToString("dd.MM.yy hh:mm")}";
        }

    }
}
