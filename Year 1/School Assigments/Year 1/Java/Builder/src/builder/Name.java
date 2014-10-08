package builder;

/**
 *
 * @author Michael Fesser
 * @since 12/08/2013
 *
 * The purpose of this class is the create three StringBuilder objects:
 * entireName, lastFirst and signature and populate them with the firstName,
 * middleName and lastName objects.
 */
public class Name {

    private StringBuilder firstName = new StringBuilder("default");
    private StringBuilder middleName = new StringBuilder("default");
    private StringBuilder lastName = new StringBuilder("default");
    private StringBuilder entireName = null;
    private StringBuilder lastFirst = null;
    private StringBuilder signature = null;

    /*
     * Class constructor accepts and sets the firstName, middleName and lastName objects and calls the
     * setters for each as per instructions.
     */
    public Name(StringBuilder firstName, StringBuilder middleName, StringBuilder lastName) {
        /*
        * This will set the variables in the constructor once and make a single call 
        * to the manipulateStringBuilder method.  Conversion to string since .equals by itself
        * complained.
        */
        if (this.firstName.toString().equals("default") && this.middleName.toString().equals("default") && this.lastName.toString().equals("default")){
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            manipulateStringBuilder();    
        }
        
        /*
        * These if statements should only call the manipulateStringBuilder method when 
        * a name changes.  It will still call it each time the setter is called, but it 
        * limits the number of times it will be called.
        */
        if (!this.firstName.equals(firstName)) {
            setFirstName(firstName);
        } else if (!this.middleName.equals(middleName)) {
            setMiddleName(middleName);
        } else if (!this.lastName.equals(lastName)) {
            setLastName(lastName);
        }
    }

    /*
     * Sets firstName and calls the manipulateStringBuilder method that builds the 
     * entireName, lastFirst and signaute objects.
     */
    public void setFirstName(StringBuilder firstName) {
        this.firstName = firstName;
        manipulateStringBuilder();
    }

    /*
     * Sets middleName and calls the manipulateStringBuilder method that builds the 
     * entireName, lastFirst and signaute objects.
     */
    public void setMiddleName(StringBuilder middleName) {
        this.middleName = middleName;
        manipulateStringBuilder();
    }

    /*
     * Sets lastName and calls the manipulateStringBuilder method that builds the 
     * entireName, lastFirst and signaute objects.
     */
    public void setLastName(StringBuilder lastName) {
        this.lastName = lastName;
        manipulateStringBuilder();
    }

    /*
     * return the entireName Object.
     */
    public StringBuilder getEntireName() {
        return entireName;
    }

    /*
     * return the lastFirst Object.
     */
    public StringBuilder getLastFirst() {
        return lastFirst;
    }

    /*
     * return the signature Object.
     */
    public StringBuilder getSignature() {
        return signature;
    }

    /*
     * This method builds the three StringBuilder objects entireName, lastFirst and signature
     * and sets them.
     */
    public void manipulateStringBuilder() {
        this.entireName = new StringBuilder().append(this.firstName).append(" ").append(this.middleName).append(" ").append(this.lastName);
        this.lastFirst = new StringBuilder().append(this.lastName).append(", ").append(this.firstName);
        this.signature = new StringBuilder().append(this.firstName).append(" ").append(middleName.substring(0, 1)).append(". ").append(lastName);
    }
}
