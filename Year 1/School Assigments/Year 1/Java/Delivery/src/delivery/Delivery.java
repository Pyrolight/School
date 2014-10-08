/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package delivery;

/**
 *
 * @author Michael
 * @since 11/11/2013
 *
 * This class will set all the inputed arguments via a constructor, do the
 * needed calculations on them and then return the relevant results.
 */
public class Delivery {

    private String fullDeliveryNumber;
    private int deliveryNumber;
    private int deliveryYear;
    private int deliveryDistance;
    private String deliverDistanceUsefulOutput;
    private double weight;
    private double fee;

    /**
     * @param deliveryYear
     * @param deliveryNumber
     * @param weight
     * @param deliveryDistance
     *
     * This constructor accepts the arguments the user provided in the main
     * method. It also does all the calculations required as well as formatting
     * the deliveryDistance variable to a more user friendly format.
     */
    public Delivery(int deliveryYear, int deliveryNumber, double weight, int deliveryDistance) {
        this.deliveryNumber = deliveryNumber;
        this.deliveryYear = deliveryYear;
        this.weight = weight;
        this.deliveryDistance = deliveryDistance;
        this.fullDeliveryNumber = Integer.toString(this.deliveryYear) + String.format("%04d", this.deliveryNumber);

        /*
         * Compare and set the fee for the various distance and weight combinations. 
         */
        if (deliveryDistance == 1 && weight < 5) {
            this.fee = 12.00;
        } else if (deliveryDistance == 1 && weight >= 5 && weight <= 20) {
            this.fee = 16.50;
        } else if (deliveryDistance == 1 && weight > 20) {
            this.fee = 22.00;
        } else if (deliveryDistance == 2 && weight < 5) {
            this.fee = 35.00;
        } else if (deliveryDistance == 2 && weight >= 5) {
            this.fee = 47.95;
        }

        if (deliveryDistance == 1) {                                            // Format deliverDistance to something nicer for the user.
            this.deliverDistanceUsefulOutput = "local";
        } else {
            this.deliverDistanceUsefulOutput = "long distance";
        }
    }

    public String getFullDeliveryNumber() {
        return fullDeliveryNumber;
    }

    public String getDeliverDistanceUsefulOutput() {
        return deliverDistanceUsefulOutput;
    }

    public double getWeight() {
        return weight;
    }

    public double getFee() {
        return fee;
    }
}
