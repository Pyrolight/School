/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
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

public class YardWorker extends Employee {

    //* 5/18/2014 MF Assignment 1 modification.  Set other fields to private.
    private double grass;
    private double RATE = 40.00;
    //* 5/18/2014 MF Assignment 1 modification.  Used to define the worker type on file load.
    private String jobType = "3";

    public YardWorker() {

        Scanner input = new Scanner(System.in);
        //* 5/18/2014 MF Assignment 1 modifications.  Force a maximum of three digits for the values.
        do{
        System.out.println("How many times have they cut the grass?  This number cannot exceed 999");
        this.grass = input.nextDouble();
        } while (this.grass < 0 || this.grass > 999);
    }

    /**
     * 5/18/2014 MF Assignment 1 modification. This constructor initializes the
     * class variables on program load.
     *
     * @param id
     * @param name
     * @param phoneNum
     * @param jobType
     * @param grass
     * @param pay
     */
    public YardWorker(int id, String name, String phoneNum, String jobType, double grass, double pay) {
        super(id, name, phoneNum, pay);
        this.jobType = jobType;
        this.grass = grass;
    }

    public double getGrass() {
        return grass;
    }

    @Override
    public double calculatePay() throws PayException {
        double pay = grass * RATE;
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
        String grassString = String.format("%.2f", grass);
        String placeHolder = String.format("000000");

        // Pad the Strings.
        while (grassString.length() < getMAX_FIELD_SIZE()) {
            grassString = "0" + grassString;
        }
        while (jobType.length() < getJOB_TYPE_MAX_SIZE()) {
            jobType = "0" + jobType;
        }

        String fields = jobType + "," + grassString + "," + placeHolder;
        return fields;
    }
}
