
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Tabungan
    {
        private int balance;

        public Tabungan()
        {
            this.balance = 100000;
        }

        public int checkBalance()
        {
            return this.balance;
        }

        public bool addBalance(int balance)
        {
            this.balance += balance;

            if (this.balance - 5000 > 0)
            {
                administrationCharge(5000);
                return true;
            }
            return false;
        }

        public void administrationCharge(int amount)
        {
            this.balance -= amount;
        }

        public bool getCashWithdrawalIDR(int amount)
        {
            if (this.balance - amount > 0)
            {
                this.balance -= amount;
                return true;
            }
            return false;
        }

        public bool getCashWithdrawalUSD(int amount)
        {
            int balance = this.balance - (amount * 13000) - (50 * amount);

            if (balance > 0)
            {
                administrationCharge(50 * amount);
                this.balance -= (amount * 13000);
                return true;
            }
            return false;
        }

        public void checkBalanceAllowance(bool allowed)
        {
            if (!allowed)
                Console.WriteLine("Gagal, saldo tidak mencukupi");
        }
    }
}
