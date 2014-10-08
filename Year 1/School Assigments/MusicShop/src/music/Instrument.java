// 5/30/2014 MF Assignment 3 Modification.  Moved to music package.
package music;

// 6/2/2014 MF Assignment 3 Modification.  Removed unused imports.
import javax.swing.JOptionPane;


/**
 *
 * @author bjmaclean
 */
public abstract class Instrument {

    // 6/2/2014 MF Assignment 3 Modification.  Changed all references of color to colour in all classes.
    protected String brand, colour;
    protected double price;
    protected int instrumentId;
    public static int maxInstrumentId = 0;
    public static final String STORE_NAME = "CIS Music Store";

    public Instrument() {
        brand = JOptionPane.showInputDialog("Enter the brand");
        colour = JOptionPane.showInputDialog("Enter the colour");
        price = Double.parseDouble(JOptionPane.showInputDialog("Enter the price"));
        this.instrumentId = maxInstrumentId + 1;

    }

    // 5/30/2014 MF Assignment 3 Modification.  Converted string to int for instrumentId, and string to double for price.
    public Instrument(int instrumentId, String brand, String colour, double price) {
        this.instrumentId = instrumentId;
        this.brand = brand;
        this.colour = colour;
        this.price = price;
    }

    // 5/30/2014 MF Assignment 3 Modification.  Removed file load.
    
    // 6/2/2014 MF Assignment 3 Modification. Removed file string build.

    public String toString() {

        String premium = "";
        if (price > 400) {
            premium = " (Premium Instrument)";
        }

        return "ID:  " + this.instrumentId
                + "\nBrand:  " + this.brand
                + "\nPrice:  " + this.price + premium
                + "\nColor:  " + this.colour + "\n";
    }

    public String getBrand() {
        return brand;
    }

    public void setBrand(String brand) {
        this.brand = brand;
    }

    public String getColour() {
        return colour;
    }

    public void setColor(String colour) {
        this.colour = colour;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public int getInstrumentId() {
        return instrumentId;
    }

    public void setInstrumentId(int instrumentId) {
        this.instrumentId = instrumentId;
    }
}
