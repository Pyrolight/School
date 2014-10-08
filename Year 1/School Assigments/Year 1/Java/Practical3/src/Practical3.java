
import java.util.ArrayList;
import java.util.Scanner;

/**
 * This is the main class for the practical#3. It will control the program which
 * deals with managing players for an organization.
 *
 * @author BJM
 * @since 20140311
 */
public class Practical3 {

    /**
     * @param args the command line arguments
     */
    public static Scanner input = new Scanner(System.in);

    private static ArrayList<Player> playersEntered = new ArrayList();

    public static void main(String[] args) {
        String menu = "-----------------------------------------\n"
                + "-      CIS Sports Manager               -\n"
                + "-----------------------------------------\n"
                + "-      H-add a Hockey Player            -\n"
                + "-      G-add a Goalie                   -\n"
                + "-      SH-Show all hockey players info  -\n"
                + "-      SG-Show all goalie info          -\n"
                + "-      X-eXit                           -\n"
                + "-----------------------------------------\n"
                + "Choice-->";

        String choice;
        do {
            System.out.println(menu);
            choice = input.nextLine();
            processChoice(choice);
        } while (!choice.equalsIgnoreCase("X"));
    }

    /**
     * This method is used in the main method to process the choice entered by
     * the user.
     *
     * @param choice
     */
    private static void processChoice(String choice) {
        Player player = null;
        switch (choice.toUpperCase()) {
            case "G":
                //Add a goalie
                player = new GoalieHockeyPlayer();
                player.getInformation();
                playersEntered.add(player);
                break;
            case "H":
                //Add a hockey player.
                player = new HockeyPlayer();
                player.getInformation();
                playersEntered.add(player);
                break;
            case "SH":
                //Show players
                for (Player players : playersEntered) {
                    System.out.println(players.toString());
                }
                break;
            case "SG":
                for (Player players : playersEntered) {
                    if (players instanceof GoalieHockeyPlayer) {
                        System.out.println(players.toString());
                    } else {
                        System.out.println("There are no goalies added yet.\n");
                    }
                }

                break;
            default:
                System.out.println("Invalid choice, re-enter.");
        }
    }

}
