package business;

import base.*;
import exception.PayException;
import java.util.*;

/**
 *
 * @author mfesser
 * @since 4/23/2014
 *
 * This class is used to hold information about a babysitter.
 */
public class BabySitter extends Employee {

    private double hoursWorked;
    private double hourlyWage;

    /**
     * Gets the pay details for the babaysitter.
     */
    public BabySitter() {
        try {
            System.out.println("how many hours did they work?");
            this.hoursWorked = Double.parseDouble(userInput.nextLine());
            System.out.println("What is their hourly wage?");
            hourlyWage = Double.parseDouble(userInput.nextLine());
        } catch (NumberFormatException nf) {
            System.out.println("The input needs to be numeric.");
        }

    }

    /**
     * Used to calculate the total pay.
     *
     * @throws PayException
     */
    @Override
    public void calculatePay() throws PayException {
        super.setPayAmount(this.hoursWorked * this.hourlyWage);
    }
}
