using System;
using System.Collections.Generic;

namespace _09_Portfolio
{
    internal class Portfolio : IAsset
    {
        private List<IAsset> stocks;

        public Portfolio()
        {
            stocks = new List<IAsset>();
        }
        public Portfolio(List<IAsset> stocks)
        {
            this.stocks = stocks;
        }

        internal double GetTotalValue()
        {
            double total = 0;
            foreach(IAsset aPart in stocks)
            {
                total += aPart.GetValue();
            }
            return total;
        }

        internal void AddAsset(IAsset classInstance)
        {
            stocks.Add(classInstance);
        }

        public double GetValue()
        {
            throw new NotImplementedException();
        }
    }
}