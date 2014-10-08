package usehotelroom;

import java.util.*;

/**
 *
 * @author Michael Fesser
 * @since 3/9/2014
 * 
 * This class gets the user input for the room and returns and displays the 
 * cost of the room both as a standard room and as a suite.
 */
public class UseHotelRoom {

    /**
     * This method gets the user input for the room and returns and displays the 
     * cost of the room both as a standard room and as a suite.
     * 
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int roomNumber = 0;
        Scanner input = new Scanner(System.in);

        // Quick validation on the room to allow for testing.
        do {
            System.out.println("What room number would you like?  The valid room number are 1 to 500 inclusive.");
            roomNumber = input.nextInt();
        } while (roomNumber < 1 || roomNumber > 500);

        // Create the object for the HotelRoom class.
        HotelRoom testHotelRoom = new HotelRoom(roomNumber);
        // Create the object for the Suite child class.
        Suite testSuite = new Suite(roomNumber);
        
        // Display the output from the Hotel class.
        System.out.println(testHotelRoom);
        // Display the output from the Suite class.
        System.out.println(testSuite);
    }
}
