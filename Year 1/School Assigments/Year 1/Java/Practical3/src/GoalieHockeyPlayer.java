
import java.text.DecimalFormat;

/**
 *
 * @author mfesser
 * @since 3/31/2014
 *
 * This class holds the details for a goalie and extends the HockeyPlayer class.
 */
public class GoalieHockeyPlayer extends HockeyPlayer {

    private double goalsScoredAgainst;
    private double goalsAgainst;
    // Used for some basic formatting
    DecimalFormat df = new DecimalFormat("0.00");

    /**
     * This method is the overridden version of the same method in the
     * HockeyPlayer class. It sets the specific details for a goalie.
     */
    @Override
    public void getInformation() {
        super.getInformation();
        System.out.println("Enter the number of goals scored against the goalie:");
        goalsScoredAgainst = Double.parseDouble(Practical3.input.nextLine());
        // Call the method to calculate the goals against.
        goalsAgainst();
    }

    /**
     * This method calculates the goals against.
     */
    public void goalsAgainst() {
        // Call the method getNumberOfGames() to use in the calculation.
        this.goalsAgainst = this.goalsScoredAgainst / super.getNumberOfGames();
    }

    /**
     * This method returns the addition details related to a goalie, and is
     * added to the end of toString in the HockeyPlayer class.
     *
     * @return super.toString + goalie
     */
    @Override
    public String toString() {
        String goalie = "Goals Against Average: " + df.format(goalsAgainst) + "\n";
        return super.toString() + goalie;
    }

}
