/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package checkup;

import javax.swing.JOptionPane;

/**
 *
 * @author mfesser
 * @since 10/23/2013
 */
public class TestCheckup {

    /**
     * @author Michael Fesser
     * @since 10/23/2013
     * @param args the command line arguments
     *
     * The main method will declare checkup objects, call methods to pass data
     * to the Checkup class and call a method to retrieve and display the data.
     */
    public static void main(String[] args) {

        /*
         * Declare the objects.
         */
        Checkup checkup1;
        Checkup checkup2;

        /*
         * Set the data.
         */
        checkup1 = getData();
        checkup2 = getData();

        /*
         * Retrieve the data.
         */
        showValues(checkup1);
        showValues(checkup2);
    }

    /**
     * This method will instance the object and set its variables and return the
     * result to the main method.
     *
     * @return checkup
     */
    public static Checkup getData() {
        Checkup checkup = new Checkup();                                        //instace the object as it was only declared before.
        checkup.setPatientNumber(Integer.parseInt(JOptionPane.showInputDialog("What is the patient number?")));
        checkup.setBloodPressureSystolic(Integer.parseInt(JOptionPane.showInputDialog("What is their Systolic blood pressure?")));
        checkup.setBloodPressureDiastolic(Integer.parseInt(JOptionPane.showInputDialog("What is their Diastolic blood pressure?")));
        checkup.setCholesterolLDL(Integer.parseInt(JOptionPane.showInputDialog("What is their LDL cholesterol?")));
        checkup.setCholesterolHDL(Integer.parseInt(JOptionPane.showInputDialog("What is their HDL cholesterol?")));
        return checkup;
    }

    /**
     * This method will retrieve the data for each object and display the data.
     *
     * @param checkup
     */
    public static void showValues(Checkup checkup) {
        JOptionPane.showMessageDialog(null, "Patient number " + checkup.getPatientNumber() + "\n"
                + "The patient's blood pressure is " + checkup.getBloodPressureSystolic() + "/"
                + checkup.getBloodPressureDiastolic() + "\n"
                + "The patient's cholesterol level is " + checkup.getCholesterolLDL() + " and "
                + checkup.getCholesterolHDL() + "\n"
                + "The patient's cholesterol ratio is " + checkup.computeRatio() + "\n\n"
                + checkup.explainRatio());
    }
}
