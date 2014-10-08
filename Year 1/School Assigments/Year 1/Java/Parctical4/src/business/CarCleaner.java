package business;

import base.*;
import exception.PayException;
import java.util.*;

/**
 *
 * @author mfesser
 */
public class CarCleaner extends Employee {

    private double carsWashed;
    private double carsWaxed;
    private static final int WAGEWASH = 20;
    private static final int WAGEWAX = 50;

    /**
     * Gets the pay details for the car cleaner.
     */
    public CarCleaner() {
        try {
            System.out.println("how many cars did they wash?");
            this.carsWashed = Double.parseDouble(userInput.nextLine());
            System.out.println("how many cars did they wax?");
            this.carsWaxed = Double.parseDouble(userInput.nextLine());
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
        super.setPayAmount((this.carsWashed * this.WAGEWASH) + (this.carsWaxed * WAGEWAX));
    }
}
