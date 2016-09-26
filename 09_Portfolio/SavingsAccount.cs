using System;

namespace _09_Portfolio
{
    internal class SavingsAccount : IAsset
    {
        public double Value { get; set; }
        public double InterestRate { get; set; }
        public string Account { get; set; }
        public SavingsAccount()
        {

        }
        public SavingsAccount(string a, double b, double c)
        {
            Account = a;
            Value = b;
            InterestRate = c;
        }
        public double GetValue()
        {
            return Value;
        }

        internal void ApplyInterest()
        {
            Value += Value * (InterestRate / 100);
        }
        public override string ToString()
        {
            string format = string.Format("SavingsAccount[value={0:0.0},interestRate={1:0.0}]", Value, InterestRate);
            return format;
        }
    }
}