
import java.util.*;

/**
 *
 * @author Michael Fesser
 * @Since Mar 19, 2014
 *
 * The purpose of this class is to hold methods for the functionally of the
 * menus in the main class.
 */
public class RoomUtility {

    private static int largestRoomIndex = 0;
    // Used to hold the results of the room search.
    private static ArrayList<Room> searchRooms = new ArrayList();

    /**
     * This method loops over the rooms arraylist and counts the number of times
     * each room type appears. It finds and outputs the largest room.
     *
     * @param rooms
     */
    public static void roomInfo(ArrayList<Room> rooms) {
        // The following are used as a counter for the type of room.
        int standardClassRoom = 0;
        int computerRoom = 0;
        int biologyLab = 0;
        int boardRoom = 0;
        int executiveBoardRoom = 0;
        // This is used to hold the a string representation of the objects of the largest rooms
        String largestRoomsString = "";

        // Iterate over rooms arraylist.
        for (Room room : rooms) {
            if (room instanceof ComputerRoom) {
                computerRoom++;
            } else if (room instanceof BiologyLab) {
                biologyLab++;
            } else if (room instanceof ExecutiveBoardRoom) {
                executiveBoardRoom++;
            } else if (room instanceof BoardRoom) {
                boardRoom++;
            } else {
                standardClassRoom++;
            }
            
            // Used to populate the largest room string.  First if statement only used when the loop is first run and when the largest room will be the first room.
            if (rooms.indexOf(room) == 0  && largestRoomIndex == 0) {
                largestRoomIndex = rooms.indexOf(room);
                largestRoomsString = "Room#" + rooms.get(largestRoomIndex).getRoomNumber() + " with " + rooms.get(largestRoomIndex).getNumberOfSeats() + " seats.\n";
            } else if (room.getNumberOfSeats() > rooms.get(largestRoomIndex).getNumberOfSeats()) {
                largestRoomIndex = rooms.indexOf(room);
                largestRoomsString = "Room#" + rooms.get(largestRoomIndex).getRoomNumber() + " with " + rooms.get(largestRoomIndex).getNumberOfSeats() + " seats.\n";
            } else if (room.getNumberOfSeats() == rooms.get(largestRoomIndex).getNumberOfSeats()) {
                largestRoomIndex = rooms.indexOf(room);
                largestRoomsString += "                       Room#" + rooms.get(largestRoomIndex).getRoomNumber() + " with " + rooms.get(largestRoomIndex).getNumberOfSeats() + " seats.\n";
            }
        }

        if (rooms.isEmpty()) {
            System.out.println("\nYou have not added any rooms yet.\n");
        } else {
            String output = "\n\n******************************"
                    + "\nRoom Count Details Report"
                    + "\nStandard Class Room:   " + standardClassRoom
                    + "\nComputer Room:         " + computerRoom
                    + "\nBiology Lab:           " + biologyLab
                    + "\nBoard Room:            " + boardRoom
                    + "\nExecutive Board Room:  " + executiveBoardRoom + "\n\n"
                    + "Largest Room(s):       " + largestRoomsString + "\n";
            System.out.println(output);
        }
    }

    /**
     * This method is used as a search function.  The user selects a room type and number of seats.
     * If the room type matches and the number of seats is greater then the number requested,
     * the rooms are added to searchRooms arraylist and then displayed.
     * 
     * @param rooms 
     */
    public static void searchRoom(ArrayList<Room> rooms) {
        Scanner input = new Scanner(System.in);
        boolean finished = false;
        int seatChoice = 0;
        // clear the arraylist for each search.
        searchRooms.clear();

        do {
            System.out.print("What type of room would you like?\n"
                    + "1) Standard Classroom\n"
                    + "2) Computer Lab\n"
                    + "3) Biology Lab\n"
                    + "4) Board Room\n"
                    + "5) Executive Board Room\n");

            String roomChoice = input.nextLine();
            do {
                System.out.print("How many seats would you like the room to have?\n");
                seatChoice = input.nextInt();
            } while (seatChoice < 1 || seatChoice > 5000);

            //***********************************************************
            //Based on the user input, search the correct type of room.  
            //***********************************************************
            switch (roomChoice) {
                case "1":
                    for (Room room : rooms) {
                        // Special case for a standard room since any type of room is a Room.  If the room is any other type then a standard one, do nothing.
                        // Setting a variable to flag a standard room that is not inheritable and set after the room is created might have been a better option.
                        if (room instanceof ComputerRoom || room instanceof BiologyLab || room instanceof BoardRoom || room instanceof ExecutiveBoardRoom) {
                        } else {
                            if (room.getNumberOfSeats() >= seatChoice && room.isReserved() == false) {
                                searchRooms.add(room);
                            }
                        }
                    }
                    finished = true;
                    break;
                case "2":
                    for (Room room : rooms) {
                        if (room instanceof ComputerRoom) {
                            if (room.getNumberOfSeats() >= seatChoice && room.isReserved() == false) {
                                searchRooms.add(room);
                            }
                        }
                    }
                    finished = true;
                    break;
                case "3":
                    for (Room room : rooms) {
                        if (room instanceof BiologyLab) {
                            if (room.getNumberOfSeats() >= seatChoice && room.isReserved() == false) {
                                searchRooms.add(room);
                            }
                        }
                    }
                    finished = true;
                    break;
                case "4":
                    for (Room room : rooms) {
                        if (room instanceof BoardRoom) {
                            if (room.getNumberOfSeats() >= seatChoice && room.isReserved() == false) {
                                searchRooms.add(room);
                            }
                        }
                    }
                    finished = true;
                    break;
                case "5":
                    for (Room room : rooms) {
                        if (room instanceof ExecutiveBoardRoom) {
                            if (room.getNumberOfSeats() >= seatChoice && room.isReserved() == false) {
                                searchRooms.add(room);
                            }
                        }
                    }
                    finished = true;
                    break;
                default:
                    System.out.println("Invalid option");
            }
        } while (!finished);
        
        // Show rooms that match criteria, or give the user a message if there are none.
        if (searchRooms.size() > 0) {
            for (Room room : searchRooms) {
                System.out.println(room);
            }
        } else {
            System.out.println("Sorry there were no rooms available\n");
        }
    }
}
