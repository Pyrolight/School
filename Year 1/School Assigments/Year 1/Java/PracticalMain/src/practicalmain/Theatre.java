package practicalmain;

import java.util.Scanner;

/**
 * This class will hold attributes/functionality for a theatre.
 *
 * @author BJ
 * @since 2014-01-27
 */
public class Theatre {

    //Number of rows in the theatre
    public static final int NUMBER_OF_ROWS = 10;
    //Number of seats that are in each row
    public static final int NUMBER_OF_SEATS_IN_ROW = 15;
    private static final Seat[][] SEAT = new Seat[NUMBER_OF_ROWS][NUMBER_OF_SEATS_IN_ROW];  // Array to hold the seats object.
    private final int CHEAP_SEATS = 70;  // Price for rows 6-10.
    private final int GOOD_SEATS = 100;  // price for rows 1-5.
    Scanner input = new Scanner(System.in);
    private double total = 0;  // Hold total.

    public Theatre() {
        for (int i = 0; i < NUMBER_OF_ROWS; i++) {
            for (int y = 0; y < NUMBER_OF_SEATS_IN_ROW; y++) {
                SEAT[i][y] = new Seat();    // Create a seat object in each elements of the array.
            }
        }
    }

    /**
     * This method takes the users input on the row and seat number and first
     * checks to see if it is avaliable. If it is then it sets the seat,
     * displays the price and asks for the name of the guest.
     */
    public void reserveSeat() {
        int row = 0;
        int seat = 0;
        String name = "";
        do {  // Loop to get a valid row number.
            System.out.println("Which row would you like?");
            row = input.nextInt();
        } while (row <= 1 && row >= NUMBER_OF_ROWS);
        do {  // Loop to get a vaild seat number.
            System.out.println("Which seat in the row would you like?");
            seat = input.nextInt();
        } while (seat <= 1 && seat >= NUMBER_OF_SEATS_IN_ROW);
        if (SEAT[row][seat].isSold()) {  // Check to see if the seat is sold, alert user if it is.
            System.out.println("Sorry that seat is sold");
        } else {  // If not sold set sold to true and display the seat cost.
            SEAT[row][seat].setSold(true);
            if (row <= 5) {
                System.out.println("The price of the seat is: " + GOOD_SEATS);
                total += GOOD_SEATS;
            } else {
                System.out.println("The price of the seat is: " + CHEAP_SEATS);
                total += GOOD_SEATS;

            }
            System.out.println("what name would you like that to be under?");  // Get the name of the guest.
            name = input.next();
            SEAT[row][seat].setReservedBy(name);  // Set the seat to that persons name.

        }
    }

    /**
     * This method shows the reservations that have already been taken. It
     * displays an x for a taken seat and an o for an open one.
     */
    public void showReservations() {
        int row = 0;
        int seat = 0;
        for (int i = 0; i < NUMBER_OF_ROWS; i++) {
            for (int y = 0; y < NUMBER_OF_SEATS_IN_ROW; y++) {
                if (SEAT[row][seat].isSold()) {
                    System.out.print("x ");
                } else {
                    System.out.print("o ");
                }
            }
            System.out.print("\n");  // Format the rows.

        }
    }

    /**
     * This is used to return the total sales for all the seats.
     */
    public void totalSales() {
        String finalTotal = "The total sales are $" + total;  // dispay the final total.
        System.out.print(finalTotal);
    }
}
