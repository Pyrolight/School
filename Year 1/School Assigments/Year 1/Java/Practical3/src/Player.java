
/**
 * This class contains the attributes/methods associated with a player. The
 * player class is associated with sports but contains basic biographical data.
 *
 * @author BJ
 * @since 20140311
 */
public class Player {

    String firstName, lastName, teamName;
    int number, age;

    /**
     * This custom constructor is used to create and populate the attributes of
     * the Player class.
     *
     * @param firstName
     * @param lastName
     * @param teamName
     * @param number
     * @param age
     *
     * @author BJM
     * @since 20140311
     */
    public Player(String firstName, String lastName, String teamName, int number, int age) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.teamName = teamName;
        this.number = number;
        this.age = age;
    }

    public Player() {
    }

    /**
     * This method will load the temp attributes by prompting the user for the
     * information. Modified to public to allow inheritance.
     *
     */
    public void getInformation() {
        System.out.println("Enter first name:");
        firstName = Practical3.input.nextLine();
        System.out.println("Enter last name:");
        lastName = Practical3.input.nextLine();
        System.out.println("Enter team name:");
        teamName = Practical3.input.nextLine();
        System.out.println("Enter player number:");
        number = Integer.parseInt(Practical3.input.nextLine());
        System.out.println("Enter player age:");
        age = Integer.parseInt(Practical3.input.nextLine());
    }

    public String getFirstName() {
        return firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public String getTeamName() {
        return teamName;
    }

    public int getNumber() {
        return number;
    }

    public int getAge() {
        return age;
    }

    /**
     * This method returns a string holding the basic player info.
     *
     * @return output
     */
    public String toString() {
        String output = "\nHockey Player Information"
                + "\n\nName: " + firstName + " " + lastName
                + "\nTeam Name: " + teamName
                + "\nNumber: " + number
                + "\nAge: " + age;
        return output;
    }

}
