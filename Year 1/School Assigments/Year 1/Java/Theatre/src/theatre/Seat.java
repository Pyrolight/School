package theatre;

/**
 * 
 * This class will hold information about a seat.
 *
 * @author BJ, Michael Fesser
 * @since 2014-01-27
 */
public class Seat {

    private String reservedBy;                                                  // Hold the name of the customer.
    private double price;                                                       // The price of the seat.
    private boolean sold = false;                                               // The seat is set to a default of unsold.
    private int seatNumber;                                                     // used to hold the users seat choice.

    public String getReservedBy() {
        return reservedBy;
    }

    public void setReservedBy(String reservedBy) {
        this.reservedBy = reservedBy;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public boolean isSold() {
        return sold;
    }

    public void setSold(boolean sold) {
        this.sold = sold;
    }

    public int getSeatNumber() {
        return seatNumber;
    }

    public void setSeatNumber(int seatNumber) {
        this.seatNumber = seatNumber;
    }

}
