
/**
 *
 * @author mfesser
 * @since 3/31/2014
 *
 * This class holds the details for a hockey player and extends the player
 * class.
 */
public class HockeyPlayer extends Player {

    private int goals;
    private int assists;
    private int penaltyMinutes;
    private int numberOfGames;

    /**
     * This method is the overridden version of the same method in the Player
     * class. It sets the specific details for all hockey players.
     */
    @Override
    public void getInformation() {
        // call to the method in the player class.
        super.getInformation();
        System.out.println("Enter the number of goals:");
        goals = Integer.parseInt(Practical3.input.nextLine());
        System.out.println("Enter the number of assists:");
        assists = Integer.parseInt(Practical3.input.nextLine());
        System.out.println("Enter the number of penalty minutes:");
        penaltyMinutes = Integer.parseInt(Practical3.input.nextLine());
        System.out.println("Enter number of games played:");
        numberOfGames = Integer.parseInt(Practical3.input.nextLine());
    }

    public int getNumberOfGames() {
        return numberOfGames;
    }

    /**
     * This method returns the addition details related to a hockey player, and
     * is added to the end of toString in the player class.
     *
     * @return super.toString + output
     */
    @Override
    public String toString() {
        String hockeyPlayer = "\nGoals: " + goals
                + "\nAssists: " + assists
                + "\nPenalty Minutes: " + penaltyMinutes
                + "\nNumber of Games: " + numberOfGames + "\n";
        return super.toString() + hockeyPlayer;
    }
}
