package taxreturn;

import javax.swing.JOptionPane;

/**
 *
 * @author Michael Fesser
 * @since 12/08/2013
 * 
 * The purpose of this project is to create a basic tax return form and to add some variable
 * validation.
 */
public class PrepareTax {

    /**
     * @author Michael Fesser
     * @since 12/08/2013
     * 
     * The main method will accept user variables, validate socialSecurity, zipCode,
     * income and meritalStatus.  Finally it will pass them to the TaxReturn class.
     * 
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        String socialSecurity;
        String firstName;
        String lastName;       
        String address;
        String city;
        String state;
        String zipCode;
        double income;
        String maritalStatus;

        do {
            socialSecurity = JOptionPane.showInputDialog("What is the clients social security number?  The format is xxx-xx-xxxx");
            if (socialSecurity.matches("\\d{3}-\\d{2}-\\d{4}") == false) {      // Force user in input the format of xxx-xx-xxxx.
                JOptionPane.showMessageDialog(null, "Sorry that was the incorrect format, try again.");
            }
        } while (socialSecurity.matches("\\d{3}-\\d{2}-\\d{4}") == false);      // Loop until input matches format of xxx-xx-xxxx . 
        firstName = JOptionPane.showInputDialog("What is the clients first name?");
        lastName = JOptionPane.showInputDialog("What is the clients last name?");
        address = JOptionPane.showInputDialog("What is the clients address?");
        city = JOptionPane.showInputDialog("What city does the client live in?");
        state = JOptionPane.showInputDialog("What state does the client live in?");
        do {
            zipCode = JOptionPane.showInputDialog("What is the clients ZIP code?  The format is xxxxx");  // Force user to input the format of xxxxx.
            if (zipCode.matches("\\d{5}") == false) {
                JOptionPane.showMessageDialog(null, "Sorry that was the incorrect format, try again.");
            }
        } while (zipCode.matches("\\d{5}") == false);                           // Loop until input matches format of xxxxx.
        do {
            maritalStatus = JOptionPane.showInputDialog("What is the clients marital status?  Enter S or s for single and M or m for married").toUpperCase().substring(0, 1);
            if (!"S".equals(maritalStatus) && !"M".equals(maritalStatus)) {     // Force user to input M, m, S or s.   
                JOptionPane.showMessageDialog(null, "Sorry that was the incorrect format, try again.");
            }
        } while (!"S".equals(maritalStatus) && !"M".equals(maritalStatus));     // Loop until input is M, m, S or s.
        do {
            income = Integer.parseInt(JOptionPane.showInputDialog("What is the clients mannual income?  This has to be a positive number"));
            if (income < 0) {                                                   // Force user to input positive number.
                JOptionPane.showMessageDialog(null, "That was a negative number, try again.");
            }
        } while (income < 0);                                                   // Loop until input is positive number.
        TaxReturn tax = new TaxReturn(socialSecurity, firstName, lastName, address, city, state, zipCode, income, maritalStatus.charAt(0));  // Send variables to constructor.
        JOptionPane.showMessageDialog(null, tax.toString());                    // Display output.
    }
}
