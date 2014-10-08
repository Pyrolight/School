
package practical2;

import java.util.*;


/**
 *
 * @author Michael fesser
 * @since 2/16/2014
 * 
 * The purpose of this class is to create a 50/50 draw for a hockey team.
 */
public class Practical2 {

    // Create the Arraylist to hold the ticket objects.
    public static ArrayList<Ticket> tickets = new ArrayList();
    // Used to get user input.
    public static Scanner input = new Scanner(System.in);
    // Used to count the number of tickets sold. I could have used the indexOf but I didn't want to make myself crazy.
    public static int ticketCounter = 1;

    
    /**
     * The main method accepts the user input in a menu and then calls 3 methods to 
     * do the programs requirements.
     * 
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        boolean finished = false;

        String prompt = "\nEnter menu choice:"
                + "\n1) Purchase a ticket"
                + "\n2) View all tickets"
                + "\n3) Pick the winner"
                + "\n4) Exit";
        String userChoice;
        // run until the user chooses to quit.
        do {
            System.out.println(prompt);
            userChoice = input.nextLine().toUpperCase();

            switch (userChoice) {
                case "1":
                    // Call the method that creates the tickets.
                    purchaseATicket();
                    break;
                case "2":
                    // Call the method that views all tickets.
                    viewAllTickets();
                    break;
                case "3":
                    // Call the method that picks the winner.
                    pickTheWinner();
                    break;
                case "4":
                    finished = true;
                    break;
                default:
                    System.out.println("Invalid choice!");
            }
        // quits the program.
        } while (!finished);
    }

    /**
     * This method creates the ticket object, passes the name, phone number and ticket 
     * number to it.  It also adds the object to the ArrayList.
     */
    public static void purchaseATicket() {
        String name;
        String phoneNumber; 
        
        System.out.println("What is your name?");
        name = input.nextLine();
        System.out.println("What is your phone number?");
        phoneNumber = input.nextLine();        
        // Create the object.
        Ticket ticket = new Ticket(name, phoneNumber, ticketCounter);
        // Add to the ArrayList
        tickets.add(ticket);
        ticketCounter++;  
    }
    
    /**
     * This method shows the total number of tickets.
     */
    public static void viewAllTickets(){
        // Set the string to null.
        String ticketsSold = "";
        // Loop through the number of objects in the array.
        for (int i = 0; i < tickets.size(); i++){
        // Add each ticket object to the string.    
        ticketsSold += tickets.get(i).toString() +"\n";
        System.out.print(ticketsSold);
        }
    
    }
    
    /**
     * This method does the draw.  It is based on the total number of tickets sold 
     * times the price divided by two.
     */
    public static void pickTheWinner(){
    // generate a random number.
    Random r = new Random();
    int randomNumberToMaxTickets = r.nextInt(tickets.size());  
    // display the winner.
    System.out.println("The winner of $"+(Ticket.maxTicketNumber *tickets.get(0).getTICKETPRICE() /2) + " is " + tickets.get(randomNumberToMaxTickets).getName());
    }
}
