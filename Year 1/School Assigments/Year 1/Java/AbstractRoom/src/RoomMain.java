//* 4/8/2014 MF Assignment 7 modification.  Changed import to include all of java.util *

import java.util.*;

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
    //* 4/8/2014 MF Assignment 7 modification. Moved scanner to class wide. *
    public static Scanner input = new Scanner(System.in);

    /**
     * Main method controls program and user interface.
     *
     * @param args the command line arguments
     */
    public static void main(String[] args) {

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
            System.out.println(menu);
            selection = input.nextInt();
            input.nextLine();
            switch (selection) {
                case 1:
                    addRoom();
                    break;
                case 2:
                    reserveRoom();
                    break;
                case 3:
                    releaseRoom();
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
        System.out.print("Enter room number: ");
        roomNum = input.nextInt();

        input.nextLine();

        //***********************************************************
        //Check to see if the room already exists
        //***********************************************************
        int roomNumberIndex = getRoomNumberIfExists(roomNum);

        //If the room does not already exist.
        if (roomNumberIndex == ROOM_DOES_NOT_EXIST) {
            roomNumberIndex = rooms.size();
            boolean finished = false;
            do {
                //* 4/7/2014 MF Assignment 7 modification. Small change to display to change "add room" to Basic Class Room. *
                System.out.print("What type of room is this?\n" + "1) Basic Class Room\n"
                        + "2) Computer Lab\n"
                        + "3) Board Room\n"
                        + "4) Biology lab\n"
                        + "5) Fancy Board Room");
                String choice = input.nextLine();

                //***********************************************************
                //Based on the user input, create the correct type of room.  
                //***********************************************************
                switch (choice) {
                    case "1":

                        room = new Room(roomNum);
                        finished = true;
                        break;
                    case "2":
                        room = new ComputerRoom(roomNum);
                        finished = true;
                        break;
                    case "3":
                        room = new BoardRoom(roomNum);
                        finished = true;
                        break;
                    case "4":
                        room = new BiologyLab(roomNum);
                        finished = true;
                        break;
                    case "5":
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
     */
    public static void reserveRoom() {

        Scanner input = new Scanner(System.in);
        System.out.println("Enter the room number you would like to book");
        int roomNumber = input.nextInt();
        input.nextLine();

        //Check to see if the room exists.
        int roomNumberIndex = getRoomNumberIfExists(roomNumber);
        if (roomNumberIndex < 0) {
            System.out.println("This room does not exist");
        } else {
            //Put the room from the ArrayList into a local variable.
            Room room = rooms.get(roomNumberIndex);
            if (!room.isReserved()) {
                room.reserveThisRoom();
            } else {
                System.out.println("This room is already booked!");
            }
        }
    }

    public static void releaseRoom() {

        Scanner input = new Scanner(System.in);
        System.out.println("Enter the room number you would like to release");
        int roomNumber = input.nextInt();
        input.nextLine();

        //Check if the room exists.  
        int roomNumberIndex = getRoomNumberIfExists(roomNumber);

        if (roomNumberIndex < 0) {
            System.out.println("This room does not exist");
        } else {
            //Put the room from the ArrayList into a local variable.
            Room room = rooms.get(roomNumberIndex);
            //If the room is reserved, allow them to release.
            if (room.isReserved()) {
                room.releaseThisRoom();
            } else {
                System.out.println("This room is not booked!");
            }
        }
    }

    /**
     * Show the details for each room
     */
    public static void showRooms() {
        //* 4/8/2014 MF Assignment 7 modification. Added the required menu items. *
        System.out.println("Enter the sort option"
                + "\n 1) Sort by the number of seats ascending"
                + "\n 2) Sort by the room number ascending");
        String sort = input.nextLine();

        /**
         * 4/8/2014 MF Assignment 7 modification. This switch will sort the room
         * by number of seats for case 1 and room number for case 2. Comparitor
         * are used.
         * http://beginnersbook.com/2013/12/java-arraylist-of-object-sort-example-comparable-and-comparator/
         */
        switch (sort) {
            case "1":
                Collections.sort(rooms, Room.numberOfSeatsComparitor);
                for (Room count : rooms) {
                    System.out.println(count);
                }
                break;
            case "2":
                Collections.sort(rooms, Room.roomNumberComparitor);
                for (Room count : rooms) {
                    System.out.println(count);
                }
                break;
            default:
                System.out.println("Invalid option");
                break;
        }
        // 4/8/2014 MF Assignment 7 modification.  Removed for loop.
    }
}
