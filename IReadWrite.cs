using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDetail
{
    public  interface IReadWrite
    {
        public List<AccountData> readFile(string path);

       
    }
}
