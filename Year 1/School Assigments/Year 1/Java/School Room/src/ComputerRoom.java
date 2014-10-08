/**
 *
 * @author bjmaclean
 * 
 * This class defines a computer room that is an extension of the Room class.
 * Note:  Slight modification to the class to remove the unused setters.  No used
 * functionality was changed.
 */
public class ComputerRoom extends Room {

    int numberOfComputers;

    public ComputerRoom(int roomNumber) {
        super(roomNumber);
    }

    /**
     * Get the details from the user about this class. This will invoke the
     * super method to get the base class attributes.
     */
    @Override
    public void getRoomDetailsFromUser() {
        super.getRoomDetailsFromUser();
        System.out.print("Enter number of computers: ");
        numberOfComputers = input.nextInt();
        input.nextLine();
    }

    public int getNumberOfComputer() {
        return numberOfComputers;
    }

    public void setNumberOfComputer(int numberOfComputer) {
        this.numberOfComputers = numberOfComputer;
    }

    @Override
    public String toString() {
        return super.toString() + "Number of Computers " + numberOfComputers + "\n";
    }
}
