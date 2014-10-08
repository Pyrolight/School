package bowlingally;

import java.util.Scanner;

/**
 *
 * @author Michael Fesser
 * @since 1/27/2014
 *
 * The Purpose of this class is to create and populate the PLAYERS array.  It will 
 * hold the four required players.  Also the class creates an object "score" that is 
 * used to hold the array in the bowlingScore class.
 */
public class Players {

    private final int MAX_NUMBER_PLAYERS = 4;                                   
    private final String[] PLAYERS = new String[MAX_NUMBER_PLAYERS];            // PLAYERS array constant who's value is set via MAX_NUMBER_PLAYERS.
    int playerCounter = 1;                                                      // Used to output the correct human representation of the array position. 

    /**
    * This method gets the user input for the players then populates the PLAYERS.
    * An object is created to store the array in the BowlingScore class and the PLAYERS
    * array is passed via that object into the setBowlingScores method to be used 
    * for the output.
    */
    public void setPlayers() {
        Scanner inputName = new Scanner(System.in);
             System.out.println("Welcome to bowl your life away!\n");
        for (int i = 0; i < PLAYERS.length; i++) {                              // Loop for the required number of players.
            System.out.print("Enter player#" + playerCounter + " name: ");
            PLAYERS[i] = inputName.next();                                      // Populate the array.
            playerCounter++;
        }
        BowlingScore score = new BowlingScore();                                // Create the score object used with the BowlingScore class.
        score.setBowlingScore(PLAYERS);                                         // Pass PLAYERS to the setBolwingScore method.
    }
}
