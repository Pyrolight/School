package practicalmain;

import java.util.Scanner;

/**
 * This is the main method for the program. It will invoke the theatre
 * functionality as required.
 *
 * @author BJ
 * @since 2014-01-26
 */
public class PracticalMain {

    public static void main(String[] args) {

        Theatre user = new Theatre();
        //boolean to indicate when the user is finished.
        boolean finished = false;
        //Scanner for input from the user.
        Scanner input = new Scanner(System.in);
        //Prompt to be used for the menu.
        String prompt = "\nEnter menu choice:"
                + "\nR) Reserve a seat"
                + "\nS) Show seat reservations"
                + "\nT) Total revenue from sold seats"
                + "\nX) Exit";
        //String to hold user's choice
        String userChoice;
        //while the user is not finished, continue to prompt them with the menu.
        do {
            System.out.println(prompt);
            userChoice = input.nextLine().toUpperCase();

            switch (userChoice) {
                case "X":
                    finished = true;
                    break;
                case "R":
                    user.reserveSeat();
                    //Add code to invoke reservation
                    break;
                case "S":
                    user.showReservations();
                    //Add code to invoke the show reservations functionality
                    break;
                case "T":
                    user.totalSales();
                    //Add code to invoke the total $ sold
                    break;
                default:
                    System.out.println("Invalid choice!");
            }

        } while (!finished);
    }
}
