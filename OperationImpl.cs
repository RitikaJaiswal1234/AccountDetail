using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDetail
{
    public class OperationImpl : IOperation
    {
        public void getTotalAmountGroupById(List<AccountData> details)
        {
            List<TotalAmountData> resultList = new List<TotalAmountData>();
            Dictionary<int, TotalAmountData> map = new Dictionary<int, TotalAmountData>();
            foreach (AccountData detail in details)
            {
                if (map.ContainsKey(detail.AccountId))
                {
                    // TotalAmountData totalAmountData = map[detail.AccountId];
                    //  totalAmountData.TotalAmount += totalAmountData.AddAmount(detail.Amount, detail.Interest, detail.Month);
                    map[detail.AccountId].AddAmount(detail.Amount, detail.Interest, detail.Month);
                }
                else
                {
                    // map.Add(detail.AccountId, new TotalAmountData(detail.AccountId, detail.Name, detail.Amount, detail.Interest, detail.Month));
                    map[detail.AccountId] = new TotalAmountData(detail.AccountId, detail.Name, detail.Amount, detail.Interest, detail.Month);
                }
            }
               var Writer = new StreamWriter(@"C:\Users\Ritika Jaiswal\Documents\AccountDataresult.csv");
            foreach (var key in map.Keys)
            {
                var line = string.Format(map[key].AccountId+ "," + map[key].Name + "," + map[key].TotalAmount);
                Writer.WriteLine(line);
                Writer.Flush();
            }
            Console.WriteLine(@"C:\Users\Ritika Jaiswal\Documents\AccountDataresult.csv to vie data");
            
        }

        List<TotalAmountData> IOperation.getTotalAmountGroupById(List<AccountData> details)
        {
            throw new NotImplementedException();
        }
    }
}
