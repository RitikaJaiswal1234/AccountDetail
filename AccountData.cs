using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDetail
{
    public class AccountData
    {
        public int AccountId { get; set; }
        public string Name { get; set; } 
        public int Amount { get; set; }
        public float Interest { get; set; }
        public int Month { get; set; }
       
        public AccountData(int AccountId, string Name, int Amount,float Interest, int Month)
        {
           this.AccountId = AccountId;
            this.Name = Name;
            this.Amount = Amount;
            this.Interest = Interest;
            this.Month = Month;
            
        }

       
    }
}
