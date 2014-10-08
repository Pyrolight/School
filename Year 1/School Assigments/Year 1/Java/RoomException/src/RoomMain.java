//* April 15, 2014 MF Assignment 8 Modification.  Imported RoomExistException, RoomReservationException. *//

import exception.RoomExistException;
import exception.RoomReservationException;
import java.util.ArrayList;
import java.util.Scanner;

/**
 * This main method will invoke functionality for booking college rooms.
 *
 * Detailed description:
 * https://docs.google.com/document/d/1jyrvSJHXS6BZuXKVswYkmt2muBmPI71OxXTLQxerDVU/edit
 *
 * @author cis1232 (including Roger)
 *
 * UPDATED################## This class has been modified by Ryan Forrester to
 * work with the new classes that have been added.
 */
public class RoomMain {

    private static final int ROOM_DOES_NOT_EXIST = -1;
    private static ArrayList<Room> rooms = new ArrayList();
    private static int roomNum;

    /**
     * Main method controls program and user interface.
     *
     * @param args the command line arguments
     *
     */
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        String menu = "Choose an option:\n"
                + "1) Add Room\n"
                + "2) Reserve Room\n"
                + "3) Release Room\n"
                + "4) Show Rooms\n"
                + "5) Room Count\n"
                + "6) Room Search\n"
                + "7) Exit";
        int selection = 0;

        while (selection != 7) {
            //* April 15, 2014 MF Assignment 8 Modification.  Added the try-catch block to catch non numeric input. *//
            try {
                System.out.println(menu);
                //* April 15, 2014 MF Assignment 8 Modification.  I hate the burning the line, I would rather convert it. *//
                selection = Integer.parseInt(input.nextLine());
            } catch (NumberFormatException nfe) {
                System.out.println("The input needs to be numeric.");
            }
            switch (selection) {
                case 1:
                    addRoom();
                    break;
                case 2:
                    //* April 15, 2014 MF Assignment 8 Modification.  Added the try-catch block. Catches non numeric input exceptions and user generated exceptions. *//
                    try {
                        reserveRoom();
                    } catch (RoomExistException | RoomReservationException ex ) {
                        System.out.println("There was an error reserving the room (" + ex.getMessage() + ")");
                    } catch (NumberFormatException nf){
                    System.out.println("The input needs to be numeric.");
                    }
                    break;
                case 3:
                    //* April 15, 2014 MF Assignment 8 Modification.  Added the try-catch block. Catches non numeric input exceptions and user generated exceptions. *//
                    try {
                        releaseRoom();
                    } catch (RoomExistException | RoomReservationException ex) {
                        System.out.println("There was an error reserving the room (" + ex.getMessage() + ")");
                    } catch (NumberFormatException nf){
                    System.out.println("The input needs to be numeric.");
                    }
                    break;
                case 4:
                    showRooms();
                    break;
                case 5:
                    RoomUtility.roomCount(rooms);
                    break;
                case 6:
                    RoomUtility.roomSearch(rooms);
                    break;
                case 7:
                    break;
                default:
                    System.out.println("Invalid option.");
            }
        }

    }

    /**
     * Loop through the rooms to check if the room already exists.
     *
     * @param roomNumber
     * @return the index of the room number
     */
    public static int getRoomNumberIfExists(int roomNumber) {
        int index = -1;
        for (int i = 0; i < rooms.size(); i++) {
            if (rooms.get(i).getRoomNumber() == roomNumber) {
                index = i;
            }
        }
        return index;
    }

    /**
     * This method will allow the user to add a new room to the collection of
     * rooms.
     *
     */
    public static void addRoom() {

        //***********************************************************
        //Ask which room number the user wants to add
        //***********************************************************
        Room room = null;
        Scanner input = new Scanner(System.in);
        //* April 16, 2014 MF Assignment 8 Modification.  Added the try-catch block to catch non numeric input. *//
        try {
            System.out.print("Enter room number: ");;
            //* April 16, 2014 MF Assignment 8 Modification.  I hate the burning the line, I would rather convert it. *//
            roomNum = Integer.parseInt(input.nextLine());
        } catch (NumberFormatException nfe) {
            System.out.println("The input needs to be numeric.");
        }

        //***********************************************************
        //Check to see if the room already exists
        //***********************************************************
        int roomNumberIndex = getRoomNumberIfExists(roomNum);

        //If the room does not already exist.
        if (roomNumberIndex == ROOM_DOES_NOT_EXIST) {
            roomNumberIndex = rooms.size();
            boolean finished = false;
            //* April 15, 2014 MF Assignment 8 Modification.  Create choice outside try-catch to keep in scope.*//
            int choice = 0;
            do {
                //* April 15, 2014 MF Assignment 8 Modification.  Added the try-catch block to catch non numeric input. *//
                try {
                    System.out.print("What type of room is this?\n" + "1) Add Room\n"
                            + "2) Computer Lab\n"
                            + "3) Board Room\n"
                            + "4) Biology lab\n"
                            + "5) Fancy Board Room");
                    //* April 15, 2014 MF Assignment 8 Modification.  Changed to numeric input for consistancy. *//
                    choice = Integer.parseInt(input.nextLine());
                } catch (NumberFormatException nfe) {
                    System.out.println("The input needs to be numeric.");
                }

                //***********************************************************
                //Based on the user input, create the correct type of room.  
                //***********************************************************
                switch (choice) {
                    case 1:

                        room = new Room(roomNum);
                        finished = true;
                        break;
                    case 2:
                        room = new ComputerRoom(roomNum);
                        finished = true;
                        break;
                    case 3:
                        room = new BoardRoom(roomNum);
                        finished = true;
                        break;
                    case 4:
                        room = new BiologyLab(roomNum);
                        finished = true;
                        break;
                    case 5:
                        room = new BoardRoomPro(roomNum);
                        finished = true;
                        break;
                    default:
                        System.out.println("Invalid option");

                }
            } while (!finished);

            //Set the details for the room
            //Note the correct method will be invoked based on which type of room was created above.
            room.getRoomDetailsFromUser();

            //Add the room to the collection of rooms.  Note that as long as an object 'is a' Room 
            //(all of the types of rooms above are rooms), then it can be added to the collection of 
            //rooms.
            rooms.add(room);

        } else {
            String choice = "";
            System.out.println("Room already exists. Do you want to continue? (Y/N)");
            choice = input.nextLine();

            //If the user wants to continue, invoke the method to change the value of attributes in 
            //the room
            if (choice.equalsIgnoreCase("y")) {
                rooms.get(roomNumberIndex).getRoomDetailsFromUser();
            }
        }
    }

    /**
     * This method will allow the user to reserve a room.
     *
     * @throws exception.RoomExistException
     * @throws exception.RoomReservationException
     *
     * April 15, 2014 MF Assignment 8 Modification. Added the throws exceptions
     * to the code and comments.
     */
    public static void reserveRoom() throws RoomExistException, RoomReservationException {
        Scanner input = new Scanner(System.in);
        System.out.println("Enter the room number you would like to book");
        //* April 15, 2014 MF Assignment 8 Modification.  I hate the burning the line, I would rather convert it. *//
        int roomNumber = Integer.parseInt(input.nextLine());
        //Check to see if the room exists.
        int roomNumberIndex = getRoomNumberIfExists(roomNumber);
        if (roomNumberIndex < 0) {
            //* April 15, 2014 MF Assignment 8 Modification.  Added this throw to the code. *//
            throw new RoomExistException("The room does not exist!");
        }
        //Put the room from the ArrayList into a local variable.
        Room room = rooms.get(roomNumberIndex);
        if (!room.isReserved()) {
            room.reserveThisRoom();
        } else {
            //* April 15, 2014 MF Assignment 8 Modification.  Added this throw to the code. *//
            throw new RoomReservationException("This room is already booked!");
        }
    }

    //* April 15, 2014 MF Assignment 8 Modification.  Added the throws exceptions to the code. *//
    public static void releaseRoom() throws RoomExistException, RoomReservationException {

        Scanner input = new Scanner(System.in);
        System.out.println("Enter the room number you would like to release");
        //* April 15, 2014 MF Assignment 8 Modification.  I hate the burning the line, I would rather convert it. *//
        int roomNumber = Integer.parseInt(input.nextLine());

        //Check if the room exists.  
        int roomNumberIndex = getRoomNumberIfExists(roomNumber);

        if (roomNumberIndex < 0) {
            //* April 15, 2014 MF Assignment 8 Modification.  Added this throw to the code. *//
            throw new RoomExistException("The room does not exist!");
        } else {
            //Put the room from the ArrayList into a local variable.
            Room room = rooms.get(roomNumberIndex);
            //If the room is reserved, allow them to release.
            if (room.isReserved()) {
                room.releaseThisRoom();
            } else {
                //* April 15, 2014 MF Assignment 8 Modification.  Added this throw to the code. *//
                throw new RoomReservationException("This room is not booked!");
            }
        }
    }

    /**
     * Show the details for each room
     */
    public static void showRooms() {
        for (int i = 0; i < rooms.size(); i++) {
            System.out.println(rooms.get(i));
        }
    }
}
