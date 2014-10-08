package util;

import interfaces.Sellable;
import music.Guitar;
import music.Drum;
import music.Keyboard;
import music.Instrument;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Michael Fesser
 * @since 5/30/2014
 *
 * This class is used to send data to and retrieve data from the music_db
 * database.
 */
public class DatabaseIO {

    // The object used for each new connection.
    private DatabaseConnection dbConnection = new DatabaseConnection();
    // Used to allow for more security when sending data to a database.
    private PreparedStatement psAuthenticate;
    private String sql;
    // The connection object.
    private Connection con;
    // ArrayList used to hold the data retrieved from the database.
    ArrayList<Instrument> instruments = new ArrayList();
    ResultSet rs = null;

    /**
     * This method retrieves data from the database.
     *
     * @return
     */
    public ArrayList<Instrument> getDataFromDatabase() {

        // Try to connect to the database.
        try {
            this.con = dbConnection.databaseConnection();
        } catch (Exception e) {
            Logger.getLogger(Instrument.class.getName()).log(Level.SEVERE, null, e);
            System.err.println("The connection to the database failed.");
        }

        // Try to generate the query.
        try {
            // The query to send.
            this.sql = "SELECT `instrument_id`, `instrument_type`, `brand`, `colour`, `price`, `type_specific_1`, `type_specific_2` FROM `music` ORDER BY `instrument_id`";
            this.psAuthenticate = this.con.prepareStatement(this.sql);
            // Send the query and get the results back.
            rs = this.psAuthenticate.executeQuery();
            int numberOfInstruments = 0;
            String brand, colour, specific1, specific2;
            int instrumentId, instrumentType;
            double price;

            // Iterate over the result set.
            while (rs.next()) {
                instrumentId = rs.getInt("instrument_id");
                // Used to set the specific instrument type.
                instrumentType = rs.getInt("instrument_type");
                brand = rs.getString("brand");
                colour = rs.getString("colour");
                price = rs.getDouble("price");
                specific1 = rs.getString("type_specific_1");
                specific2 = rs.getString("type_specific_2");
                // Used to set the id of the last instrument.
                numberOfInstruments++;

                // This will generate the correct object type based on the stored variable for the instrument type.
                switch (instrumentType) {
                    case Sellable.TYPE_GUITAR:
                        instruments.add(new Guitar(instrumentId, brand, colour, price, specific1, specific2));
                        break;
                    case Sellable.TYPE_DRUM:
                        instruments.add(new Drum(instrumentId, brand, colour, price, specific1));
                        break;
                    case Sellable.TYPE_KEYBOARD:
                        instruments.add(new Keyboard(instrumentId, brand, colour, price, specific1));
                        break;
                }
                // Set the id of the last instrument.
                Instrument.maxInstrumentId = numberOfInstruments;
            }
        } catch (Exception e) {
            Logger.getLogger(Instrument.class.getName()).log(Level.SEVERE, null, e);
            System.err.println("There was an issue with the query.");
        } finally {
            // Close the result set, psAuthenicate,  and the connection objects.
            DbUtils.close(rs, psAuthenticate, con);
        }
        return instruments;
    }

    /**
     * This method will add an instrument to the database.
     *
     * @param instrumentId
     * @param type
     * @param brand
     * @param colour
     * @param price
     * @param typeSpecificOne
     * @param typeSpecificTwo
     */
    public void addToDatabase(int instrumentId, int type, String brand, String colour, Double price, String typeSpecificOne, String typeSpecificTwo) {
        // Try to connect to the database.  
        try {
            this.con = dbConnection.databaseConnection();
        } catch (Exception e) {
            Logger.getLogger(Instrument.class.getName()).log(Level.SEVERE, null, e);
            System.err.println("The connection to the database failed.");
        }

        // Try to generate the query.
        try {
            // The query to send.
            this.sql = "INSERT INTO `music`(`instrument_id`, `instrument_type`, `brand`, `colour`, `price`, `type_specific_1`, `type_specific_2`) "
                    + "VALUES (?,?,?,?,?,?,?)";
            // Added security for the fields being sent to the database.
            this.psAuthenticate = this.con.prepareStatement(this.sql);
            this.psAuthenticate.setInt(1, instrumentId);
            this.psAuthenticate.setInt(2, type);
            this.psAuthenticate.setString(3, brand);
            this.psAuthenticate.setString(4, colour);
            this.psAuthenticate.setDouble(5, price);
            this.psAuthenticate.setString(6, typeSpecificOne);
            this.psAuthenticate.setString(7, typeSpecificTwo);
            // Run the query.
            this.psAuthenticate.executeUpdate();
        } catch (Exception e) {
            Logger.getLogger(Instrument.class.getName()).log(Level.SEVERE, null, e);
            System.err.println("There was an issue with the query.");
        } finally {
            // Close psAuthenicate,  and the connection objects.
            DbUtils.close(this.psAuthenticate, this.con);
        }
    }
}
