package theatre;

import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author Michael Fesser
 * @since 2/13/2014
 *
 * The purpose of this class is to hold an ArrayList of seats. It also sets the
 * row number and sets the specific details of each seat.
 */
public class Row {

    private int rowNumber;
    private ArrayList<Seat> seats = new ArrayList();                            // ArrayList to hold the seats.
    private final double CHEAPSEATS = 70.00;
    private final double GOODSEATS = 100.00;

    /**
     * This method accepts a seat value from the user.
     *
     * It first checks to see if the seat is taken, if it is the method alerts
     * the user and then quits.
     *
     * If the seat is not taken is sets the name, price, alerts the user to the
     * cost of the seat based on row, and final sets the seat to sold.
     *
     * @param seat
     */
    public void reserveSeat(int seat) {
        Scanner input = new Scanner(System.in);
        int arrayCounter = 0;                                                   // Used as a counter to iterate through the ArrayList.
        boolean seatSold = false;                                               // Set seat sold to false.
        seat++;                                                                 // Increase seat by one for comparisons and to set the seat number in the Seat class.

        while (arrayCounter < seats.size()) {                                   // Loop to the end of the ArrayList.
            if (seats.get(arrayCounter).getSeatNumber() == (seat)) {            // Check to see if the user imputed seat already exists at a position of the array.  
                seatSold = true;                                                // If seat exists set to true to skip creating of a new seat.
            }
            arrayCounter++;
        }

        if (!seatSold) {                                                        // The seat is not found.
            Seat currentSeat = new Seat();                                      // Initialize the currentSeat object.
            currentSeat.setSeatNumber(seat);                                    // Set the seat number.
            System.out.print("Please enter your name to reserve seat: ");
            currentSeat.setReservedBy(input.next());                            // Set name of the user that bought the seat.
            currentSeat.setSold(seatSold);                                      // Set seat to sold.
            seats.add(currentSeat);                                             // Populate the seats ArrayList.
            if (this.rowNumber <= 5) {
                currentSeat.setPrice(GOODSEATS);
            } else {
                currentSeat.setPrice(CHEAPSEATS);
            }
            System.out.println("The price of this seat is: $" + currentSeat.getPrice());  // Display the price of the seat.
        } else if (seatSold) {
            System.out.print("\nThat seat is reserved.  Please select another seat. \n"); // If seat is sold alert user.
        }
    }

    /**
     * This method returns the total value of the seat sold in a row.
     *
     * @return
     */
    public double getSeatTotal() {
        double seatsValueRow = 0;

        for (Seat seat : seats) {                                               // Iterate through all the elements of the ArrayList.
            seatsValueRow += seat.getPrice();                                   // Calculate the total for all the seats of this row.
        }
        return seatsValueRow;                                                   // Return total.
    }

    public int getRowNumber() {
        return rowNumber;
    }

    public void setRowNumber(int rowNumber) {
        this.rowNumber = rowNumber;
    }

    public ArrayList<Seat> getSeats() {
        return seats;
    }

}
