using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDetail
{
    public class TotalAmountData
    {
        public int AccountId { get; set; }
        public string Name { get; set; }
        public float TotalAmount { get; set; }
       

        public TotalAmountData(int AccountId, string Name, int Amount, float Interest, int Month)
        {
           this.AccountId = AccountId;
           this.Name = Name;
           float temp = (Amount * Interest * Month)/(100 * 12);
           this.TotalAmount = temp;
        }

        public float AddAmount(int Amount,float Interest ,int Month)
        {
            float temp = (Amount * Interest * Month) / 100 * 12;
            this.TotalAmount += temp;
            return TotalAmount;
        }
    }
}
