package assignment4;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Scanner;

/**
 *
 * @author Michael Fesser
 * @since 2/14/2014
 * 
 * This class holds all the functionality used to record, store, validate login 
 * attempts.  The class also will show a list of all login attempts.
 */
public class Login {

    private final HashMap LOGIN = new HashMap();                                // HashMap used to hold the predefined username and passwords.              
    private final ArrayList LOGINATTEMPTS = new ArrayList();                    // ArrayList used to hold all login attempts.
    Scanner input = new Scanner(System.in);

    /**
     * This method accepts the values from two arrays and uses them to populate the
     * LOGIN HashMap.
     * 
     * @param userNameArray
     * @param passwordArray 
     */
    public void loadCredentials(String[] userNameArray, String[] passwordArray) {
        for (int i = 0; i < userNameArray.length; ++i){                         // Loop to the length first array.  It is assumed both arrays have the same number of elements.    
        this.LOGIN.put(userNameArray[i], passwordArray[i]);                     // Populate each element of the HashMap.
        }
    }

    /**
     * This method gets the username and password from a user and validates it to see
     * if it matches and entry in the LOGIN HashMap.  The method also populates the 
     * LOGINATTEMPTS ArrayList with each login attempt.
     */
    public void login() {
        String username;
        String password;
        Boolean loginCorrect = false;                                           // Used to record a successful or failed login attempt value in the LOGINATTEMPTS ArrayList.  Default entry is false.

        System.out.print("\nPlease enter your username (this field is case sensitive):  ");
        username = input.next();
        System.out.print("\nPlease enter your password (this field is case sensitive):  ");
        password = input.next();
        
        if (LOGIN.containsKey(username)) {                                      // Check to see if username exists in the hashmap.  Process the password if it does.
            if (LOGIN.get(username).equals(password)) {                         // Validate the password for the specific username key.
                loginCorrect = true;                            
                LOGINATTEMPTS.add(username + "/" + password + "/" + loginCorrect);  // Populate the LOGINATTEMPTS array.
                System.out.println("\nSuccessful Login");                       
            } else {
                LOGINATTEMPTS.add(username + "/" + password + "/" + loginCorrect);  // Populate the LOGINATTEMPTS array.
                System.out.println("\nFailed Login");
            }
        } else {                                                                // If the username did not exist do this.
            LOGINATTEMPTS.add(username + "/" + password + "/" + loginCorrect);  // Populate the LOGINATTEMPTS array.
            System.out.println("\nFailed Login");
        }
    }

    /**
     * This method shows all the login attempts recorded in the LOGINATTEMPTS ArrayList.
     */
    public void loginAttempts() {
        String logins = "\n";                                                  
        for (Object loginAttempt : LOGINATTEMPTS) {                             // Iterate over the ArrayList.
            logins += loginAttempt + ", ";                                  
        }
        System.out.println(logins + "\b\b");
    }
}
