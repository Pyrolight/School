
package practical2;

/**
 *
 * @author Michael fesser
 * @since 2/16/2014
 * 
 * The class holds the fields for the ticket object.
 */
public class Ticket {
    
    private int ticketNumber;
    private String name;
    private String phoneNumber;
    // Constant for the price of the tickets.
    private final int TICKETPRICE = 2;
    // Static used to store the max number of tickets.
    public static int maxTicketNumber;
    
    /**
     * Default constructor used to set the fields.
     * @param name
     * @param phoneNumber
     * @param ticketCounter 
     */
    public Ticket(String name, String phoneNumber, int ticketCounter){
        this.name = name;
        this.phoneNumber = phoneNumber; 
        this.ticketNumber = ticketCounter;
        this.maxTicketNumber = ticketCounter;
    }
    
    /**
     * This method is used to display the tickets when called by the viewAllTickets method.
     * @return 
     */
    @Override
    public String toString(){
  String ticket = "The ticket number is " + ticketNumber + " bought by " + name + " whose phone number is " + phoneNumber;
    return ticket;
    }

    public String getName() {
        return name;
    }

    public int getTICKETPRICE() {
        return TICKETPRICE;
    }    
}
