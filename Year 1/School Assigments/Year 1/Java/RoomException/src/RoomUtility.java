
import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author Ryan
 * @since March 23, 2014
 *
 * This class is used for counting the rooms as well as searching for a room
 * that suits the users need.
 */
public class RoomUtility {

    public static void roomCount(ArrayList<Room> rooms) {
        int numOfRoom = 0;
        int numOfComputerRoom = 0;
        int numOfBoardRoom = 0;
        int numOfBoardRoomPro = 0;
        int numOfBiologyRoom = 0;
        int largestRoom = 0;
        int largestNumOfRooms = 0;
        for (int i = 0; i < rooms.size(); i++) {

            System.out.println("This room is a: " + rooms.get(i).getClass().toString());
            if (rooms.get(i).getClass().toString().equals("class Room")) {
                numOfRoom += 1;
            }
            if (rooms.get(i).getClass().toString().equals("class ComputerRoom")) {
                numOfComputerRoom += 1;
            }
            if (rooms.get(i).getClass().toString().equals("class BoardRoom")) {
                numOfBoardRoom += 1;
            }
            if (rooms.get(i).getClass().toString().equals("class BiologyLab")) {
                numOfBiologyRoom += 1;
            }
            if (rooms.get(i).getClass().toString().equals("class BoardRoomPro")) {
                numOfBoardRoomPro += 1;
            }

            if (rooms.get(i).getNumberOfSeats() > largestNumOfRooms) {//Determine largest room
                largestNumOfRooms = rooms.get(i).getNumberOfSeats();
                largestRoom = rooms.get(i).getRoomNumber();
            }
        }
        //Display the results of counting 
        System.out.println("Room Count Details Report"
                + "\nRooms: " + numOfRoom
                + "\nComputer Rooms: " + numOfComputerRoom
                + "\nBiology Labs: " + numOfBiologyRoom
                + "\nBoard Rooms: " + numOfBoardRoom
                + "\nFancy Board Rooms: " + numOfBoardRoomPro
                + "\n\nLargest Room is #" + largestRoom + " with " + largestNumOfRooms + "seats");
    }

    public static void roomSearch(ArrayList<Room> rooms) {
        Scanner input = new Scanner(System.in);
        int roomTypeNum = 0;
        //* April 15, 2014 MF Assignment 8 Modification.  Create numOfSeats outside try-catch to keep in scope.*//
        int numOfSeats = 0;
        do {
            //* April 15, 2014 MF Assignment 8 Modification.  Added the try-catch block to catch non numeric input. *//
            try {
                System.out.println("1) Room\n"
                        + "2) Computer Lab\n"
                        + "3) Board Room\n"
                        + "4) Biology lab\n"
                        + "5) Fancy Board Room");
                //* April 15, 2014 MF Assignment 8 Modification.  I hate the burning the line, I would rather convert it. *//
                roomTypeNum = Integer.parseInt(input.nextLine());
            } catch (NumberFormatException nfe) {
                System.out.println("The input needs to be numeric.");
            }
        } while (roomTypeNum < 1 || roomTypeNum > 5);
        String roomTypeString = "";

        if (roomTypeNum == 1) {
            roomTypeString = "class Room";
        }
        if (roomTypeNum == 2) {
            roomTypeString = "class ComputerRoom";
        }
        if (roomTypeNum == 3) {
            roomTypeString = "class BoardRoom";
        }
        if (roomTypeNum == 4) {
            roomTypeString = "class BiologyLab";
        }
        if (roomTypeNum == 5) {
            roomTypeString = "class BoardRoomPro";
        }
        //* April 15, 2014 MF Assignment 8 Modification.  Added the try-catch block to catch non numeric input. *//
        try {
            System.out.println("How many seats do you need?");
            //* April 15, 2014 MF Assignment 8 Modification.  I hate the burning the line, I would rather convert it. *//
            numOfSeats = Integer.parseInt(input.nextLine());
        } catch (NumberFormatException nfe) {
            System.out.println("The input needs to be numeric.");
        }
        for (int i = 0; i < rooms.size(); i++) {
            if (rooms.get(i).getClass().toString().equals(roomTypeString)) {//If it is the right type of room..
                if (!rooms.get(i).isReserved()) {                           //<--and the room is not reserved.. 
                    if (rooms.get(i).getNumberOfSeats() >= numOfSeats) {    //<-- and it also has the right number of seats or more.
                        System.out.println("\n\n******************************"
                                + "\nRoom Number: " + rooms.get(i).getRoomNumber()
                                + "\nNumber of Seats: " + rooms.get(i).getNumberOfSeats()
                                + "\nSmart Board: " + rooms.get(i).isHasSmartBoard());
                    }
                }
            }

        }

    }

}
