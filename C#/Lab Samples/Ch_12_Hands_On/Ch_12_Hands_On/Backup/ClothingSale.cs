/* Class Name:			ClothingSale
 * Programmer:			Bradley/Millspaugh
 * Date:				June 2009
 * Description:			Handle clothing sale information.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Ch12HandsOn
{
    class ClothingSale
    {
        protected int quantityInteger, productIdInteger;
        protected decimal discountRateDecimal, unitPriceDecimal,
            extendedPriceDecimal;
        protected static decimal salesTotalDecimal;
        protected static int salesCountInteger;
        protected static decimal[] priceDecimal = new decimal[100];
        private bool runOnceBoolean = false;


        public int ProductNumber
        {
            get
            {
                return productIdInteger;
            }
            private set
            {
                productIdInteger = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantityInteger;
            }
            set
            {
                quantityInteger = value;
            }
        }
        public decimal UnitPrice
        {
            get
            {
                return unitPriceDecimal;
            }
            set
            {
                unitPriceDecimal = value;
            }
        }

        public decimal DiscountRate
        {
            get
            {
                return discountRateDecimal;
            }
            set
            {
                discountRateDecimal = value;
            }
        }

        public decimal ExtendedPrice
        {
            get
            {
                return extendedPriceDecimal;
            }
            set
            {
                extendedPriceDecimal = value;
            }
        }

        public static decimal SalesTotal
        {
            get
            {
                return salesTotalDecimal;
            }
        }

        public static int SalesCount
        {
            get
            {
                return salesCountInteger;
            }
        }

        public ClothingSale(int productIdInteger, int quantityInteger,
            decimal discountDecimal)
        {
            // Constructor.

            if (!runOnceBoolean)
            {
                loadPriceList();
            }
            ProductNumber = productIdInteger;
            UnitPrice = priceDecimal[ProductNumber];
            Quantity = quantityInteger;
            DiscountRate = discountDecimal;
            calculateExtendedPrice();
            addToTotals();
        }

        protected virtual void calculateExtendedPrice()
        {
            // Find the ExtendedPrice.

            extendedPriceDecimal = unitPriceDecimal * (1 - discountRateDecimal)
                * quantityInteger;
        }


        protected void addToTotals()
        {
            // Add to summary information.

            salesCountInteger++;
            salesTotalDecimal += extendedPriceDecimal;
        }

        private void loadPriceList()
        {
            try
            {
                StreamReader productsStreamReader = new StreamReader("Products.txt");
                string productString;
                int indexInteger = 0;
                while (productsStreamReader.Peek() != -1)
                {
                    productString = productsStreamReader.ReadLine();
                    priceDecimal[indexInteger] = decimal.Parse(productsStreamReader.ReadLine());
                    indexInteger++;
                }
                productsStreamReader.Close();
            }
            catch
            {
                // Allow list to default to zeros.//
            }
        }
    }
}
