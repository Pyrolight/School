
import java.util.Scanner;
/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author bjmaclean
 */
public class Room {

    Scanner input = new Scanner(System.in);
    private int roomNumber;
    private int numberOfSeats;
    private String reservedBy = "";
    private boolean reserved;
    private boolean hasSmartBoard;

    /**
     * Get the attribute values from the user.
     */
    public Room(int roomNumber) {
        this.roomNumber = roomNumber;

    }

    public void getRoomDetailsFromUser() {
        //* April 15, 2014 MF Assignment 8 Modification.  Added the try-catch block to catch non numeric input. *//
        try {
            System.out.print("Enter number of seats: ");
            //* April 15, 2014 MF Assignment 8 Modification.  I hate the burning the line, I would rather convert it. *//
            numberOfSeats = Integer.parseInt(input.nextLine());
        } catch (NumberFormatException nfe) {
            System.out.println("The input needs to be numeric.");
        }
        System.out.print("Does this classroom have a smart board? (Y/N)");
        hasSmartBoard = input.nextLine().equalsIgnoreCase("y");

    }

    public boolean isHasSmartBoard() {
        return hasSmartBoard;
    }

    public void setHasSmartBoard(boolean hasSmartBoard) {
        this.hasSmartBoard = hasSmartBoard;
    }

    public int getNumberOfSeats() {
        return numberOfSeats;
    }

    public void setNumberOfSeats(int numberOfSeats) {
        this.numberOfSeats = numberOfSeats;
    }

    public String getReservedBy() {
        return reservedBy;
    }

    public void setReservedBy(String reservedBy) {
        this.reservedBy = reservedBy;
    }

    public boolean isReserved() {
        return reserved;
    }

    public void setReserved(boolean reserved) {
        this.reserved = reserved;
    }

    public int getRoomNumber() {
        return roomNumber;
    }

    /**
     * Update the room to reserved and get the reserved by.
     */
    public void reserveThisRoom() {
        this.reserved = true;
        System.out.println("Enter the name of the person reserving this room: ");
        reservedBy = input.nextLine();
    }

    /**
     * Update the room to not reserved and clear the reserved by.
     */
    public void releaseThisRoom() {
        this.reserved = false;
        reservedBy = "";
        System.out.println("Room has been released\n");

    }

    public String toString() {
        String output = "\n\n******************************"
                + "\nRoom Number: " + roomNumber
                + "\nNumber of Seats: " + numberOfSeats
                + "\nReserved By: " + reservedBy
                + "\nReserved: " + reserved
                + "\nSmart Board: " + hasSmartBoard;
        return output;
    }
}
