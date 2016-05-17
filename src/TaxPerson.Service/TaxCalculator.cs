using System.Collections.Generic;

namespace TaxPerson.Service
{
    public static class TaxCalculator
    {
        public static List<Item> LuxaryItems = new List<Item>
        {
            Item.Apple,
            Item.Choclate,
            Item.Beer
        };

        public static List<Item> Necessity = new List<Item>
        {
            Item.Water
        };


        public static double Calculate(double costBeforeTax, Item item)
        {
            double result = 0;
            if (LuxaryItems.Contains(item))
            {
                result = CalculateTaxForLuxaryItem(costBeforeTax);
            }
            else if (Necessity.Contains(item))
            {
                result = CalculateTaxForNecessityItem(costBeforeTax);
            }

            return result;
        }

        private static double CalculateTaxForNecessityItem(double costBeforeTax)
        {
            var taxedAmount = costBeforeTax * 0.01;
            return costBeforeTax + taxedAmount;
        }

        private static double CalculateTaxForLuxaryItem(double costBeforeTax)
        {
            var taxedAmount = costBeforeTax * 0.09;
            return costBeforeTax + taxedAmount;
        }
    }
}
