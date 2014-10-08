package builder;

import javax.swing.JOptionPane;

/**
 *
 * @author Michael Fesser
 * @since 12/08/2013
 *
 * The purpose of this project is to test StringBuilder
 *
 */
public class Builder {

    /**
     * @author Michael Fesser
     * @since 12/08/2013
     *
     * The main method will take the input from the user as a StringBuilder
     * object pass it to the construction for the Name class and output the
     * results.
     *
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        char enterFirstName;
        char enterMiddleName;
        char enterLastName;
        char changeName = 'n';                                                  // initilize value to skip name change inside loop the first time.
        StringBuilder firstName;
        StringBuilder middleName;
        StringBuilder lastName;

        firstName = new StringBuilder(JOptionPane.showInputDialog("What is your first name?"));  // only used once so outside the loop.
        middleName = new StringBuilder(JOptionPane.showInputDialog("What is your middle name?"));
        lastName = new StringBuilder(JOptionPane.showInputDialog("What is your last name?"));
        
        do {                                                                    
            if (changeName == 'y') {                                            // Check to see if user wants to change the name.
                enterFirstName = JOptionPane.showInputDialog("Enter a new first name? \nHit Y or y for yes "
                        + "or any other character to skip this step.").toLowerCase().charAt(0);  // Ask if user wants to enter a new first name.
                if (enterFirstName == 'y') {
                    firstName = new StringBuilder(JOptionPane.showInputDialog("What is the new first name?"));
                }

                enterMiddleName = JOptionPane.showInputDialog("Enter a new middle name? \nHit Y or y for yes "
                        + "or any other character to skip this step.").toLowerCase().charAt(0);  // Ask if user wants to enter a new middle name.
                if (enterMiddleName == 'y') {
                    middleName = new StringBuilder(JOptionPane.showInputDialog("What is the new middle name?"));
                }

                enterLastName = JOptionPane.showInputDialog("Enter a new last name?\nHit Y or y for yes "
                        + "or any other character to skip this step.").toLowerCase().charAt(0);  // Ask if user wants to enter a new last name.
                if (enterLastName == 'y') {
                    lastName = new StringBuilder(JOptionPane.showInputDialog("What is the new last name?"));
                }
            }

            Name names = new Name(firstName, middleName, lastName);             // Pass objects to the constructor.

            JOptionPane.showMessageDialog(
                    null, "Your whole name is: " + names.getEntireName()
                    + "\nYour name, last to first is: " + names.getLastFirst()
                    + "\nYour signature is: " + names.getSignature());          //  Output the entireName, lastFirst and signature ojects in the Name class.

            changeName = JOptionPane.showInputDialog("Run this again and change the first/middle/last name?  \n"
                    + "Hit Y or y for yes any other letter to quit.").toLowerCase().charAt(0);  // Ask user if they wish to run the program again.
        } while (changeName == 'y');                                            // Loop until the user wants to quit.
    }
}
