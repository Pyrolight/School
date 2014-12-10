using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaInAMinute
{
    /*
    Class Name: Order
    Author: Michael Fesser
    Version: #1.0
    Description: This is the order class for Pizza in a Minute.  It accepts values for all the options on the main order form
    and then does some basic calcualtions to find the total cost of the pizza.  It also builds output strings for the order summary form.
    Dependencies: None.
    Change History: None.
    */
    class Order
    {
        // Default tax rate.  
        private const decimal TAX_RATE = .14m;

        // Constants for all the various prices of the pizzas.
        private const decimal SMALL_HAM_PINEAPPLE_PRICE = 10.95m;
        private const decimal SMALL_CHICKEN_LICKEN_PRICE = 11.95m;
        private const decimal SMALL_BEEF_EATER_PRICE = 14.95m;
        private const decimal SMALL_VEGGIE_PRICE = 10.95m;
        private const decimal SMALL_CANADIAN_PRICE = 13.95m;
        private const decimal SMALL_AMERICAN_PRICE = 13.95m;
        private const decimal SMALL_CHEF_CREATION_PRICE = 14.95m;
        private const decimal SMALL_BUILD_YOUR_OWN_PRICE = 7.95m;
        // Constants for medium and large pizzas.
        private const decimal MEDIUM_PRICE = 4.00m;
        private const decimal LARGE_PRICE = 8.00m;

        // Constants for all the various prices of the crusts.
        private const decimal REGULAR_PRICE = 0m;
        private const decimal CHEESE_FILLED_PRICE = 2.00m;
        private const decimal PRETZEL_PRICE = 2.50m;
        private const decimal MEAT_FILLED_PRICE = 3.00m;
        private const decimal SAUCE_FILLED_PRICE = 2.00m;
        private const decimal SPIN_THE_WHEEL_PRICE = 3.00m;

        // Constants for all the various prices of the toppings.
        private const decimal HAM_PRICE = 1.50m;
        private const decimal PEPPERONI_PRICE = 1.50m;
        private const decimal SAUSAGE_PRICE = 1.50m;
        private const decimal HAMBURGER_PRICE = 1.50m;
        private const decimal SALAMI_PRICE = 1.50m;
        private const decimal ONION_PRICE = 1.50m;
        private const decimal GREEN_PEPPER_PRICE = 1.50m;
        private const decimal PINEAPPLE_PRICE = 1.50m;
        private const decimal OLIVES_PRICE = 1.50m;
        private const decimal MUSHROOMS_PRICE = 1.50m;
        private const decimal TOTATOES_PRICE = 1.50m;
        private const decimal EXTRA_SAUCE_PRICE = 1.50m;
        private const decimal EXTRA_CHEESE_PRICE = 1.50m;
        private const decimal EXTRA_THINK_CRUST_PRICE = 1.50m;

        // Constants for all the various prices of the extras.
        private const decimal TWISTY_BREAD_PRICE = 2.00m;
        private const decimal GARLIC_FINGERS_PRICE = 3.00m;
        private const decimal CRAZY_BREAD_PRICE = 4.00m;
        private const decimal HOT_WINGS_PRICE = 3.00m;
        private const decimal BUFFALO_WINGS_PRICE = 3.00m;
        private const decimal CHEF_WINGS_PRICE = 3.00m;

        // Constants for all the various prices of the drinks.
        private const decimal PEPSI_PRICE = 2.00m;
        private const decimal COKE_PRICE = 2.00m;
        private const decimal ROOT_BEER_PRICE = 2.00m;

        // Auto properties used due to the fact no validation or minipulation of the values occures in the setters.
        // Used for see which pizza type was selected.
        public Boolean hamPineapple { get; set; }
        public Boolean chickenLicken { get; set; }
        public Boolean beefEater { get; set; }
        public Boolean veggie { get; set; }
        public Boolean canadian { get; set; }
        public Boolean american { get; set; }
        public Boolean chefCreation { get; set; }
        public Boolean buildYourOwn { get; set; }

        // Used for the size of the pizza.
        public int hamPineappleCombo { get; set; }
        public int chickenLickenCombo { get; set; }
        public int beefEaterCombo { get; set; }
        public int veggieCombo { get; set; }
        public int canadianCombo { get; set; }
        public int americanCombo { get; set; }
        public int chefCreationCombo { get; set; }
        public int buildYourOwnCombo { get; set; }

        // Used to see which crust was selected.
        public Boolean regularCrust { get; set; }
        public Boolean cheezeFilled { get; set; }
        public Boolean pretzel { get; set; }
        public Boolean meatFilled { get; set; }
        public Boolean sauceFilled { get; set; }
        public Boolean spinTheWheel { get; set; }

        // Used to see which topping was selected.
        public Boolean ham { get; set; }
        public Boolean pepperoni { get; set; }
        public Boolean sausage { get; set; }
        public Boolean hamburger { get; set; }
        public Boolean salami { get; set; }
        public Boolean onion { get; set; }
        public Boolean greenPepper { get; set; }
        public Boolean pineapple { get; set; }
        public Boolean olives { get; set; }
        public Boolean mushrooms { get; set; }
        public Boolean tomatoes { get; set; }
        public Boolean extraSauce { get; set; }
        public Boolean extraCheese { get; set; }
        public Boolean extraThinkCrust { get; set; }

        // Used to see which extra was selected.
        public Boolean twistyBread { get; set; }
        public Boolean garlicFingers { get; set; }
        public Boolean crazyBread { get; set; }
        public Boolean hotWings { get; set; }
        public Boolean buffaloWings { get; set; }
        public Boolean chefWings { get; set; }

        // Used to see which drink was selected.
        public Boolean pepsi { get; set; }
        public Boolean coke { get; set; }
        public Boolean rootBeer { get; set; }

        // Used to gather the customer information.
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String address { get; set; }
        public String phoneNumber { get; set; }
        public String email { get; set; }

        // Used for the output strings for the order summary form.
        public String pizzaString { get; set; }
        public String toppingsString { get; set; }
        public String extraString { get; set; }
        public String drinksString { get; set; }
        public String customerInfoString { get; set; }

        /*
        Method name: calculateSubTotal
        Version: #1.0
        Author: Michael Fesser
        Description: This method caculates the subtotal for the pizza and other items.  The strings used in the
        order summary form are built here as well.
        Outputs: None.
        Returns: subtotal
        Change History: None.
        */
        public decimal calculateSubTotal()
        {
            // Set defaults values.
            decimal subtotal = 0m;
            this.pizzaString = "";
            this.toppingsString = "";
            this.extraString = "";
            this.drinksString = "";

            // The following arrays are used to simplify the if/else checks.
            // This holds the true and false values for the pizza selection.
            Boolean[] pizza = { this.hamPineapple, this.chickenLicken, this.beefEater, this.veggie, this.canadian, this.american, 
                                  this.chefCreation, this.buildYourOwn };
            // This holds the constants for the prices of the pizzas.
            Decimal[] pizzaSmallPrice = {SMALL_HAM_PINEAPPLE_PRICE,SMALL_CHICKEN_LICKEN_PRICE,SMALL_BEEF_EATER_PRICE,SMALL_VEGGIE_PRICE,SMALL_CANADIAN_PRICE,
                                            SMALL_AMERICAN_PRICE,SMALL_CHEF_CREATION_PRICE,SMALL_BUILD_YOUR_OWN_PRICE};
            // This holds the size chosen for the pizzas.
            int[] pizzaCombo = {this.hamPineappleCombo,this.chickenLickenCombo,this.beefEaterCombo,this.veggieCombo,this.canadianCombo,
                this.americanCombo,this.chefCreationCombo,this.buildYourOwnCombo};
            // This is a string array for the names of the pizzas.
            String[] pizzaStringArray = {"ham and pineapple", "chicken licken", "beef eater", "veggie", "canadian", "american", "chef's creation",
                                   "build your own"};

            // This holds the true and false values for the crust selection.
            Boolean[] crust = { this.regularCrust, this.cheezeFilled, this.pretzel, this.meatFilled, this.sauceFilled, this.spinTheWheel };
            // This holds the constants for the prices of the crusts.
            Decimal[] crustPrice = { REGULAR_PRICE, CHEESE_FILLED_PRICE, PRETZEL_PRICE, MEAT_FILLED_PRICE, SAUCE_FILLED_PRICE, SPIN_THE_WHEEL_PRICE };
            // This is a string array for the names of the crusts.
            String[] crustStringArray = { "regular", "cheese filled", "pretzel", "meat filled", "sauce filled", "spin the wheel" };

            // This holds the true and false values for the toppins selection.
            Boolean[] toppings = { this.ham, this.pepperoni, this.sausage, this.hamburger, this.salami, this.onion, this.greenPepper, 
                                 this.pineapple, this.olives, this.mushrooms, this.tomatoes, this.extraSauce, this.extraCheese, this.extraThinkCrust };
            // This holds the constants for the prices of the toppins.
            Decimal[] toppingsPrice = { HAM_PRICE, PEPPERONI_PRICE, SAUSAGE_PRICE, HAMBURGER_PRICE, SALAMI_PRICE, ONION_PRICE,GREEN_PEPPER_PRICE,
                                          PINEAPPLE_PRICE, OLIVES_PRICE, MUSHROOMS_PRICE, TOTATOES_PRICE, EXTRA_SAUCE_PRICE, EXTRA_CHEESE_PRICE, EXTRA_THINK_CRUST_PRICE};
            // This is a string array for the names of the toppings.
            String[] toppingsStringArray = {"Ham", "Pepperoni", "Sausage", "Hamburger", "Salami", "Onion", "Green Pepper", "Pineapple", "Olives",
                                         "Mushrooms", "Tomatoes", "Extra Sauce", "Extra Cheese", "Extra Think Crust"};

            // This holds the true and false values for the extra selection.
            Boolean[] extra = { this.twistyBread, this.garlicFingers, this.crazyBread, this.hotWings, this.buffaloWings, this.chefWings };
            // This holds the constants for the prices of the extras.
            Decimal[] extraPrice = { TWISTY_BREAD_PRICE, GARLIC_FINGERS_PRICE, CRAZY_BREAD_PRICE, HOT_WINGS_PRICE, BUFFALO_WINGS_PRICE, CHEF_WINGS_PRICE };
            // This is a string array for the names of the extras.
            String[] extraStringArray = { "TwistyBread", "GarlicFingers", "CrazyBread", "HotWings", "BuffaloWings", "ChefWings" };

            // This holds the true and false values for the drinks selection.
            Boolean[] drinks = { this.pepsi, this.coke, this.rootBeer };
            // This holds the constants for the prices of the drinks.
            Decimal[] drinksPrice = { PEPSI_PRICE, COKE_PRICE, ROOT_BEER_PRICE };
            // This is a string array for the names of the drinks.
            String[] drinkStringArray = { "Pepsi", "Coke", "Root Beer" };

            // Calculate the subtotal for the pizza chosen.
            for (int i = 0; i < pizza.Length; i++)
            {
                // Check the pizza array and if the pizza was chosen set the price and use this position in the other related arrays for their values.
                if (pizza[i] == true)
                {
                    // Pizza size.
                    if (pizzaCombo[i] == 0)
                    {
                        subtotal += pizzaSmallPrice[i];
                    }
                    else if (pizzaCombo[i] == 1)
                    {
                        subtotal += pizzaSmallPrice[i] + MEDIUM_PRICE;
                    }
                    else if (pizzaCombo[i] == 2)
                    {
                        subtotal += pizzaSmallPrice[i] + LARGE_PRICE;
                    }
                    // Build String.
                    this.pizzaString += "You ordered: \r\n\r\nA " + pizzaStringArray[i] + " pizza, ";
                }
            }

            // Calculate the subtotal for the crust chosen.
            for (int i = 0; i < crust.Length; i++)
            {
                // Check the crust array and if the crust was chosen set the price and use this position in the other related arrays for their values.
                if (crust[i] == true)
                {
                    subtotal += crustPrice[i];
                    // Build String.
                    this.pizzaString += " with a " + crustStringArray[i] + " crust.";
                }
            }

            // Calculate the subtotal for the toppings chosen.
            for (int i = 0; i < toppings.Length; i++)
            {
                // Check the toppings array and if the topping was chosen set the price and use this position in the other related arrays for their values.
                if (toppings[i] == true)
                {
                    subtotal += toppingsPrice[i];
                    // Build String.
                    toppingsString += toppingsStringArray[i] + "\r\n";
                }
            }

            // Calculate the subtotal for the extras chosen.
            for (int i = 0; i < extra.Length; i++)
            {
                // Check the extras array and if the extra was chosen set the price and use this position in the other related arrays for their values.
                if (extra[i] == true)
                {
                    subtotal += extraPrice[i];
                    // Build String.
                    extraString += extraStringArray[i] + "\r\n";
                }
            }

            // Calculate the subtotal for the drinks chosen.
            for (int i = 0; i < drinks.Length; i++)
            {
                // Check the drinks array and if the drinks was chosen set the price and use this position in the other related arrays for their values.
                if (drinks[i] == true)
                {
                    subtotal += drinksPrice[i];
                    // Build String.
                    drinksString += drinkStringArray[i] + "\r\n";
                }
            }
            return subtotal;
        }

        /*
        Method name: calculateTotal
        Version: #1.0
        Author: Michael Fesser
        Description: This method calculates the total based on the current tax rate.
        Outputs: None.
        Returns: total
        Change History: None.
        */
        public decimal calculateTotal(decimal subTotal)
        {
            decimal total = 0m;
            total = subTotal * TAX_RATE + subTotal;
            return total;
        }

        /*
        Method name: contactInfo
        Version: #1.0
        Author: Michael Fesser
        Description: This method builds a string for the customer contact info.
        Outputs: None.
        Returns: Noting.
        Change History: None.
        */
        public void contactInfo()
        {
            // Build String.
            this.customerInfoString = this.firstName + " " + this.lastName + "\r\n" + this.address + "\r\n" + this.phoneNumber + "\r\n" + this.email;
        }
    }
}
