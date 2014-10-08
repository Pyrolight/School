package taxreturn;

import java.text.DecimalFormat;

/**
 *
 * @author Michael
 * @since 13/08/2013
 * 
 * The purpose of this class is to calculate the tax liability based on income and 
 * marital status and taxes owed for the client.
 */
public class TaxReturn {

    private final String SOCIAL_SECURITY;                                       // Set to finals since they are never maniplated.
    private final String FIRST_NAME;
    private final String LAST_NAME;
    private final String ADDRESS;
    private final String CITY;
    private final String STATE;
    private final String ZIP_CODE;
    private final double INCOME;
    private final char MARITAL_STATUS;
    private double taxLiability;                                                // Maniputlated value.

    /*
    * This constructor accpets the user input and calucaltes the tax lability.
    */
    public TaxReturn(String socialSecurity, String firstName, String lastName, String address, String city, String state, String zipCode, double income, char maritalStatus) {
        this.SOCIAL_SECURITY = socialSecurity;
        this.FIRST_NAME = firstName;
        this.LAST_NAME = lastName;
        this.ADDRESS = address;
        this.CITY = city;
        this.STATE = state;
        this.ZIP_CODE = zipCode;
        this.INCOME = income;
        this.MARITAL_STATUS = maritalStatus;

        /*
        * If statements to check the income level and then check marital status to
        * calculate tax laibility.
        */
        if (this.INCOME <= 20000) {
            if (this.MARITAL_STATUS == 'S') {
                this.taxLiability = .15;
            } else if (this.MARITAL_STATUS == 'M') {
                this.taxLiability = .14;
            }
        } else if (this.INCOME >= 20001 && this.INCOME <= 50000) {
            if (this.MARITAL_STATUS == 'S') {
                this.taxLiability = .22;
            } else if (this.MARITAL_STATUS == 'M') {
                this.taxLiability = .20;
            }

        } else if (this.INCOME >= 50001) {
            if (this.MARITAL_STATUS == 'S') {
                this.taxLiability = .30;
            } else if (this.MARITAL_STATUS == 'M') {
                this.taxLiability = .28;
            }
        }
    }

    /*
    * This method displays all the user inputed information and does a calculation 
    * to find out the taxes owed.
    */
    @Override                                                                   // toString override.
    public String toString() {
        DecimalFormat money = new DecimalFormat("$0.00");
        String taxInfo = "Social Security number: " + this.SOCIAL_SECURITY
                + "\nName: " + this.FIRST_NAME + " " + this.LAST_NAME
                + "\nMarital Status: " + this.MARITAL_STATUS
                + "\nAddress : " + this.ADDRESS + " "
                + "\nCity, State, ZIP code: " + this.CITY + " " + this.STATE + " " + ZIP_CODE
                + "\nIncome: " + money.format(this.INCOME)
                + "\nTax Liability : " + this.taxLiability * 100 + "%"
                + "\nTaxes owed: " + money.format((this.INCOME * this.taxLiability));
        return taxInfo;
    }
}
