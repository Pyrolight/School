package business;

import base.Employee;
import exception.PayException;
import java.util.Scanner;

/**
 * @author Ryan Forrester
 * @since April 20, 2014
 *
 * Purpose child class of Employee
 */
//* 5/18/2014 MF Assignment 1 modification.  This class can also now we written to a file.

public class CarCleaner extends Employee {

    //* 5/18/2014 MF Assignment 1 modification.  Set other fields to private.
    private double clean;
    private double wax;
    private double CLEAN_RATE = 20.00;
    private double WAX_RATE = 50.00;
    //* 5/18/2014 MF Assignment 1 modification.  Used to define the worker type on file load.
    private String jobType = "2";

    public CarCleaner() {

        Scanner input = new Scanner(System.in);
        //* 5/18/2014 MF Assignment 1 modifications.  Force a maximum of three digits for the values.
        do{
        System.out.println("How many cars were cleaned?  This number cannot exceed 999");
        this.clean = input.nextDouble();
        } while (this.clean < 0 || this.clean  > 999);
        do {
        System.out.println("How many cars were waxed?  This number cannot exceed 999");
        this.wax = input.nextDouble();
        } while (this.wax < 0 || this.wax > 999);
    }

    /**
     * 5/18/2014 MF Assignment 1 modification. This constructor initializes the
     * class variables on program load.
     *
     * @param id
     * @param name
     * @param phoneNum
     * @param jobType
     * @param clean
     * @param wax
     * @param pay
     */
    public CarCleaner(int id, String name, String phoneNum, String jobType, double clean, double wax, double pay) {
        super(id, name, phoneNum, pay);
        this.jobType = jobType;
        this.clean = clean;
        this.wax = wax;
    }

    public double getClean() {
        return clean;
    }

    public double getWax() {
        return wax;
    }

    @Override
    public double calculatePay() throws PayException {
        double pay = (clean * CLEAN_RATE) + (wax * WAX_RATE);// calculate the pay
        if (pay > 1000) {
            throw (new PayException());
        }
        setPayAmount(pay);
        return pay;
    }

    /**
     * The purpose of this method is the add the class specific attributes to the file.
     * @return 
     */
    @Override
    public String OutputInfo() {
        // Format the strings.
        String cleanString = String.format("%.2f", clean);
        String waxString = String.format("%.2f", wax);

        // Pad the strings.
        while (cleanString.length() < getMAX_FIELD_SIZE()) {
            cleanString = "0" + cleanString;
        }
        while (waxString.length() < getMAX_FIELD_SIZE()) {
            waxString = "0" + waxString;
        }
        while (jobType.length() < getJOB_TYPE_MAX_SIZE()) {
            jobType = "0" + jobType;
        }

        String fields = jobType + "," + cleanString + "," + waxString;
        System.out.println(fields);
        return fields;
    }
}
