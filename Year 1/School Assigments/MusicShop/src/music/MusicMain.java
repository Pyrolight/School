// 5/30/2014 MF Assignment 3 Modification.  Moved to music package.
// 5/30/2014 MF Assignment 3 Modification.  Moved to music package.
package music;

// 5/30/2014 MF Assignment 3 Modification.  Removed unused inports
import util.DatabaseIO;
import exceptions.KeyboardInputException;
// 5/30/2014 MF Assignment 3 Modification.  Added import for Sellable.
import interfaces.Sellable;
import java.io.IOException;
import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;

/**
 * This class will be used to implement the music stored functionality for the
 * practical final of CIS1232.
 *
 * @author bjmaclean
 * @since 20131029
 */
public class MusicMain {

    // 5/30/2014 MF Assignment 3 Modification.  Made Arraylist private.
    private static ArrayList<Instrument> instruments;

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws IOException {

        //Load the file into the collection.
        // 5/30/2014 MF Assignment 3 Modification.  Now loads from the database.
        try {
            DatabaseIO loadFromDB = new DatabaseIO();
            instruments = loadFromDB.getDataFromDatabase();
        } catch (Exception e) {
            System.out.println("There was a problem loading the instruments.");
            instruments = new ArrayList<Instrument>();
        }

        char userChoice;
        do {
            userChoice = showMenu();
            switch (userChoice) {
                case 'G':
                case 'D':
                case 'K':

                    getNewInstrument(userChoice);
                    break;
                case 'V':
                    showOutput();
            }
        } while (userChoice != 'Q');
    }

    public static void showOutput() {

        String report = Sellable.INVENTORY_REPORT
                + "\n\n";

        double totalValue = 0;
        int numberOfGuitars = 0, numberOfDrums = 0, numberOfKeyboards = 0;
        for (Instrument current : instruments) {
            totalValue += current.getPrice();

            if (current instanceof Guitar) {
                numberOfGuitars += 1;
            } else if (current instanceof Drum) {
                numberOfDrums += 1;
            } else if (current instanceof Keyboard) {
                numberOfKeyboards += 1;
            }

            report += current.toString() + "\r\n";
        }
        DecimalFormat df = new DecimalFormat("$#.##");
        report += "\n" + Sellable.TOTALS
                + "\nGuitars(" + numberOfGuitars + " in inventory)\r\n"
                + "Drums(" + numberOfDrums + " in inventory)\r\n"
                + "Keyboards(" + numberOfKeyboards + " in inventory)\r\n\r\n"
                + "Total value of inventory:  " + df.format(totalValue);
        JOptionPane.showMessageDialog(null, report);
    }

    public static void getNewInstrument(char userChoice) {
        switch (userChoice) {
            case 'G':
                instruments.add(new Guitar());
                break;
            case 'D':
                instruments.add(new Drum());
                break;
            case 'K':
                try {
                    instruments.add(new Keyboard());
                } catch (KeyboardInputException ex) {
                    Logger.getLogger(MusicMain.class.getName()).log(Level.SEVERE, null, ex);
                }
                break;
            default:
                JOptionPane.showMessageDialog(null, "Invalid option");
        }
    }

    /**
     * This method will show the menu to the users.
     *
     * @return the user choice
     * @author BJ MacLean
     * @since 20131029
     */
    public static char showMenu() {
        String menu = "CIS Music Store\n"
                + "G) Add Guitar to Inventory\n"
                + "D) Add Drum to Inventory\n"
                + "K) Add Keyboard to Inventory\n"
                + "V) View All Inventory\n"
                + "Q) Quit";
        String userChoice = JOptionPane.showInputDialog(menu).toUpperCase();
        return userChoice.charAt(0);
    }
}
