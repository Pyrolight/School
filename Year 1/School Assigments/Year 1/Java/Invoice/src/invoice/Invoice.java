/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package invoice;

import javax.swing.JOptionPane;

/**
 *
 * @author Michael Fesser
 * @since 10/11/2013
 *
 * The purpose of this class is to get the variables from the method
 * InvoiceInfo, do a calculation for total price and display the Invoice.
 */
public class Invoice {

    /*
     * Declare varaibles and make private.
     */
    private int itemNumber;
    private String name;
    private int quantity;
    private double price;
    private double totalCost;

    /*
     * Setters for passed arguments.
     */
    public void setItemNumber(int itemNumber) {
        this.itemNumber = itemNumber;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setQuantity(int quantity) {
        this.quantity = quantity;
        this.totalCost = price * quantity;                                      //calcuation for total cost.

    }

    public void setPrice(double price) {
        this.price = price;
        this.totalCost = price * quantity;                                      //calcuation for total cost.
    }

    /**
     * This method takes all the arguments from the Invoice class and displays
     * them to the user.
     */
    public void displayLine() {

        String InvoiceInfo = "The item number is " + this.itemNumber + "\n The name is "
                + this.name + "\n The quantity of them is " + this.quantity
                + "\n The cost of each is $" + this.price
                + "\n The total cost is $" + this.totalCost + "\n\n";

        JOptionPane.showMessageDialog(null, InvoiceInfo);
    }
}
