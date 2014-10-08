/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package hamblueberrypatch;

import javax.swing.JOptionPane;

/**
 *
 * @author Michael fesser
 * @since 12/16/2013
 *
 * The purpose of this project is to allow Ham's Blueberry Patch to track
 * multiple variables of their blueberry production. These are the number of
 * pickers, the number of boxes picked, who picked the most boxes, and the
 * average boxes picked.
 */
public class HamBlueberryPatch {

    /**
     * @author Michael fesser
     * @since 12/16/2013
     *
     * The purpose of the main method is to get the pickers name and boxes
     * picked and to pass that information onto the BlueBerryInfo class that
     * does all the calculations.
     *
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        String pickerName;
        int boxes;

        BlueBerryInfo pickerTotal = new BlueBerryInfo();                        // Create the object that will hold the information.
        do {                                                                    // Main program loop.
            pickerName = JOptionPane.showInputDialog("What is the pickers name?\n Enter x to quit.");
            if (!pickerName.equalsIgnoreCase("x")) {                            // Used to skip the process of asking for boxes if the user wants to quit.
                do {                                                            // Loop to validate the number of boxes.
                    boxes = Integer.parseInt(JOptionPane.showInputDialog("How many boxes did they pick?"
                            + "\nThe number must be at least 1 and no more then 50."));
                    if (boxes < 1 || boxes > 50) {                              // Give error message if validation fails.
                        JOptionPane.showMessageDialog(null, "That number was out of range, try again.");
                    }
                } while (boxes < 1 || boxes > 50);                              // The validation check.
                pickerTotal.processNewPicker(pickerName, boxes);
            }
        } while (!pickerName.equalsIgnoreCase("x"));                            // Used to check if user  wasntes to exit program.
        pickerTotal.displayPickerReport();                                      // Displays the output report.
    }
}
