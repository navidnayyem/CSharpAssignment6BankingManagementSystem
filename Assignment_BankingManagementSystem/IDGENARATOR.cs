using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_BankingManagementSystem
{
    class IDGENARATOR
    {
        //taking system date to create an id for an account holder
        static int serial_no = 1;
        string storeId;
        DateTime date = DateTime.Now;

        public string generate()
        {
            string gid = DateTime.Now.ToString("yyyy-MM-");
            storeId = gid + ++serial_no;
            return storeId;
        }
    }
}
