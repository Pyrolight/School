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
 * The class will provide functionality associated with Invoices.
 */
public class TestInvoice {

    /**
     * @author Michael Fesser
     * @since 10/11/2013
     * @param args the command line arguments
     *
     * The main method will declare invoice items. It will also call a method
     * that will populate the Invoice class and display the resulting
     * information.
     */
    public static void main(String[] args) {

        /*
         * Declare the Invoice items.
         */
        Invoice Invoice1;
        Invoice Invoice2;
        Invoice Invoice3;

        /*
         * Call the InvoiceInfo method that populates the Invoice class 
         * and return the results.
         */
        Invoice1 = InvoiceInfo();
        Invoice1.displayLine();

        /*
         * Call the InvoiceInfo method that populates the Invoice class 
         * and return the results.
         */
        Invoice2 = InvoiceInfo();
        Invoice2.displayLine();

        /*
         * Call the InvoiceInfo method that populates the Invoice class 
         * and return the results.
         */
        Invoice3 = InvoiceInfo();
        Invoice3.displayLine();
    }

    /**
     * @return Invoices
     *
     * This method both constructs the Invoice objects and passes the arguments
     * to the Invoice class.
     */
    public static Invoice InvoiceInfo() {
        Invoice Invoices = new Invoice();                                       // Constructing the Invoice class.
        /*
         * Getting the arguemnts from user and passing them to the Invoice class.
         */
        Invoices.setItemNumber(Integer.parseInt(JOptionPane.showInputDialog("What is the item number?")));
        Invoices.setName(JOptionPane.showInputDialog("What is the name of the item?"));
        Invoices.setQuantity(Integer.parseInt(JOptionPane.showInputDialog("How many do you have?")));
        Invoices.setPrice(Double.parseDouble(JOptionPane.showInputDialog("What is the price of each item?")));
        return Invoices;
    }
}
