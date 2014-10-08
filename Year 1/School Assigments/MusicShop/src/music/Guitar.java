// 5/30/2014 MF Assignment 3 Modification.  Moved to music package.
package music;

// 5/30/2014 MF Assignment 3 Modification.  Added import for Sellable and DatabaseIO.  Removed unused imports.
import interfaces.Sellable;
import javax.swing.JOptionPane;
import util.DatabaseIO;

/**
 *
 * @author bjmaclean
 */
public class Guitar extends Instrument implements Sellable {

    int numberOfStrings;
    boolean isElectric = false;
    public static final double SURCHARGE = 50.0;

    public Guitar() {
        getDetails();
        applySurchargeToPrice();
        // 6/2/2014 MF Assignment 3 Modification. Added code to write to the database.
        DatabaseIO writeToDB = new DatabaseIO();
        writeToDB.addToDatabase(this.instrumentId, Sellable.TYPE_GUITAR, this.brand, this.colour, 
                this.price, String.valueOf(this.numberOfStrings), String.valueOf(this.isElectric));
    }

    // 5/30/2014 MF Assignment 3 Modification.  Converted string to int for instrumentId, and string to double for price, and removed instrumentType
    public Guitar(int instrumentId, String brand, String colour, double price, String specific1, String specific2) {
        super(instrumentId, brand, colour, price);
        this.numberOfStrings = Integer.parseInt(specific1);
        this.isElectric = Boolean.parseBoolean(specific2);

    }

    // 6/2/2014 MF Assignment 3 Modification. Removed file string build.

    public String toString() {
        String yesNoElectric;
        if (isElectric) {
            yesNoElectric = "Yes";
        } else {
            yesNoElectric = "No";
        }

        return "Guitar\r\n" + super.toString()
                + "Number of Strings:  " + this.numberOfStrings
                + "\nElectric:  " + yesNoElectric + "\r\n";
    }

    public void getDetails() {
        numberOfStrings = Integer.parseInt(JOptionPane.showInputDialog("Enter the number of strings"));
        int electricInt = JOptionPane.showConfirmDialog(null, "Is this electric?");
        if (electricInt == 0) {
            isElectric = true;
        }
    }

    @Override
    public double applySurchargeToPrice() {
        this.price += SURCHARGE;
        return this.price;
    }

    public boolean isElectric() {
        return isElectric;
    }

    public void setIsElectric(boolean isElectric) {
        this.isElectric = isElectric;
    }
}
