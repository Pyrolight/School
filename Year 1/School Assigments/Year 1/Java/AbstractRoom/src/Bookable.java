
/**
 *
 * @author Michael Fesser
 * @since 4/7/2014
 *
 * This is an example of a basic interface. The Room class implements this
 * interface.
 */
public interface Bookable {

    /**
     * This is the an abstract version of the reserveThisRoom method in the Room
     * class.
     */
    public abstract void reserveThisRoom();

    /**
     * This is the an abstract version of the releaseThisRoom method in the Room
     * class.
     */
    public abstract void releaseThisRoom();
}
