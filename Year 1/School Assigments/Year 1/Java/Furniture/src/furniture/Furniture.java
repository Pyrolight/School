/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package furniture;

import java.text.DecimalFormat;
import javax.swing.JOptionPane;

/**
 *
 * @author Michael
 * @since 10/26/2013
 *
 * The Purpose of this class is to allow users to make multiple selections on
 * tables and to see the results.
 */
public class Furniture {

    private int tableSelection;
    private double costForPineTable;
    private double costForOakTable;
    private double costForMahoganyTable;
    private int numberOfPineTables;
    private int numberOfOakTables;
    private int numberOfMahoganyTables;

    /**
     * @author Michael Fesser
     * @since 10/26/2013
     * @param args the command line arguments
     *
     * The main method will set all the variables and call the first method
     * getTables.
     */
    public static void main(String[] args) {

        Furniture furniture = new Furniture();                                  // Create an instance of the Furniture class.
        furniture.getTables();                                                  // Call the getTables method to start the recurive call. 
    }

    /**
     * This is the method that will start the recursive call and add values to
     * the variables for all the table types and sizes.
     */
    public void getTables() {
        tableSelection = Integer.parseInt(JOptionPane.showInputDialog("Please enter your choice(s) for a table:\n"
                + "1. Pine Table:               $100\n2. Oak Table:                $225\n3. Mahogany Table:    $310\n\nType any other number to quit."));

        if (tableSelection == 1) {                                              // Add the number of pine table and the cost of the pine table to their running totals. 
            costForPineTable = costForPineTable + 100;
            numberOfPineTables = numberOfPineTables + 1;
            getTables();

        } else if (tableSelection == 2) {                                       // Add the number of oak table and the cost of the oak table to their running totals.
            costForOakTable = costForOakTable + 225;
            numberOfOakTables = numberOfOakTables + 1;
            getTables();

        } else if (tableSelection == 3) {                                       // Add the number of mahogany table and the cost of the mahogany table to their running totals.   
            numberOfMahoganyTables = numberOfMahoganyTables + 1;
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
                + numberOfPineTables + " pine table(s).  The cost is:  $" + decimalFormat.format(costForPineTable) + "\n"
                + numberOfOakTables + " oak table(s).  The cost is:  $" + decimalFormat.format(costForOakTable) + "\n"
                + numberOfMahoganyTables + " mahogany table(s).  The cost is:  $" + decimalFormat.format(costForMahoganyTable) + "\n\n"
                + "The total cost of your order is $" + decimalFormat.format((costForPineTable + costForOakTable + costForMahoganyTable)));
    }
}
