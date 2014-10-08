/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package delivery;

import javax.swing.JOptionPane;
import java.text.DecimalFormat;

/**
 *
 * @author Michael
 * @since 11/11/2013
 */
public class CreateDelivery {

    /**
     * @author Michael
     * @since 11/11/2013
     * @param args the command line arguments
     *
     * The main method will get arguments from the user and do basic validation
     * on them. It will pass the validated arguments to the Delivery class via a
     * constructor and finally output the results.
     */
    public static void main(String[] args) {

        int deliveryYear;
        int deliveryNumber;
        double weight;
        int deliveryDistance;

        do {                                                                    // validate the year from 2001 - 2025 inclusive.
            deliveryYear = Integer.parseInt(JOptionPane.showInputDialog("What is the year of the delivery?  "
                    + "Please enter a year between 2001 and 2025."));
        } while (deliveryYear < 2001 || deliveryYear > 2025);
        do {                                                                    // validate the deliver number from 1 - 9999 inclusive.
            deliveryNumber = Integer.parseInt(JOptionPane.showInputDialog("What is the delivery number?  "
                    + "Please enter a number between 1 and 9999."));
        } while (deliveryNumber < 1 || deliveryNumber > 9999);
        do {                                                                    // validate the weight from .10 - 100 inclusive.
            weight = Double.parseDouble(JOptionPane.showInputDialog("How many pounds is the package?  "
                    + "Please enter a weight between .10 pounds and 100 pounds."));
        } while (weight <= .10 || weight > 100);
        do {                                                                    // validate the distance to 1 for local or 2 for long distance.
            deliveryDistance = Integer.parseInt(JOptionPane.showInputDialog("Is the package local or is it long distance?  "
                    + "Hit 1 for local and 2 for long distance."));
        } while (deliveryDistance < 1 || deliveryDistance > 2);

        Delivery deliveryObject = new Delivery(deliveryYear, deliveryNumber, weight, deliveryDistance);  // create object.  Pass variables to constructor.

        DecimalFormat decimalFormat = new DecimalFormat("0.00");                // Two decimal place formating.

        /*
         * The format of this output is designed based on what seemed the most
         * logical output. The delivery year and number are not returned but the
         * resulting combined string is.
         */
        JOptionPane.showMessageDialog(null, "The delivery number is " + deliveryObject.getFullDeliveryNumber()
                + "\nThe delivery is " + deliveryObject.getDeliverDistanceUsefulOutput() + "."
                + "\nThe weight is " + decimalFormat.format(deliveryObject.getWeight()) + " pounds."
                + "\nThe fee for delivery is $" + decimalFormat.format(deliveryObject.getFee()));
    }
}
