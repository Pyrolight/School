/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package partb;

import javax.swing.JOptionPane;

/**
 *
 * @author Michael Fesser
 * @since 11/20/2013
 *
 * The purpose of this class is to make a basic calculator. It will take two
 * numbers from the user and let them choose what operator to use on them, ie
 * add, subtract, multiply and divide.
 *
 * The program will loop until the operators are chosen and will break if the
 * second number. divides by zero.
 * 
 */
public class PartB {

    /**
     * @author Michael Fesser
     * @since 11/20/2013
     *
     * The purpose of this method is to implement and test the code. Changing
     * ints to doubles to get a more useful output and trying so error
     * validation without using any methods. Tried to get as little code
     * replication as possible with desired functionality.
     *
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        double first = 0;                                                       // set to double to make the math work better.
        double second = 0;                                                      // set to dounle to make the math work better.  Also it default to 0 to set second error flag.
        int operator = 4;                                                       // default to 4 to set first error flag.
        double total = 0;                                                       // set to double to make output for divide make sense.

        do {                                                                    // loop to force 1-4 for correct operators.  

            /*
            * This first if checks to see if dividing by zero.  I set it to true
            * to allow the first choice of the two numbers.  I was testing out
            * a little more validation on the program.
            */
            if (operator == 4 && second == 0) {                                 

                first = Double.parseDouble(JOptionPane.showInputDialog("What is your first number?"));  //get first number.
                second = Double.parseDouble(JOptionPane.showInputDialog("What is your second number?"));  //get second number.
            }
            operator = Integer.parseInt(JOptionPane.showInputDialog("What would you like to do to the number? \n1 for add. \n2 for subtract"
                    + "\n3 for multuply\n4 for divide."));
            if (operator < 1 || operator > 4) {                                 // error statement if operator choice is out of range.    
                JOptionPane.showMessageDialog(null, "Sorry you must choose 1 through 4 to pick the opterator");
            }
            if (operator == 4 && second == 0) {                                 // check to see if dividing by zero
                JOptionPane.showMessageDialog(null, "Sorry you cannot divide by zero");  // display error message for divide by zero.
            }

        } while (operator < 1 || operator > 4 || operator == 4 && second == 0); // the validation criteria.

        switch (operator) {                                                     // switch to do the actual operations.  ie Add, substract, multiply and divide.

            case 1:
                total = first + second;
                break;
            case 2:
                total = first - second;
                break;
            case 3:
                total = first * second;
                break;
            case 4:
                total = first / second;
                break;
        }
        JOptionPane.showMessageDialog(null, total);                             // output total
    }
}
