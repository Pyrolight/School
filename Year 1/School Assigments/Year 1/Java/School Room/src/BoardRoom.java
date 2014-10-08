/**
 *
 * @author bjmaclean
 * 
 * This class defines a board room that is an extension of the Room class.
 * Note:  Slight modification to the class to remove the unused setters.  No used
 * functionality was changed.
 */
public class BoardRoom extends Room {

    private boolean hasTeleconferencing;

    public BoardRoom(int roomNumber) {
        super(roomNumber);
    }

    /**
     * Get the details from the user about this class. This will invoke the
     * super method to get the base class attributes.
     */
    @Override
    public void getRoomDetailsFromUser() {
        super.getRoomDetailsFromUser();
        System.out.print("Does this room have teleconferencing (Y/N) ");
        hasTeleconferencing = input.nextLine().equalsIgnoreCase("y");
    }

    public boolean isHasTeleconferencing() {
        return hasTeleconferencing;
    }

    @Override
    public String toString() {
        return super.toString() + "Has Teleconferencing: " + hasTeleconferencing + "\n";
    }

}
