package usehotelroom;

/**
 *
 * @author Michael Fesser
 * @since 3/9/2014
 * 
 * This class holds all the basic information about a hotel room including the room 
 * number, rate for the room, and the cut off for the cheaper rooms.
 */
public class HotelRoom {

    private final int ROOM_NUMBER;
    private final double RENTAL_RATE;
    // used as the cut off for the cheaper rooms.
    private final int CHEAP_ROOM_NUMBER_MAX = 299;

    /**
     * This constructor sets the rental rate for the room that the user selected.
     * 
     * @param roomNumber 
     */
    public HotelRoom(int roomNumber) {
        this.ROOM_NUMBER = roomNumber;
        // Set the rental rate based on the room number selected.
        if (ROOM_NUMBER <= CHEAP_ROOM_NUMBER_MAX) {
            this.RENTAL_RATE = 69.95;
        } else {
            this.RENTAL_RATE = 89.95;
        }
    }

    public int getROOM_NUMBER() {
        return ROOM_NUMBER;
    }

    public double getRENTAL_RATE() {
        return RENTAL_RATE;
    }
    
    /**
     * This method is returns a string of the rate for a room.
     * 
     * @return roomPrice.
     */
    @Override
    public String toString(){
    String roomPrice = "The rate for the room is $" + RENTAL_RATE;
    return roomPrice;
    }
}
