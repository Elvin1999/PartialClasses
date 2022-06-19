using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class BankAccount
    {
        public BankAccount()
        {
            Console.WriteLine("Default constructor");
        }
        public void Start()
        {
            ShowAccount();
            UpdateAccount();

        }
        partial void ShowAccount()
        {
            Console.WriteLine("kapital bank hesab 1000 azn");
        }

        partial void UpdateAccount()
        {
            Console.WriteLine("updated account");
        }

    }
}
