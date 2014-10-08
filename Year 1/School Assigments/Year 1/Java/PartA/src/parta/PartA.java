/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package parta;

import javax.swing.JOptionPane;

/**
 *
 * @author Michael Fesser
 * @since 11/20/2013
 * 
 * The purpose of this class is to do a loop that counts to 300 and gets the sum.
 * 
 */
public class PartA {

    /**
     * @ author Michael Fesser
     * @ since 11/20/2013
     * @param args the command line arguments
     */
    public static void main(String[] args) {    
        int sum = 0;
        int counter = 0;
        
        while (counter <= 300){                                                 // count to 300 
        sum += counter;                                                         // make the sum to total of the sum + the counter each time the loop runs
        counter +=2;                                                            
            
        }
        JOptionPane.showMessageDialog(null, sum);
    }
    
}
