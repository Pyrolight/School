import java.util.Scanner;

/**
 *
 * @author bjmaclean
 * 
 * This is the main Room class.  
 */
public class Room {

    Scanner input = new Scanner(System.in);
    private int roomNumber;
    private int numberOfSeats;
    private String reservedBy = "";
    private boolean reserved;
    private boolean hasSmartBoard;

    public Room(int roomNumber) {
        this.roomNumber = roomNumber;
    }

    /**
     * Get the attribute values from the user.
     */
    public void getRoomDetailsFromUser() {

        System.out.print("Enter number of seats: ");
        numberOfSeats = input.nextInt();
        input.nextLine();
        System.out.print("Does this classroom have a smart board? (Y/N)");
        hasSmartBoard = input.nextLine().equalsIgnoreCase("y");
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

    public boolean isHasSmartBoard() {
        return hasSmartBoard;
    }

    public int getNumberOfSeats() {
        return numberOfSeats;
    }

    public String getReservedBy() {
        return reservedBy;
    }

    public boolean isReserved() {
        return reserved;
    }

    public int getRoomNumber() {
        return roomNumber;
    }

    @Override
    public String toString() {
        String output = "\n\n******************************"
                + "\nRoom Number: " + roomNumber
                + "\nNumber of Seats: " + numberOfSeats
                + "\nReserved By: " + reservedBy
                + "\nReserved: " + reserved
                + "\nSmart Board: " + hasSmartBoard + "\n";
        return output;
    }
}
