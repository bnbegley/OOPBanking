﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBankingProject {
    public class Savings : Account {

        public double IntRate { get; set; } = 0.03;

        public bool ChangeRate(double chgRate) {
            if ((this.IntRate + chgRate) <0) {
                return false;
            }
            this.IntRate += chgRate;
            return true;
        }

        public override string Print() {
            return base.Print() + $" | {IntRate}";
        }
        
        public void PayInterest (decimal AmountofInterest) {
            this.Deposit(AmountofInterest);
        }

        public decimal CalcInterest(int months) {
           double InterestToBePaid = this.IntRate / 12 * months * (double)this.GetBalance();
            return (decimal)InterestToBePaid;
        }

    }
}
