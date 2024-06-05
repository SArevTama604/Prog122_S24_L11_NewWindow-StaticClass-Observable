using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog122_S24_L11_NewWindow_StaticClass_Observable
{
    public class Account
    {
        int userNumber;
        decimal balance;

        // account1.balance -= 50;
        // account2.balance =+ 50;

        public static void TransferMoney(
            Account transferFrom,  
            Account transferTo, 
            decimal amount)
        {

            transferFrom.balance -= amount;
            transferTo.balance += amount;
        }

        public static void ChangeUserNumber(Account account, int newNumber)
        {
            account.userNumber = newNumber;
        }

    }
}
