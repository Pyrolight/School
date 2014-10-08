package business;

import base.*;
import exception.PayException;
import java.util.*;

/**
 *
 * @author mfesser
 */
public class YardWorker extends Employee {

    private final int WAGEGRASS = 40;
    private int numGrassCut;

    /**
     * Gets the pay details for the yard worker.
     */
    public YardWorker() {
        try {
            System.out.println("How many times did they cut the grass?");
            this.numGrassCut = Integer.parseInt(userInput.nextLine());
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
        super.setPayAmount(this.numGrassCut * WAGEGRASS);
    }
}
