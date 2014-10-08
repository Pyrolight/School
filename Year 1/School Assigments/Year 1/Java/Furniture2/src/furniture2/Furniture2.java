/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package furniture2;

import java.text.DecimalFormat;
import javax.swing.JOptionPane;

/**
 *
 * @author Michael
 * @since 10/27/2013
 *
 * The Purpose of this class is to allow users to make multiple selections on
 * tables and to see the results.
 */
public class Furniture2 {

    private int tableSelection;
    private double costForPineTable;
    private double costForOakTable;
    private double costForMahoganyTable;
    private int tableSize;
    private int largePineTableCost;
    private int smallPineTableCost;
    private int largeOakTableCost;
    private int smallOakTableCost;
    private int largeMahagoanyTableCost;
    private int smallMahagoanyTableCost;

    /**
     * @author Michael Fesser
     * @since 10/27/2013
     * @param args the command line arguments
     *
     * The main method will set all the variables and call the first method
     * getTables.
     */
    public static void main(String[] args) {

        Furniture2 furniture = new Furniture2();                                // Create an instance of the Furniture class.
        furniture.getTables();                                                  // Call the getTables method to start the recurive call. 
    }

    /**
     * This is the method that will start the recursive call and add values to
     * the variables for all the table types and sizes.
     */
    public void getTables() {
        tableSelection = Integer.parseInt(JOptionPane.showInputDialog("Please enter your choice(s) for a table:\n"
                + "1. Pine Table:               $100\n2. Oak Table:                $225\n3. Mahogany Table:    $310\n\nType any other number to quit."));

        if (tableSelection == 1) {                                              // Add the cost of the pine table to its running total.
            tableSize = Integer.parseInt(JOptionPane.showInputDialog("What size of table would you like?\n"
                    + "Hit 1 for a large table.\nHit 2 for a small table."));

            if (tableSize == 1) {                                               // Add $35 dollars to the price of the oak table and increase the number of large pine tables by one.
                largePineTableCost = largePineTableCost + 1;
                costForPineTable = costForPineTable + 35;
            } else if (tableSize == 2) {                                        // Increase the number of small pine tables by one.
                smallPineTableCost = smallPineTableCost + 1;
            } else {                                                            // Show selection error and increase the number of small pine tables by one.
                JOptionPane.showMessageDialog(null, "That was an invalid selection.  We assume you wanted a small table.");
                smallPineTableCost = smallPineTableCost + 1;
            }
            costForPineTable = costForPineTable + 100;
            getTables();

        } else if (tableSelection == 2) {                                       // Add the cost of the oak table to its running total.
            tableSize = Integer.parseInt(JOptionPane.showInputDialog("What size of table would you like?\n"
                    + "Hit 1 for a large table.\nHit 2 for a small table."));

            if (tableSize == 1) {                                               // Add $35 dollars to the price of the oak table and increase the number of large oak tables by one.
                largeOakTableCost = largeOakTableCost + 1;
                costForOakTable = costForOakTable + 35;
            } else if (tableSize == 2) {                                        // Increase the number of small oak tables by one.
                smallOakTableCost = smallOakTableCost + 1;
            } else {                                                            // Show selection error and increase the number of small oak tables by one.
                JOptionPane.showMessageDialog(null, "That was an invalid selection.  We assume you wanted a small table.");
                smallOakTableCost = smallOakTableCost + 1;
            }
            costForOakTable = costForOakTable + 225;
            getTables();

        } else if (tableSelection == 3) {                                       // Add the cost of the mahogany table to its running total.
            tableSize = Integer.parseInt(JOptionPane.showInputDialog("What size of table would you like?\n"
                    + "Hit 1 for a large table.\nHit 2 for a small table."));

            if (tableSize == 1) {                                               // Add $35 dollars to the price of the mahogany table and increase the number of large mahogany tables by one.
                largeMahagoanyTableCost = largeMahagoanyTableCost + 1;
                costForMahoganyTable = costForMahoganyTable + 35;
            } else if (tableSize == 2) {                                        // Increase the number of small mahogany tables by one.
                smallMahagoanyTableCost = smallMahagoanyTableCost + 1;
            } else {                                                            // Show selection error and increase the number of small mahogany tables by one.
                JOptionPane.showMessageDialog(null, "That was an invalid selection.  We assume you wanted a small table.");
                smallMahagoanyTableCost = smallMahagoanyTableCost + 1;
            }
            costForMahoganyTable = costForMahoganyTable + 310;
            getTables();

        } else {                                                                // Call method displayTablesAndCosts to output the results.                                                    
            displayTablesAndCosts();
        }
    }

    /**
     * This method displays the results.
     */
    public void displayTablesAndCosts() {
        DecimalFormat decimalFormat = new DecimalFormat("0.00");
        JOptionPane.showMessageDialog(null, "Your Order:\n\n"
                + largePineTableCost + " large and " + smallPineTableCost + " small pine table(s).  "
                + "The cost is: $" + decimalFormat.format(costForPineTable) + "\n"
                + largeOakTableCost + " large and " + smallOakTableCost + " small oak table(s).  "
                + "The cost is: $" + decimalFormat.format(costForOakTable) + "\n"
                + largeMahagoanyTableCost + " large and " + smallMahagoanyTableCost + " small mahogany table(s).  "
                + "The cost is: $" + decimalFormat.format(costForMahoganyTable) + "\n\n"
                + "The total cost of your order is $" + decimalFormat.format(costForPineTable + costForOakTable + costForMahoganyTable));
    }
}
