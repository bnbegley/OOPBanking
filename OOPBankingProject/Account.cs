using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBankingProject {

   public class Account {

        public string Number { get; set; }
        private decimal Balance { get; set; } = 0;
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;

        public void Deposit(decimal Amount) {
            if (Amount <= 0) {
                Console.WriteLine($"Deposit amount must be greater than 0.");
            }
            else {
                this.Balance += Amount;
            }
        }
        public void Withdraw(decimal Amount) {
            if(Amount <= 0) {
                Console.WriteLine("Withdrawl amount must be greater than 0.");
            } else { 
            if (this.Balance >= Amount) {
                this.Balance -= Amount;
            }
            }

        }
        public decimal GetBalance() {
            return this.Balance;

        }
    }
}
