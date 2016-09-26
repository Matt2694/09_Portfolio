using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Portfolio
{
    internal class Stock : IAsset
    {
        private double numShares;
        private double pricePerShare;
        private string symbol;
        public Stock()
        {
        }
        public Stock(string a, double b, double c)
        {
            Symbol = a;
            PricePerShare = b;
            NumShares = c;
        }

        public double NumShares { get { return numShares; } internal set { numShares = value; } }
        public double PricePerShare { get { return pricePerShare; } internal set { pricePerShare = value; } }
        public string Symbol { get { return symbol; } internal set { symbol = value; } }

        public double GetValue()
        {
            return PricePerShare * NumShares;
        }

        public static double TotalValue(IAsset[] stocks)
        {
            double total = 0;
            for(int i = 0; i < stocks.Length; i++)
            {
                total += stocks[i].GetValue();
            }
            return total;
        }
        public override string ToString()
        {
            string format = "Stock[symbol=" + Symbol + ",pricePerShare=" + PricePerShare + ",numShares=" + NumShares + "]";
            return format;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Stock Compareobject = (Stock)obj;
            if (Compareobject.Symbol == this.Symbol && Compareobject.PricePerShare == this.PricePerShare && Compareobject.NumShares == this.NumShares)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
