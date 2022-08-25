using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class Sell
    {
        public int SellId { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public ICollection<Check> Checks { get; set; }
    }
}
