/**
 *
 * @author Michael Fesser
 * @Since Mar 19, 2014
 * 
 * This class defines an executive board room that is an extension of the BoardRoom class.
 */
public class ExecutiveBoardRoom extends BoardRoom {

    private int numberOfRecliners;
    private boolean coffeeMaker;

    /**
     * Calls the Room constructor.
     * 
     * @param roomNumber 
     */
    public ExecutiveBoardRoom(int roomNumber) {
        super(roomNumber);
    }

    /**
     *  Calls the BoardRoom version of this method and adds two additional options.
     */
    @Override
    public void getRoomDetailsFromUser() {
        super.getRoomDetailsFromUser();
        System.out.print("Enter number of Lazy Boy recliners: ");
        this.numberOfRecliners = input.nextInt();
        input.nextLine();
        System.out.print("Does this room have a coffee maker? (Y/N)");
        this.coffeeMaker = input.nextLine().equalsIgnoreCase("y");
    }

    public int getNumberOfRecliners() {
        return numberOfRecliners;
    }

    public boolean isCoffeeMaker() {
        return coffeeMaker;
    }

    /**
     * Calls the BoardRoom toSting and adds user chosen options to the string.
     * @return 
     */
    @Override
    public String toString() {
        return super.toString() + "Number of Recliners: " + numberOfRecliners + "\nCoffee Maker: " + coffeeMaker + "\n";
    }
}
