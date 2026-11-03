using System;
using System.Collections.Generic;
using System.Text;
using Economy;

namespace Economy.Currency
{
    public class Wallet
    {
        public int Balance { get; private set;  }
        public Wallet(int startingBalance = 100)
        {
            Balance = startingBalance;
        }

        public bool CanAfford(int amount) => Balance >= amount;

        public void Receive(int amount)
        {
            if (amount > 0) Balance += amount; // received amount must be greater than 0
        }

        public bool Spend(int amount)
        {
            if (amount < 0 || !CanAfford(amount)) return false; // cant afford
            Balance -= amount;
            return true;
        }
        public void SetBalance(int amount)
        {
            Balance = Math.Max(0, amount); // gets rid of corrupted files
            // if:
            // loaded balance = 50; setBalance to 50
            //if loaded balance = -30; setBalance to 0
        }
    }
}
