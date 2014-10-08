package base;

import exception.PayException;
import java.util.*;

public abstract class Employee implements Payable {

    private String name;
    private String phoneNumber;
    private double payAmount;
    public static Scanner userInput = new Scanner(System.in);
    // Used to make sure max pay is not too high.
    private final int MAXPAY = 1000;
    public static double totalPay;

    /**
     * Gets the staffs name a phone number.
     */
    public Employee() {
        System.out.println("What is the persons name?");
        this.name = userInput.nextLine();
        System.out.println("What is their phone number?");
        this.phoneNumber = userInput.nextLine();

    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getPhoneNumber() {
        return phoneNumber;
    }

    public void setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
    }

    public double getPayAmount() {
        return payAmount;
    }

    /**
     * Throws exception if pay too high.
     *
     * @param payAmount
     * @throws PayException
     */
    public void setPayAmount(double payAmount) throws PayException {
        if (payAmount > MAXPAY) {
            throw new PayException("Pay too high!");
        }
        this.payAmount = payAmount;
        totalPay += payAmount;
    }

    /**
     * output the result.
     *
     * @return
     */
    @Override
    public String toString() {
        String info = "Name: " + name
                + "\n Phone: " + phoneNumber
                + "\n Pay: " + payAmount + "\n\n";
        return info;
    }
}
