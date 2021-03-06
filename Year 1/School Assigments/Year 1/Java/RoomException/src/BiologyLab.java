
import java.util.Scanner;

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
/**
 *
 * @author bjmaclean
 */
public class BiologyLab extends Room {

    private int numberOfMicroscopes;
    private boolean hasFumeHood;
    private boolean hasBunsonBurners;

    public BiologyLab(int roomNumber) {
        super(roomNumber);
    }

    public int getNumberOfMicroscopes() {
        return numberOfMicroscopes;
    }

    public void setNumberOfMicroscopes(int numberOfMicroscopes) {
        this.numberOfMicroscopes = numberOfMicroscopes;
    }

    public boolean isHasFumeHood() {
        return hasFumeHood;
    }

    public void setHasFumeHood(boolean hasFumeHood) {
        this.hasFumeHood = hasFumeHood;
    }

    public boolean isHasBunsonBurners() {
        return hasBunsonBurners;
    }

    public void setHasBunsonBurners(boolean hasBunsonBurners) {
        this.hasBunsonBurners = hasBunsonBurners;
    }

    @Override
    public String toString() {
        return super.toString() + "\nNumber of microscopes: " + numberOfMicroscopes + "\nHas fumehood: " + hasFumeHood + "\nHas Bunson burners: " + hasBunsonBurners;
    }

    /**
     * Get the details from the user about this class. This will invoke the
     * super method to get the base class attributes.
     */
    @Override
    public void getRoomDetailsFromUser() {
        super.getRoomDetailsFromUser();
        Scanner input = new Scanner(System.in);
        //* April 15, 2014 MF Assignment 8 Modification.  Added the try-catch block to catch non numeric input. *//
        try {
            System.out.print("How many microscopes does this room have? ");
            //* April 15, 2014 MF Assignment 8 Modification.  I hate the burning the line, I would rather convert it. *//
            numberOfMicroscopes = Integer.parseInt(input.nextLine());
        } catch (NumberFormatException nfe) {
            System.out.println("The input needs to be numeric.");
        }
        System.out.print("Does this lab have a fume hood? ");
        hasFumeHood = input.nextLine().equalsIgnoreCase("y");
        System.out.print("Does this lab have bunson burners? ");
        hasBunsonBurners = input.nextLine().equalsIgnoreCase("y");
    }
}
