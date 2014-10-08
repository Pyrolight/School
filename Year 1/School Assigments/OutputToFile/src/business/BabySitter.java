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
public class BabySitter extends Employee {

    //* 5/18/2014 MF Assignment 1 modification.  Set other fields to private. 
    private double hours;
    private double hourlyWage;
    private double pay;
    //* 5/18/2014 MF Assignment 1 modification.  Used to define the worker type on file load.
    private String jobType = "1";

    public BabySitter() {

        Scanner input = new Scanner(System.in);
        //* 5/18/2014 MF Assignment 1 modifications.  Force a maximum of three digits for the values.
        do {
            System.out.println("How many hours did they work?  This number cannot exceed 999");
            this.hours = input.nextDouble();
        } while (this.hours < 0 || this.hours > 999);
        do {
        System.out.println("What is the hourly wage?  This number cannot exceed 999");
        this.hourlyWage = input.nextDouble();
        } while (this.hourlyWage < 0 || this.hourlyWage > 999);
    }

    /**
     * 5/18/2014 MF Assignment 1 modification. This constructor initializes the
     * class variables on program load.
     *
     * @param id
     * @param name
     * @param phoneNum
     * @param jobType
     * @param hours
     * @param hourlyWage
     * @param pay
     */
    public BabySitter(int id, String name, String phoneNum, String jobType, double hours, double hourlyWage, double pay) {
        super(id, name, phoneNum, pay);
        this.jobType = jobType;
        this.hours = hours;
        this.hourlyWage = hourlyWage;
    }

    public void setPay(double pay) {
        this.pay = pay;
    }

    public double getPay() {
        return pay;
    }

    public double getHours() {
        return hours;
    }

    public double getHourlyWage() {
        return hourlyWage;
    }

    @Override
    public double calculatePay() throws PayException {//telling it that it might throw
        pay = hours * hourlyWage;
        if (pay > 1000) {
            throw (new PayException());
        }
        setPayAmount(pay);
        return pay;
    }

    /**
     * The purpose of this method is the add the class specific attributes to
     * the file.
     *
     * @return
     */
    @Override
    public String OutputInfo() {
        // Format the strings.
        String hoursString = String.format("%.2f", hours);
        String hourlyWageString = String.format("%.2f", hourlyWage);

        // Pad the strings.
        while (hoursString.length() < getMAX_FIELD_SIZE()) {
            hoursString = "0" + hoursString;
        }
        while (hourlyWageString.length() < getMAX_FIELD_SIZE()) {
            hourlyWageString = "0" + hourlyWageString;
        }
        while (jobType.length() < getJOB_TYPE_MAX_SIZE()) {
            jobType = "0" + jobType;
        }

        String fields = jobType + "," + hoursString + "," + hourlyWageString;
        return fields;
    }
}
