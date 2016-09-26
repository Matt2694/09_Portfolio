using System;

namespace _09_Portfolio{

    internal class Stock : IAsset{

        public double NumShares { get; set; }
        public double PricePerShare { get; set; } 
        public string Symbol { get; set; }

        public Stock() { }

        public Stock(string symbol, double pricePerShare, double numShares){

            Symbol = symbol;
            PricePerShare = pricePerShare;
            NumShares = numShares;
        }

        public double GetValue(){

            return PricePerShare * NumShares;
        }

        public static double TotalValue(IAsset[] stocks){

            double total = 0;
            foreach(IAsset instance in stocks){
                total += instance.GetValue();
            }
            return total;
        }

        public override string ToString(){

            string format = "Stock[symbol=" + Symbol + ",pricePerShare=" + PricePerShare + ",numShares=" + NumShares + "]";
            return format;
        }

        public override int GetHashCode(){

            return base.GetHashCode();
        }

        public override bool Equals(object obj){

            Stock Compareobject = (Stock)obj;
            if (Compareobject.Symbol == this.Symbol && Compareobject.PricePerShare == this.PricePerShare && Compareobject.NumShares == this.NumShares){
                return true;
            }
            else{
                return false;
            }
        }
    }
}
