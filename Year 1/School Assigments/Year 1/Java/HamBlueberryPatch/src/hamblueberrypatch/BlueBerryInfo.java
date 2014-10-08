/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package hamblueberrypatch;

import java.text.DecimalFormat;
import javax.swing.JOptionPane;

/**
 *
 * @author mfesser
 * @since 12/16/2013
 *
 * The purpose of this class is to take the information provided from the
 * HamBlueberryPatch class and do all the required calculations. These include
 * calculating the number of pickers, the number of boxes picked, who picked the
 * most boxes, and the average boxes picked.
 *
 * This class also builds the output for the main method.
 */
public class BlueBerryInfo {

    private final String COMPANY_NAME = "Ham's Blueberry Patch";
    private int boxes;
    private int totalPickers;
    private int totalBoxes;
    private String pickerMostBoxes;
    private float avgBoxesDay;

    /**
     * This method does all the calculations and sets the number of boxes needed
     * for one calculation.
     */
    public void processNewPicker(String pickerName, int boxes) {
        totalPickers += 1;
        totalBoxes += boxes;

        if (boxes > this.boxes) {                                               // Set the picker who had the most boxes.
            pickerMostBoxes = pickerName;
        }
        avgBoxesDay = (float) this.totalBoxes / this.totalPickers;               // Cast to float to do calculation.
        this.boxes = boxes;
    }

    /**
     * This is the output method. It takes the results from the calculations
     * done in the processNewPicker method, the company name constant and then
     * formats it is a way useful to the user.
     */
    public void displayPickerReport() {
        DecimalFormat twoPlaces = new DecimalFormat("0.00");                    // Float formatting.
        String output = COMPANY_NAME
                + "\nDaily Summary\n\n"
                + "Number of pickers: " + totalPickers
                + "\nTotal Boxes: " + totalBoxes
                + "\nMost productive picker: " + pickerMostBoxes
                + "\nAverage boxes picked: " + twoPlaces.format(avgBoxesDay);
        JOptionPane.showMessageDialog(null, output);
    }
}
