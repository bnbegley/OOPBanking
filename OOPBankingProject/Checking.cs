using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBankingProject {
    class Checking : Account {


        private int CheckNbr = 0;
        private decimal Amount;



        public bool Pay(int CheckNumber, decimal Amount) {


            bool success = this.Withdraw(Amount);
            if (success) {
                this.CheckNbr = CheckNumber;
                this.Amount = Amount;
                return true;
            }
            return false;
        }


        public override string Print() {
            return base.Print() + $" | {this.CheckNbr} | {this.Amount}";
        } 

    }
}
