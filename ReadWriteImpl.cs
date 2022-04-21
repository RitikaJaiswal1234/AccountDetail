using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDetail
{
    public class ReadWriteImpl : IReadWrite
    {
        public List<AccountData> readFile(string path)
        {
            List<AccountData> data = new List<AccountData>();
            if (File.Exists(path))
            {
                var accountData = new StreamReader(path);
                while (!accountData.EndOfStream)
                {
                    var line = accountData.ReadLine();
                    var column = line.Split(',');
                    data.Add(new AccountData(Convert.ToInt32(column[0]), column[1], Convert.ToInt32(column[2]), Convert.ToInt32(column[3]), Convert.ToInt32(column[4])));

                }
                accountData.Close();
            }
            else
            {
                Console.WriteLine("file doesn't exit");
            }
            return data;
        }
    }
 }

