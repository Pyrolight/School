package usedcar;

import javax.swing.JOptionPane;

/**
 *
 * @author Michael Fesser
 * @since 11/29/2013
 *
 * The purpose of this project is to create a program that will calculate the
 * depreciation of a vehicle based on a a number of factors.
 *
 * It will also test some basic exception handling.
 *
 */
public class UsedCar {

    /**
     * @author Michael Fesser
     * @since 11/29/2013
     *
     * The purpose of this method is to ask the user for variables that will be
     * used to calculate the depreciation on a vehicle and then pass them to a
     * car object.
     *
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        String vehiclePriceString;
        double vehiclePrice;
        String milageString;
        int mileage;
        String transmissionType;
        String sunroof;
        char inputAnotherVehicle;

        do {                                                                    // Loop until the user wants to exit.                                                                 
            do {                                                                // Loop while vehiclePrice is out of range.
                do {                                                            // Exception catching loop.
                    vehiclePriceString = JOptionPane.showInputDialog("What is the price of the vehicle?");
                    try {                                                       // Try to parse vehiclePriceString to a double.
                        vehiclePrice = Double.parseDouble(vehiclePriceString);
                        break;
                    } catch (NumberFormatException e) {                         // If not not a number do nothing.  This stops the program from crashing.
                    }
                    JOptionPane.showMessageDialog(null, "You need to enter a number.");  // Alert user to error.
                } while (true);                                                 // Loop while there is an error.
                if (vehiclePrice <= 0) {                                        // Check if vehiclePrice is less than zero.
                    JOptionPane.showMessageDialog(null, "The price needs to be greater than zero.");  // Alert user to error.
                } else if (vehiclePrice > 100000000) {                                 // Check if vehiclePrice is greater than 100,000,000.
                    JOptionPane.showMessageDialog(null, "You tried to enter a price over 100,000,000 dollars.");  // Alert user to error.
                }
            } while (vehiclePrice < 0 || vehiclePrice > 100000000);             // The check for the vehiclePrice loop.

            /*
             * These two do/while loops function exactly as above.  The first loop checks to
             * see if the value is in range and the second loop does the exception handling.
             */
            do {
                do {
                    milageString = JOptionPane.showInputDialog("How many miles are on the vehicle?");
                    try {
                        mileage = Integer.parseInt(milageString);
                        break;
                    } catch (NumberFormatException e) {
                    }
                    JOptionPane.showMessageDialog(null, "You need to enter a number.");
                } while (true);
                if (mileage <= 0) {
                    JOptionPane.showMessageDialog(null, "The mileage needs to be greater then zero.");
                } else if (mileage > 1000000) {
                    JOptionPane.showMessageDialog(null, "This car has over 1000000 miles on it!  It has no resale value.");
                }
            } while (mileage < 0 || mileage > 1000000);

            do {                                                                 // Loop until tranmissionType is A or M.
                transmissionType = JOptionPane.showInputDialog("What type of transmission does it have?"
                        + "\nHit a for Automatic\nHit m for Manual").substring(0, 1).toUpperCase();  // User input error handling.
            } while (!"A".equals(transmissionType) && !"M".equals(transmissionType));  // The check for the transmissionType loop.

            do {                                                                  // Loop until sunroof is Y or N.
                sunroof = JOptionPane.showInputDialog("Does the vehicle havea sunroof?"
                        + "\nHit y for Yes\nHit n for No").substring(0, 1).toUpperCase();  // User input error handling.
            } while (!"Y".equals(sunroof) && !"N".equals(sunroof));             // The check for the sunroof loop.

            UsedCarProperties vehicle = new UsedCarProperties(vehiclePrice, mileage, transmissionType, sunroof);  // Create a car obejct and pass the vaiable to the constructor.
            JOptionPane.showMessageDialog(null, vehicle);                           // Call the toSrting method in the UsedCarProperties class.

            do {                                                                 // Loop until inputAnotherVehicle is Y or N.
                inputAnotherVehicle = JOptionPane.showInputDialog("Would you like to enter another vehicle? \nHit y for Yes\nHit n for No").toUpperCase().charAt(0);  // User input error handling.
            } while (inputAnotherVehicle != 'Y' && inputAnotherVehicle != 'N');         // The check for the inputAnotherVehicle loop.         
        } while (inputAnotherVehicle == 'Y');                                       // The check to exit the program.
    }
}
