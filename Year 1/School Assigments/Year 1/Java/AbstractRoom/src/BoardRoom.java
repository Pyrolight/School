
import java.util.Scanner;

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
/**
 *
 * @author bjmaclean
 */
public class BoardRoom extends Room {

    private boolean hasTeleconferencing;

    public BoardRoom(int roomNumber) {
        super(roomNumber);
    }

    public boolean isHasTeleconferencing() {
        return hasTeleconferencing;
    }

    public void setHasTeleconferencing(boolean hasTeleconferencing) {
        this.hasTeleconferencing = hasTeleconferencing;
    }

    public String toString() {
        return super.toString() + "\nHas teleconferencing: " + hasTeleconferencing;
    }

    /**
     * Get the details from the user about this class. This will invoke the
     * super method to get the base class attributes.
     */
    //* 4/9/2014 MF Assignment 7 modification.  Added Override annotation *
    @Override
    public void getRoomDetailsFromUser() {
        super.getRoomDetailsFromUser();
        Scanner input = new Scanner(System.in);
        System.out.print("Does this room have teleconferencing (y/n) ");
        hasTeleconferencing = input.nextLine().equalsIgnoreCase("y");

    }
}
