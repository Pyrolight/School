/**
 *
 * @author bjmaclean
 * 
 * This class defines a biology lab that is an extension of the Room class.
 * Note:  Slight modification to the class to remove the unused setters.  No used
 * functionality was changed.
 */
public class BiologyLab extends Room {

    private int numberOfMicroscopes;
    private boolean hasFumeHood;
    private boolean hasBunsonBurners;

    public BiologyLab(int roomNumber) {
        super(roomNumber);
    }

    /**
     * Get the details from the user about this class. This will invoke the
     * super method to get the base class attributes.
     */
    @Override
    public void getRoomDetailsFromUser() {
        super.getRoomDetailsFromUser();
        System.out.print("How many microscopes does this room have? ");
        numberOfMicroscopes = input.nextInt();
        input.nextLine();
        System.out.print("Does this lab have a fume hood? ");
        hasFumeHood = input.nextLine().equalsIgnoreCase("y");
        System.out.print("Does this lab have bunson burners? ");
        hasBunsonBurners = input.nextLine().equalsIgnoreCase("y");
    }

    public int getNumberOfMicroscopes() {
        return numberOfMicroscopes;
    }

    public boolean isHasFumeHood() {
        return hasFumeHood;
    }

    public boolean isHasBunsonBurners() {
        return hasBunsonBurners;
    }

    @Override
    public String toString() {
        return super.toString() + "Number of Microscopes: " + numberOfMicroscopes + "\nHas Fumehood: " + hasFumeHood + "\nHas Bunson Burners: " + hasBunsonBurners + "\n";
    }
}
