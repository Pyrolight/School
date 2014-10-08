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
public class Drum extends Instrument implements Sellable {

    int numberOfPieces;
    public static final double SURCHARGE = 40.0;

    public Drum() {
        getDetails();
        applySurchargeToPrice();
        
        // 6/2/2014 MF Assignment 3 Modification. Added code to write to the database.
        DatabaseIO writeToDB = new DatabaseIO();
        writeToDB.addToDatabase(this.instrumentId, Sellable.TYPE_DRUM, this.brand, this.colour, 
                this.price, String.valueOf(this.numberOfPieces), "");
    }

   // 5/30/2014 MF Assignment 3 Modification.  Converted string to int for instrumentId, and string to double for price, and removed instrumentType
    public Drum(int instrumentId, String brand, String colour, double price, String specific1) {
            super(instrumentId, brand, colour, price);
            this.numberOfPieces = Integer.parseInt(specific1);

    }
    
    // 6/2/2014 MF Assignment 3 Modification. Removed file string build.

    public void getDetails() {
        numberOfPieces = Integer.parseInt(JOptionPane.showInputDialog("Enter the number of pieces"));
    }

    public String toString() {
        
        return "Drum\r\n"+super.toString()
                + "Number of Pieces:  " + this.numberOfPieces + "\r\n";
    }

    @Override
    public double applySurchargeToPrice() {
        this.price += SURCHARGE;
        return this.price;
    }

    public int getNumberOfPieces() {
        return numberOfPieces;
    }

    public void setNumberOfPieces(int numberOfPieces) {
        this.numberOfPieces = numberOfPieces;
    }
}
