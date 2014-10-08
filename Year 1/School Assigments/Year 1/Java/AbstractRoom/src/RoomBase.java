
/**
 *
 * @author Michael Fesser
 * @since 4/7/2014
 *
 * This is an abstract class that the room class extends. This is used as the
 * base class for common fields used by all the child classes.
 */
public abstract class RoomBase {

    private int roomNumber;
    private int numberOfSeats;

    /**
     * This is the an abstract version of the getRoomDetailsFromUser method in
     * the Room class.
     */
    public abstract void getRoomDetailsFromUser();

    public int getRoomNumber() {
        return roomNumber;
    }

    public void setRoomNumber(int roomNumber) {
        this.roomNumber = roomNumber;
    }

    public int getNumberOfSeats() {
        return numberOfSeats;
    }

    public void setNumberOfSeats(int numberOfSeats) {
        this.numberOfSeats = numberOfSeats;
    }
}
