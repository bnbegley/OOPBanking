using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBankingProject {
    class MoneyMarket : Account {


        public double IntRateMM {get; set; } = 0.02;


        public override string Print() {
            return base.Print() + $" | {IntRateMM}";
        }


            public void PayInt(decimal AmountofIntMM) {
            this.Deposit(AmountofIntMM);
        }


        public decimal MMCalcIntRate(int time) {
            double IntToBePaidMM = IntRateMM / 12 * time * (double)this.GetBalance();
            return (decimal)IntToBePaidMM;
        }
    }
}
