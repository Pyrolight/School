package base;

import exception.PayException;

/**
 *
 * @author mfesser
 * @since 4/23/2014
 *
 * This is the interface used to calculate the staffs pay.
 */
public interface Payable {

    public abstract void calculatePay() throws PayException;
}
