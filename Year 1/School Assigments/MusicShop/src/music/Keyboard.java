// 5/30/2014 MF Assignment 3 Modification.  Moved to music package.
package music;

// 5/30/2014 MF Assignment 3 Modification.  Modified import for exception.
import exceptions.KeyboardInputException;
// 5/30/2014 MF Assignment 3 Modification.  Added import for Sellable and DatabaseIO.  Removed unused imports.
import interfaces.Sellable;
import javax.swing.JOptionPane;
import util.DatabaseIO;


/**
 *
 * @author bjmaclean
 */
public class Keyboard extends Instrument implements Sellable{
    
    private int numberOfKeys;
    public static final double SURCHARGE = 30.0;
    

    public Keyboard() throws KeyboardInputException {
        getDetails();
        applySurchargeToPrice();
        if (this.numberOfKeys < 60 || this.numberOfKeys > 120){
            JOptionPane.showMessageDialog(null, "Keys must be between 60-120");
            throw new KeyboardInputException();
        }
         // 6/2/2014 MF Assignment 3 Modification. Added code to write to the database.
        DatabaseIO writeToDB = new DatabaseIO();
        writeToDB.addToDatabase(this.instrumentId, Sellable.TYPE_KEYBOARD, this.brand, this.colour, 
                this.price, String.valueOf(this.numberOfKeys), "");
    
        // 5/30/2014 MF Assignment 3 Modification.  Removed unnecessary maxInstrumentID + 1.
    }

    // 5/30/2014 MF Assignment 3 Modification.  Converted string to int for instrumentId, and string to double for price, and removed instrumentType
    public Keyboard(int instrumentId, String brand, String colour, double price, String specific1) {
            super(instrumentId, brand, colour, price);
            this.numberOfKeys = Integer.parseInt(specific1);

    }
    
    // 6/2/2014 MF Assignment 3 Modification. Removed file string build.
  
    public String toString() {
        return "Keyboard\r\n"+super.toString()
                + "Number of Keys:  " + this.numberOfKeys + "\r\n";
    }
    
    // 6/2/2014 MF Assignment 3 Modification. Added number of keys to the user output.
    public void getDetails(){
         numberOfKeys = Integer.parseInt(JOptionPane.showInputDialog("Enter the number of keys.  They must be between 60 and 120 inclusive."));
    }
    
    @Override
    public double applySurchargeToPrice() {
        this.price += SURCHARGE;
        return this.price;
    }

    public int getNumberOfKeys() {
        return numberOfKeys;
    }

    public void setNumberOfKeys(int numberOfKeys) {
        this.numberOfKeys = numberOfKeys;
    }

    
}
