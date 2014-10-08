// 5/30/2014 MF Assignment 3 Modification.  Moved to interfaces package.
package interfaces;

/**
 * This interface will be used to ensure that all instrument classes have an applySurchargetoPrice method
 * and that the labels provided are used for the output of the program.  
 * 
 * @author bjmaclean
 * @since 20131029
 */
public interface Sellable {
    
    public static final String INVENTORY_REPORT = "Inventory Report";
    public static final String TOTALS = "Totals";
    public static final int TYPE_GUITAR = 1;
    public static final int TYPE_DRUM = 2;
    public static final int TYPE_KEYBOARD = 3;

    
    
    public double applySurchargeToPrice();
    
}

