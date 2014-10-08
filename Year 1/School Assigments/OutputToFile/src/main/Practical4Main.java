package main;

import base.Employee;
import business.BabySitter;
import business.CarCleaner;
import business.YardWorker;
import exception.PayException;
import java.io.BufferedInputStream;
import java.io.BufferedOutputStream;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.OutputStreamWriter;
import java.nio.ByteBuffer;
import java.nio.channels.FileChannel;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import static java.nio.file.StandardOpenOption.*;
import java.util.ArrayList;
import java.util.Scanner;

public class Practical4Main {

    /**
     * This is the main method for the practical#4 for CIS1232.
     *
     * @author: CIS1232
     * @since: 2014-04-15
     *
     * @param args the command line arguments
     */
    /**
     * @author Ryan Forrester
     * @since April 20, 2014
     *
     * Purpose This class is designed to use the employee class and all its
     * child classes
     */
    //* 5/16/2014 MF Assignment 1 modification.  This program is to be modified to 
    //* allow the employee objects to be written and read from a Random access file.  
    //* Currently the entries are stored sequentially but designed to be accessed
    //* randomly should the ability to access any specific record be required.
    public static Scanner input = new Scanner(System.in);

    //* 5/16/2014 MF Assignment 1 modification.  Add a path for the file.
    static Path filepath = Paths.get("C:\\test\\employees.txt");

    //* 5/16/2014 MF Assignment 1 modification.  Used for ID generation.
    static int nextRecord;

    //* 5/16/2014 MF Assignment 1 modification.  Moved for object creation.
    static Employee newEmployee = null;

    //* 5/18/2014 MF Assignment 1 modification.  Moved to class.
    static ArrayList<Employee> allWorkers = new ArrayList();

    //* 5/18/2014 MF Assignment 1 modification.  Allow the program to write to a file.
    static OutputStream output;
    static BufferedWriter writer = null;

    //This is the menu to be displayed to the user.
    public static final String menu
            = "\n------------------------------------------------------------\n"
            + "Add employees using one of the following options\n"
            + "1) add a babysitter\n"
            + "2) add a yard worker\n"
            + "3) add a car cleaner\n"
            + "X) exit and show details\nchoice:";

    public static void main(String[] args) {

        boolean finished = false;
        //* 5/18/2014 MF Assignment 1 modification.  The following variables and arrays allow the user to chose and ID for the worker.
        Integer[] ids = new Integer[1000];
        Boolean[] usedIDs = new Boolean[1000];

        //* 5/16/2014 MF Assignment 1 modification.  Reads records into the program from a file or creates a default random access file.
        if (Files.exists(filepath)) {
            loadFile();
        } else {
            createFile();
        }

        //************************************************************************
        // Allow the user to add as many employees as they desire.  The can indicate they
        // are finished by entering x.
        //************************************************************************
        while (!finished) {

            System.out.println(menu);
            String userOption = input.nextLine();

            try {
                switch (userOption) {
                    case "1":  //Add new babysitter

                        newEmployee = new BabySitter();
                        newEmployee.setPayAmount(newEmployee.calculatePay());
                        break;
                    case "2":  //Add new yard worker

                        newEmployee = new YardWorker();
                        newEmployee.setPayAmount(newEmployee.calculatePay());
                        break;
                    case "3":  //Add new car cleaner

                        newEmployee = new CarCleaner();
                        newEmployee.setPayAmount(newEmployee.calculatePay());
                        break;
                    case "X":
                    case "x":

                        System.out.println("Finished adding employees");
                        finished = true;
                        break;
                    default:
                        System.out.println("Invalid option");
                }

                //If not finished then add the new employee to the List of employees.
                if (!finished) {
                    String unusedID = "The available IDs are :\n";
                    int userChoice = 0;

                    //* 5/18/2014 MF Assignment 1 modification.  Fills the arrays.
                    for (int i = 0; i < ids.length; i++) {
                        ids[i] = i + 1;
                        usedIDs[i] = false;
                    }
                    //* 5/18/2014 MF Assignment 1 modification.  Checks for the used IDs.
                    for (Employee idCheck : allWorkers) {

                        for (Integer check : ids) {
                            if (idCheck.getID() == check) {
                                //* 5/18/2014 MF Assignment 1 modification.  -1 used frequently to adjust IDs to array indexes.
                                usedIDs[check - 1] = true;
                            }
                        }
                    }
                    //* 5/18/2014 MF Assignment 1 modification.  Format the output for the available ID display.
                    for (int j = 0; j < ids.length; j++) {
                        if (usedIDs[j] == false) {
                            if ((j + 1) % 50 == 0) {
                                unusedID += ids[j] + "\n";
                            } else {
                                unusedID += ids[j] + ", ";
                            }
                        }
                    }
                    //* 5/18/2014 MF Assignment 1 modification.  Set default ID.
                    int userID = 0;

                    //* 5/18/2014 MF Assignment 1 modification.  Loop until the ID is valid
                    do {
                        try {
                            String idMenu = "\n------------------------------------------------------------\n"
                                    + "Please enter an ID for the worker or view available IDs.\n"
                                    + "1) Enter ID\n"
                                    + "2) View available IDs \n";
                            System.out.println(idMenu);
                            userChoice = Integer.parseInt(input.nextLine());

                            //* 5/18/2014 MF Assignment 1 modification.  Give options to create or view and ID.
                            switch (userChoice) {
                                case 1:
                                    System.out.println("Enter the ID, it must be between 1 and 999 inclusive.");
                                    userID = Integer.parseInt(input.nextLine());
                                    if (userID < 1 || userID > 999) {
                                        System.out.println("That number was out of the available range.");
                                    } else if (usedIDs[userID - 1] == true) {
                                        System.out.println("That ID is already in use.");
                                    } else {
                                        newEmployee.setID(userID);
                                    }
                                    break;
                                case 2:
                                    System.out.println(unusedID);
                                    break;
                                default:
                                    System.out.println("The options are 1 and 2");
                                    break;
                            }
                        } catch (NumberFormatException ne) {
                            System.out.println("The ID needs to be a number");
                        }
                    } while (userID < 1 || userID > 999 || usedIDs[userID - 1] == true);

                    allWorkers.add(newEmployee);
                    //* 5/16/2014 MF Assignment 1 modification.  Allow a file to be created, appended and written to.
                    fileWrite(newEmployee.output(), userID);
                }
            } catch (PayException pe) //Catch the PayException
            {
                System.out.println("Error:" + pe.getMessage());
            } catch (Exception e) {
                System.out.println("Error: There was a data entry problem.");
            } //* 5/16/2014 MF Assignment 1 modification.  Close the file regardless of errors.

        }

        //After all employees are added, display their information back to the user.  
        for (Employee nextEmployee : allWorkers) {
            System.out.println(nextEmployee);
        }
        double totalPay = 0.0;
        for (Employee nextEmployee : allWorkers) {
            totalPay += nextEmployee.getPayAmount();
        }
        System.out.println("The total amount owed is: " + totalPay);
    }

    /**
     * 5/16/2014 MF Assignment 1 modification (new method). This method writes
     * to the file.  Will not annotate comments within new methods with date/initials.
     *
     * @param employeeInfo
     * @throws IOException
     */
    public static void fileWrite(String employeeInfo, int userID) throws IOException {
        // Used to define the length of each line.
        final int RECSIZE = employeeInfo.length();
        byte[] data = employeeInfo.getBytes();
        // Will store the file in bytes.
        ByteBuffer buffer = ByteBuffer.wrap(data);
        // Declare the fileChannel object.
        FileChannel fc = null;

        // Try to create a fileChannel and write to the file.
        try {
            fc = (FileChannel) Files.newByteChannel(filepath, READ, WRITE);
            // This defines while line of the file to write to by using the length of each line multiplied by the userID as the "line number".
            fc.position((userID - 1) * RECSIZE);
            // Write to file.
            fc.write(buffer);
            // Close file.
            fc.close();
        } catch (IOException io) {
            System.out.println("Could not write to the file.");
        // Close the file even if the program has an exception.
        } finally {
            try {
                fc.close();
            } catch (IOException io) {
                System.out.println("Error closing the file");
            }
        }
    }

    /**
     * 5/16/2014 MF Assignment 1 modification (new method).  This method loads a file.
     */
    public static void loadFile() {
        // Used as a delimiter.
        String delimiter = ",";
        String records = "";
        // Initialize the array used to temporarily store the records.
        String[] recordsArray = new String[7];
        // Used as a key to search the file.  Will be unique.
        int ID;
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
                ID = Integer.parseInt(recordsArray[0]);
                // Enter record info while the ID is a valid number.
                if (ID != 0) {
                    // Populate the Babysitter class.
                    if (Integer.parseInt(recordsArray[3]) == 1) {
                        newEmployee = new BabySitter(ID, recordsArray[1], recordsArray[2], recordsArray[3], Double.parseDouble(recordsArray[4]), Double.parseDouble(recordsArray[5]), Double.parseDouble(recordsArray[6]));
                    }
                    // Populate the CarCealer class.
                    if (Integer.parseInt(recordsArray[3]) == 2) {
                        newEmployee = new CarCleaner(ID, recordsArray[1], recordsArray[2], recordsArray[3], Double.parseDouble(recordsArray[4]), Double.parseDouble(recordsArray[5]), Double.parseDouble(recordsArray[6]));
                    }
                    // Populate the YardWorker class.  This contains one less value that was stored in the file.
                    if (Integer.parseInt(recordsArray[3]) == 3) {
                        newEmployee = new YardWorker(ID, recordsArray[1], recordsArray[2], recordsArray[3], Double.parseDouble(recordsArray[4]), Double.parseDouble(recordsArray[6]));
                    }
                    // Populate the ArrayList
                    allWorkers.add(newEmployee);
                    nextRecord = ID;
                }
                records = readFile.readLine();
            }
        // This does a simple check to see if the file is in read/write mode.  It warns the user if it is not.  The file should have to be read from at least once if the file exists already from a previous session.
        } catch (IOException io) {
            System.err.println("The file at " + filepath.toString() + " has restricted access.  Please check with your Administrator.");
            System.err.println("Do you with to continue Y/N?  No information will be saved.");
            String choice = input.nextLine();
            if (choice.toUpperCase().charAt(0) == 'N') {
                System.exit(0);
            }
        }
    }

    /**
     * 5/16/2014 MF Assignment 1 modification (new method).  This method creates the default file.
     */
    public static void createFile() {
        //* Create the default string.  There are some based assumptions.
        //* 999 employees max, 20 characters for a name, area code for phonenumber, the job type can be only three digits, specific values in the object can't exceed 999, pay cant be over $1000, only 100 employees.
        final int FILE_LENGTH = 1000;
        // The string used to build the random access file.
        String file = "000,xxxxxxxxxxxxxxxxxxxx,0000000000,000,000.00,000.00,0000.00" + System.getProperty("line.separator");
        byte[] data = file.getBytes();
        ByteBuffer buffer = ByteBuffer.wrap(data);

        //* This is where the file is actually created.
        try {
            // Initialize the objects to create the file.
            output = new BufferedOutputStream(Files.newOutputStream(filepath, CREATE));
            writer = new BufferedWriter(new OutputStreamWriter(output));
            // Write to the file the required number of lines.
            for (int count = 0; count < FILE_LENGTH; count++) {
                writer.write(file, 0, file.length());
            }
            // Close the file.
            writer.close();
        } catch (IOException io) {
            System.out.println("The file could not be created");
        // Close the file even if the program has an exception.
        } finally {
            try {
                writer.close();
            } catch (IOException io) {
                System.out.println("Error closing the file");
            }
        }
    }
}
