/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package checkup;

/**
 *
 * @author Michael Fesser
 * @since 10/23/2013
 *
 * The purpose of this class is to get the variables from the method getData(),
 * call a method to do the calculation for cholesterol ratio and call a method
 * to explain the ratio itself.
 */
public class Checkup {

    /*
     * All variables set as int to remeove decimal places.
     */
    private int patientNumber;
    private int bloodPressureSystolic;
    private int bloodPressureDiastolic;
    private int cholesterolLDL;
    private int cholesterolHDL;

    public int getPatientNumber() {
        return patientNumber;
    }

    public void setPatientNumber(int patientNumber) {
        this.patientNumber = patientNumber;
    }

    public int getBloodPressureSystolic() {
        return bloodPressureSystolic;
    }

    public void setBloodPressureSystolic(int bloodPressureSystolic) {
        this.bloodPressureSystolic = bloodPressureSystolic;
    }

    public int getBloodPressureDiastolic() {
        return bloodPressureDiastolic;
    }

    public void setBloodPressureDiastolic(int bloodPressureDiastolic) {
        this.bloodPressureDiastolic = bloodPressureDiastolic;
    }

    public int getCholesterolLDL() {
        return cholesterolLDL;
    }

    public void setCholesterolLDL(int cholesterolLDL) {
        this.cholesterolLDL = cholesterolLDL;
    }

    public int getCholesterolHDL() {
        return cholesterolHDL;
    }

    public void setCholesterolHDL(int cholesterolHDL) {
        this.cholesterolHDL = cholesterolHDL;
    }

    /**
     * This method calculates the ratio of LDL cholesterol vs DHL cholesterol.
     *
     * @return cholersterolRation
     */
    public double computeRatio() {
        double cholesterolRatio = (double) this.cholesterolLDL / (double) this.cholesterolHDL;  //(double) needed to allow the required decimal result with two ints passed in.
        return cholesterolRatio;
    }

    /**
     * A string to explain the cholesterol ratio.
     *
     * @return explainRatio
     */
    public String explainRatio() {
        String explainRatio = "HDL is the good type of cholesterol."
                + " It should have a ratio of 3.5 or lower.";
        return explainRatio;
    }
}
