using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDetail
{
    public class Executer
    {
        public static void Main(String[] args)
        {

            string path = (@"C:\Users\Ritika Jaiswal\Documents\AccountData.csv");
            ReadWriteImpl readWriteImpl = new ReadWriteImpl();
            List<AccountData> accountData = readWriteImpl.readFile(path);
            OperationImpl operationImpl = new OperationImpl();
           operationImpl.getTotalAmountGroupById(accountData);
         

        }
    }
}