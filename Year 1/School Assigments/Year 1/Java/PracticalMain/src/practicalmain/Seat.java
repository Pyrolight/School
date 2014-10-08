package practicalmain;

/**
 * This class will hold information about a seat.
 *
 * @author BJ
 * @since 2014-01-27
 */
public class Seat {

    private String reservedBy;
    private double price;
    private boolean sold = false;

    public boolean isSold() {
        return sold;
    }

    public void setSold(boolean sold) {
        this.sold = sold;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public String getReservedBy() {
        return reservedBy;
    }

    public void setReservedBy(String reservedBy) {
        this.reservedBy = reservedBy;
    }

}
