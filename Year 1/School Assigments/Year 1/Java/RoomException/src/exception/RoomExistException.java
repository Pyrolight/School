package exception;

/**
 *
 * @author Michael Fesser
 * @since 15/4/2014
 *
 * This is a basic exception class used when trying to reserve or release a room
 * does not exist.
 */
public class RoomExistException extends Exception {

    public RoomExistException(String description) {
        super(description);
    }
}
