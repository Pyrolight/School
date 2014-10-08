//* 4/8/2014 MF Assignment 7 modification.  Changed import to include all of java.util *

import java.util.*;
/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author bjmaclean
 */
//* 4/7/2014 MF Assignment 7 modification.  Modified the class to extend RoomBase and implement Bookable *
public class Room extends RoomBase implements Bookable {

    Scanner input = new Scanner(System.in);
    private String reservedBy = "";
    private boolean reserved;
    private boolean hasSmartBoard;

    /**
     * Get the attribute values from the user.
     */
    public Room(int roomNumber) {
        super.setRoomNumber(roomNumber);
    }

    //* 4/9/2014 MF Assignment 7 modification.  Added Override annotation *
    @Override
    public void getRoomDetailsFromUser() {
        System.out.print("Enter number of seats: ");
        super.setNumberOfSeats(input.nextInt());
        input.nextLine();
        System.out.print("Does this classroom have a smart board? (Y/N)");
        hasSmartBoard = input.nextLine().equalsIgnoreCase("y");

    }

    public boolean isHasSmartBoard() {
        return hasSmartBoard;
    }

    public void setHasSmartBoard(boolean hasSmartBoard) {
        this.hasSmartBoard = hasSmartBoard;
    }

    //* 4/9/2014 MF Assignment 7 modification.  Removed setter/getter *
    

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

    //* 4/9/2014 MF Assignment 7 modification.  Removed getter*
    

    /**
     * Update the room to reserved and get the reserved by.
     */
    //* 4/9/2014 MF Assignment 7 modification.  Added Override annotation *
    @Override
    public void reserveThisRoom() {
        this.reserved = true;
        System.out.println("Enter the name of the person reserving this room: ");
        reservedBy = input.nextLine();
    }

    /**
     * Update the room to not reserved and clear the reserved by.
     */
    //* 4/9/2014 MF Assignment 7 modification.  Added Override annotation *
    @Override
    public void releaseThisRoom() {
        this.reserved = false;
        reservedBy = "";
        System.out.println("Room has been released\n");
    }

    /**
     * 4/7/2014 MF Assignment 7 modification. This is the first of the
     * Comparators. It takes the values from the Room Arraylist and compares the
     * values of the each objects number of seats and orders them ascending.
     * http://beginnersbook.com/2013/12/java-arraylist-of-object-sort-example-comparable-and-comparator/
     */
    public static Comparator<Room> numberOfSeatsComparitor = new Comparator<Room>() {

        @Override
        public int compare(Room room1, Room room2) {
            int compareRoom1 = room1.getNumberOfSeats();
            int compareRoom2 = room2.getNumberOfSeats();

            //ascending order
            return compareRoom1 - compareRoom2;
        }
    };

    /**
     * 4/7/2014 MF Assignment 7 modification. This is the first of the
     * Comparators. It takes the values from the Room Arraylist and compares the
     * values of the each objects room number and orders them ascending.
     * http://beginnersbook.com/2013/12/java-arraylist-of-object-sort-example-comparable-and-comparator/
     */
    public static Comparator<Room> roomNumberComparitor = new Comparator<Room>() {

        @Override
        public int compare(Room room1, Room room2) {
            int compareRoom1 = room1.getRoomNumber();
            int compareRoom2 = room2.getRoomNumber();

            //ascending order
            return compareRoom1 - compareRoom2;
        }
    };

    //* 4/9/2014 MF Assignment 7 modification.  Added Override annotation *
    @Override
    public String toString() {
        String output = "\n\n******************************"
                + "\nRoom Number: " + super.getRoomNumber()
                + "\nNumber of Seats: " + super.getNumberOfSeats()
                + "\nReserved By: " + reservedBy
                + "\nReserved: " + reserved
                + "\nSmart Board: " + hasSmartBoard;
        return output;
    }
}
