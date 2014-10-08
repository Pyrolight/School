/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package room;

/**
 *
 * @author mfesser
 * @since 09162013
 */
public class Room {

    /**
     * @author Mike Fesser
     * @since 09162013
     * @param args 
     * 
     * The purpose of this class is to find the area of a room using
     * static variables.
     */
    public static void main(String[] args) {

        int length = 15;
        int width = 25;
        int area;

        area = length * width;
        System.out.println("The room is " + area + " square feet.");
    }
}
