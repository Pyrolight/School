/*
 * Class Name:			MemberClothingSale
 * Programmer:			Bradley/Millspaugh
 * Date:				June 2009
 * Description:			Handle book sale information for member sales,
                        which receive a 10% discount.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Ch12HandsOn
{
    class MemberClothingSale : ClothingSale
    {
        const decimal MEMBER_DISCOUNT_Decimal = .1M;

        public MemberClothingSale(int productIdInteger,
            int quantityInteger, decimal discountDecimal)
            :
            base(productIdInteger, quantityInteger, discountDecimal)
        {
            // Call the base class constructor and pass arguments.
        }

        //Method in the derived class that overrides the method in the base class
        protected override void calculateExtendedPrice()
        {
            // Find the ExtendedPrice.
            decimal discountDecimal;

            discountDecimal = DiscountRate + MEMBER_DISCOUNT_Decimal;
            ExtendedPrice = unitPriceDecimal * (1 - discountDecimal) * Quantity;
        }
    }
}
