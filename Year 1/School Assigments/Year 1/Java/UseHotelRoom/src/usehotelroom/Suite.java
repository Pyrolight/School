package usehotelroom;

/**
 *
 * @author Michael Fesser
 * @since 3/9/2014
 * 
 * This class extends the HotelRoom class.  It is used to add a surcharge if the
 * room is a suite.  In this case any room can be a suite.
 */
public class Suite extends HotelRoom {
    
    // The constant for the surcharge.
    private final int SURCHARGE = 40;
    // Stores the room rate plus the surcharge.
    private final double SUITE_RATE;

    /**
     * This constructor sets a $40 surcharge for the room the user selected.
     * 
     * @param roomNumber 
     */
    public Suite(int roomNumber) {
        // call the HotelRoom constructor.
        super(roomNumber);
        //  Set the rate for the suite based on the rental rate for the room number the user selected plus $40.
        this.SUITE_RATE = super.getRENTAL_RATE() + SURCHARGE;
    }
    
    /**
     * This method returns a string for the base price of a room and the room as a suite.
     * 
     * @return roomPrice
     */
    @Override
    public String toString(){
        // Call the toString from the parent class and append the suite class toString to it.
        String roomPrice = "\n" + super.toString() +"\nThe rate for the room as a suite is $" + SUITE_RATE;     
        return roomPrice;    
    }
}
