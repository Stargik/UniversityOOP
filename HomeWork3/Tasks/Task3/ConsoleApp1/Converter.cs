using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Converter
    {
        private readonly decimal currencyUSDtoUAH;
        private readonly decimal currencyEURtoUAH;

        public Converter(decimal currencyUSDtoUAH, decimal currencyEURtoUAH)
        {
            this.currencyUSDtoUAH = currencyUSDtoUAH;
            this.currencyEURtoUAH = currencyEURtoUAH;
        }
        public decimal Convert(decimal value, string from, string to)
        {
            if (from == "UAH")
            {
                switch (to)
                {
                    case "USD":
                        if (currencyUSDtoUAH == 0)
                        {
                            throw new ArgumentException("currencyUSDtoUAH can't be null");
                        }
                        return value / currencyUSDtoUAH;
                    case "EUR":
                        if (currencyEURtoUAH == 0)
                        {
                            throw new ArgumentException("currencyEURtoUAH can't be null");
                        }
                        return value / currencyEURtoUAH;
                    default:
                        throw new ArgumentException("Incorrect currency");
                }
            }
            else if (from == "USD")
            {
                return value * currencyUSDtoUAH;
            }
            else if (from == "EUR")
            {
                return value * currencyEURtoUAH;
            }
            else
            {
                throw new ArgumentException("Incorrect currency");
            }
        }
    }
}
