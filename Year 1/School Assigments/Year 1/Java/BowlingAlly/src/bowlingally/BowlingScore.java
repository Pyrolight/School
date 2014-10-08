package bowlingally;

import java.util.Scanner;

/**
 *
 * @author Michael Fesser
 * @since 1/27/2014
 *
 * The Purpose of this class is to create and populate the two dimensional array
 * SCORE and to output the results of the users input. The array size is defined
 * by the two constants NUMBER_OF_PLAYERS and MAX_NUMBER_ENDS. The class also
 * tracks the final scores and stores them in the FINAL_SCORES array to be used
 * to calculate the winner.
 */
public class BowlingScore {

    private final int NUMBER_OF_PLAYERS = 4;
    private final int MAX_NUMBER_ENDS = 10;
    private final int[][] SCORE = new int[NUMBER_OF_PLAYERS][MAX_NUMBER_ENDS];  // SCORE array, size set by NUMBER_OF_PLAYERS and MAX_NUMBER_ENDS.
    private final int[] FINAL_SCORES = new int[NUMBER_OF_PLAYERS];              // Used to store the final scores to display the winner.
    private int currentTopScore = 0;
    private String winner;

    /**
     * This method takes the scores from the user and populates each element of
     * the array. It used two for loops to populate each users score in order
     * one end at a time. It passes PLAYERS, currentPlayer and endNumber to be
     * used in the displayScores method and when the SCORE array is populated it
     * calls the finalScores method to do the final calculations and display the
     * scores and the winner.
     *
     * @param PLAYERS
     */
    public void setBowlingScore(String[] PLAYERS) {
        Scanner inputScore = new Scanner(System.in);
        for (int endNumber = 0; endNumber < MAX_NUMBER_ENDS; endNumber++) {     // This loop cycles through each end.
            for (int currentPlayer = 0; currentPlayer < NUMBER_OF_PLAYERS; currentPlayer++) {  // This loop cycles the players.  
                System.out.print("\nEnter score for " + PLAYERS[currentPlayer] + ": ");
                SCORE[currentPlayer][endNumber] = inputScore.nextInt();         // Populate the array at the position of the current player and current end.
                displayScores(PLAYERS, currentPlayer, endNumber);               // Call the displayScores method.
            }
        }
        finalScores(PLAYERS);                                                   // Call the finalScores method.
    }

    /**
     * This method takes the PLAYERS array and the currentPlayer and endNumber
     * variables and uses them to calculate and show the current score for each
     * player after their data was entered in the setBolwingScore method.
     *
     * The output shows all the scores for the previous ends as a normal bowling
     * sheet would.
     *
     * @param PLAYERS
     * @param currentPlayer
     * @param endNumber
     */
    public void displayScores(String[] PLAYERS, int currentPlayer, int endNumber) {
        int currentScore = 0;                                                   // Clear score for each player every time the method is called.
        String stringCurrentScore = "";                                         // Clear stringCurrentScore for each player every time the method is called.
        int counter = 0;
        while (counter <= endNumber) {
            currentScore += SCORE[currentPlayer][counter];                      // Set currentScore for each end.
            stringCurrentScore += currentScore + " ";                           // Set currentScore to a string to allow proper formatting, ie 1 3 8 10 etc.
            counter++;
        }
        System.out.print("The current score for " + PLAYERS[currentPlayer] + " is: " + stringCurrentScore + "\n"); // Display the stringCurrentScore for each player.
    }

    /**
     * This method shows the final scores for the players as well as it
     * calculates who won the game. If there is a tie, all those players name
     * are displayed.
     *
     * @param PLAYERS
     */
    public void finalScores(String[] PLAYERS) {
        int currentPlayer = 0;
        int endNumber = 0;
        System.out.println("\nLet's look at the final scores and see who won:\n");
        while (currentPlayer < NUMBER_OF_PLAYERS) {                             // This loops continues until all the players scores have been tallied.
            while (endNumber < MAX_NUMBER_ENDS) {                               // This loop continues until all the ends have been tallied.
                FINAL_SCORES[currentPlayer] += SCORE[currentPlayer][endNumber]; // Add all the scored for each end for the current player.
                endNumber++;
            }
            System.out.println(PLAYERS[currentPlayer] + "'s score was: " + FINAL_SCORES[currentPlayer]);  // Display the score for the current player.

            if (FINAL_SCORES[currentPlayer] > currentTopScore) {                // Set the currentTopScore and the winner.
                currentTopScore = FINAL_SCORES[currentPlayer];
                winner = PLAYERS[currentPlayer];
            } else if (FINAL_SCORES[currentPlayer] == currentTopScore) {        // Set winner to multiple players if there is a tie in scores.
                winner += " and " + PLAYERS[currentPlayer];
            }
            currentPlayer++;
            endNumber = 0;
        }
        System.out.println("\nCongratulations " + winner + "!");                // Display the winner.
    }
}
