package assignment4;

import java.util.Scanner;

/**
 * This class will provide functionality of a basic login system. The user can
 * load the passwords, login and show all login attempts.
 *
 * @author BJ, Michael Fesser
 * @since 2/14/2014
 */
public class Assignment4 {

    String[] userNameArray = {"John", "Steve", "Bonnie", "Kylie", "Logan", "Robert"};  // Default username array.
    String[] passwordArray = {"1111", "2222", "3333", "4444", "5555", "6666"};  // Default password array.
    Login login = new Login();                                                  // Initialize the object for the Login class.

    /**
     * @author BJ, Michael Fesser
     * @since 2/14/2014
     * 
     * The main method contains all the main menu and calls the various methods that
     * are used to access the Login class.
     * 
     * @param args
     */
    public static void main(String[] args) {
        Assignment4 usernamePassword = new Assignment4();                       // Initialize the object for the Assignment4 class to access the instance Array and methods.
        Scanner input = new Scanner(System.in);
        String option;                                                          // Holds menu option results.
        Boolean done = false;                                                   // Loop control variable.

        String mainMenu = "\nPlease type in an option below."
                + "\n\nD)  Load all stored passwords."
                + "\nL)  Log into the system."
                + "\nS)  Show all login attempts."
                + "\nX)  Exit the program";

        do {                                                                    // Loop until user choses to exit the program.
            System.out.println(mainMenu);
            option = input.nextLine().toUpperCase();

            switch (option) {
                case "D":
                    usernamePassword.load();                                    // Calls the method that loads the arrays into the Login class.
                    break;
                case "L":
                    usernamePassword.log();                                     // Calls the method that allows the user to log in.
                    break;
                case "S":
                    usernamePassword.showAttempts();                            //  Calls the method that shows the login attempts.
                    break;
                case "X":                                                       //  Exits the program.
                    done = true;
                    break;
                default:
                    System.out.println("That was not a valid option.");
                    break;
            }
        } while (!done);
    }

    /**
     * This method populates the HashMap in the Login class.
     */
    public void load() {
            login.loadCredentials(userNameArray, passwordArray);                // Call the method loadCredentials and pass the userNameArray and passwordArray to it.
    }

    /**
     * This method calls the login method in the Login class.
     */
    public void log() {
        login.login();
    }

    /**
     * This method call the loginAttempts in the Login class.
     */
    public void showAttempts() {
        login.loginAttempts();
    }
}
