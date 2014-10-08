package business;

import forms.LoginForm;
import java.io.BufferedInputStream;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.HashMap;

/**
 *
 * @author Michael Fesser
 * @since 5/26/2014
 *
 * The purpose of this class is to load and validate the password file.
 */
public class User {

    // Set path.
    private Path filepath = Paths.get("C:\\test\\access.txt");
    // Hashmap to store the file.
    private HashMap<String, String> validate = new HashMap();
    // Flag for login access.
    private boolean access = false;

    /**
     * This loads the file that holds the valid login credentials.
     */
    public void loadFile() {
        // Used as a delimiter.
        String delimiter = "\\*";
        String records = "";
        // Initialize the array used to temporarily store the records.
        String[] recordsArray = new String[2];
        // Try to load the data from the file.
        try {
            // Initialize the objects that will read from the file.
            InputStream inputFile = new BufferedInputStream(Files.newInputStream(filepath));
            BufferedReader readFile = new BufferedReader(new InputStreamReader(inputFile));
            System.out.println();
            records = readFile.readLine();

            // Read the file while there are records.
            while (records != null) {
                recordsArray = records.split(delimiter);
                validate.put(recordsArray[0], recordsArray[1]);
                records = readFile.readLine();
            }
            // Catch any IO errors and exit program.
        } catch (IOException io) {
            System.err.println("There was an error retrieving the file at " + filepath.toString());
            System.exit(0);
        }
    }

    /**
     * This method compares the values provided by the User against those that
     * were loaded from the file.
     *
     * @param validateLogin
     * @return 
     */
    public boolean compare(LoginForm validateLogin) {
        // Pass in the form and check to see if the User name exists.
        if (validate.containsKey(validateLogin.getUserName())) {
            // Check the password provided against that User name.
            if (validate.get(validateLogin.getUserName()).equals(validateLogin.getPassword())) {
                // Allow access.
                access = true;
            }
        }
        // Empty the HashMap.
        validate.clear();
        return access;
    }
}
