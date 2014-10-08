package base;

//* 5/18/2014 Removed unused imports.
import java.util.Scanner;

/**
 * @author Ryan Forrester
 * @since April 20, 2014
 *
 * Purpose creates the frame for its child classes
 */
//* 5/18/2014 MF Assignment 1 modification.  This class also holds the output string used to populate the output file.  
//* Now also implements OutputInfo.
public abstract class Employee implements Payable, OutputInfo {

    //* 5/16/2014 MF Assignment 1 modification.  Added ID field for random access and set other fields to private. 
    
    private int ID;
    private String name;
    private String phoneNum;
    private double payAmount;
    //* 5/16/2014 MF Assignment 1 modifications.  Used for max field length.
    private final int ID_LENGTH = 3;
    private final int NAME_LENGTH = 20;
    private final int PAY_AMOUNT_LENGTH = 7;
    //* 5/18/2014 MF Assignment 1 modifications.  Used for max field length for sub classes unique fields.
    private static final int MAX_FIELD_SIZE = 6;
    //* 5/18/2014 MF Assignment 1 modifications.  Used for max field length for sub classes jobType fields.
    private static final int JOB_TYPE_MAX_SIZE = 3;

    public Employee() {       
        Scanner input = new Scanner(System.in);
        //* 5/18/2014 MF Assignment 1 modifications.  Force a maximum of 20 characters.  Added "this" for consistency.
        do {
        System.out.println("What is the name of this worker?  Their name cannot be over 20 characters long.");
        this.name = input.nextLine();
        } while (this.name.length()<1 || this.name.length() > 20);
        //* 5/16/2014 MF Assignment 1 modification.  Force 10 digit phone number.  Added "this" for consistency.
        do {
            System.out.println("What is their phone number?  It must be 10 digits");
            this.phoneNum = input.nextLine();
        } while (this.phoneNum .length() != 10);
    }

    public Employee(int id, String name, String phoneNum, double pay) {
        this.ID = id;
        this.name = name;
        this.phoneNum = phoneNum;
        this.payAmount = pay;
    }

    
    public void setPayAmount(double payAmount) {
        this.payAmount = payAmount;
    }

    public double getPayAmount() {
        return payAmount;
    }

    public int getID() {
        return ID;
    }

    public void setID(int ID) {
        this.ID = ID;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getPhoneNum() {
        return phoneNum;
    }

    public void setPhoneNum(String phoneNum) {
        this.phoneNum = phoneNum;
    }

    //* 5/18/2014 MF Assignment 1 modifications.  Getters added for new fields.
    public int getMAX_FIELD_SIZE() {
        return MAX_FIELD_SIZE;
    }

    public static int getJOB_TYPE_MAX_SIZE() {
        return JOB_TYPE_MAX_SIZE;
    }

    /**
     * 5/16/2014 MF Assignment 1 modification. Comma delimited version of the
     * output string.
     *
     * @return
     */
    public String output() {

        // Format the strings.
        String IDString = String.valueOf(ID);
        String payAmountString = String.format("%.2f", payAmount);
        String fieldString = String.format(OutputInfo());

        // Pad the strings.
        while (IDString.length() < ID_LENGTH) {
            IDString = "0" + IDString;
        }
        while (name.length() < NAME_LENGTH) {
            name = " " + name;
        }
        while (payAmountString.length() < PAY_AMOUNT_LENGTH) {
            payAmountString = "0" + payAmountString;
        }

        // Create the string that will be used for a line in the output file.
        String outputInfo = IDString + "," + name + "," + phoneNum + "," + fieldString + "," + payAmountString + System.getProperty("line.separator");
        return outputInfo;
    }

    @Override
    public String toString() {
        return "-----------------------------------------------\n"
                + "Employee Name: " + this.name
                + "\nPhone Number: " + this.phoneNum
                + "\nPay: " + this.payAmount;
    }
}
