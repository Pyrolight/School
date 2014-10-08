package bowlingally;

/**
 *
 * @author Michael Fesser
 * @since 1/27/2014
 *
 * The Purpose of this project is the create a bowling ally score card. The user
 * inputs the names of the players and the score for each end. The program keeps
 * a running tally and at the end displays the winner.
 */
public class BowlingAlly {

    /**
     * * @author Michael Fesser
     * @since 1/27/2014
     *
     * The main method simply creates the first object and calls the setPlayers method 
     * in the Players class.  This is an attempt to make the main program as small as 
     * possible while avoiding method calls from a constructor.
     * 
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Players players = new Players();                                        // Create players object.
        players.setPlayers();                                                   // Call set method in the Players class.
    }
}
