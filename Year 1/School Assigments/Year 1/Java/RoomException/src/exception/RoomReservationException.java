package exception;

/**
 * @author Michael Fesser
 * @since 15/4/2014
 *
 * This is a basic exception class used when trying to reserve and room that is
 * booked or release a room that is not booked.
 */
public class RoomReservationException extends Exception {

    public RoomReservationException(String description) {
        super(description);
    }
}
