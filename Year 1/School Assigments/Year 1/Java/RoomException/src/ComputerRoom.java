
import java.util.Scanner;

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
/**
 *
 * @author bjmaclean
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
    public void getRoomDetailsFromUser() {
        super.getRoomDetailsFromUser();
        Scanner input = new Scanner(System.in);
        //* April 15, 2014 MF Assignment 8 Modification.  Added the try-catch block to catch non numeric input. *//
        try {
            System.out.print("Enter number of computers: ");
            //* April 15, 2014 MF Assignment 8 Modification.  I hate the burning the line, I would rather convert it. *//
            numberOfComputers = Integer.parseInt(input.nextLine());
        } catch (NumberFormatException nfe) {
            System.out.println("The input needs to be numeric.");
        }
    }

    public int getNumberOfComputer() {
        return numberOfComputers;
    }

    public void setNumberOfComputer(int numberOfComputer) {
        this.numberOfComputers = numberOfComputer;
    }

    public String toString() {
        return super.toString() + "\nNumber of Computers" + numberOfComputers;
    }
}
