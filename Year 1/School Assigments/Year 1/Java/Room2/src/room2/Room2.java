/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package room2;

import javax.swing.JOptionPane;

/**
 *
 * @author mfesser
 * @since 09162013
 */
public class Room2 {

    /**
     * @author Mike Fesser
     * @since 09162013
     * @param args
     *
     * The purpose of this class is to find the area of a room using user
     * defined variables.
     */
    public static void main(String[] args) {

        String stringLength;
        String stringWidth;
        int length;
        int width;
        int area;

        stringLength = JOptionPane.showInputDialog("What is the length of the room?");
        length = Integer.parseInt(stringLength);
        stringWidth = JOptionPane.showInputDialog("What is the width of the room?");
        width = Integer.parseInt(stringWidth);
        area = length * width;
        JOptionPane.showMessageDialog(null, "The length of the room is " + length + " feet.  The width of the room is " + width + " feet.  The room has " + area + " square feet of floor space.");
    }
}
