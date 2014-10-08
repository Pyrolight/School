/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exception;

/**
 *
 * @author mfesser
 * @since 4/23/2014
 *
 * This class is the exception class used when the pay for the staff is to high.
 */
public class PayException extends Exception {

    public PayException(String description) {
        super(description);
    }
}
