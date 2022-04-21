using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDetail
{
    public interface IOperation
    {
        public List<TotalAmountData> getTotalAmountGroupById(List<AccountData> details);
    }
}
