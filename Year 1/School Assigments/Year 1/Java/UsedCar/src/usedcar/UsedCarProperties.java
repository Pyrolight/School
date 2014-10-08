package usedcar;

import java.text.DecimalFormat;

/**
 *
 * @author Michael Fesser
 * @since 11/29/13
 *
 * The purpose of the class is to do all the calculations that will determine
 * the depreciation on vehicle object.
 *
 */
public class UsedCarProperties {

    private final double VEHICLE_PRICE;                                         // Final since the value is never changed.
    private final int MILEAGE;                                                  // Final since the value is never changed.
    private String transmissionType;
    private String sunroof;
    private double depreciatedVehiclePrice;

    /**
     *
     * This is the constructor for the vehicle object.
     *
     * @param vehiclePrice
     * @param mileage
     * @param transmissionType
     * @param sunroof
     */
    public UsedCarProperties(double vehiclePrice, int mileage, String transmissionType, String sunroof) {
        this.VEHICLE_PRICE = vehiclePrice;
        this.MILEAGE = mileage;
        this.transmissionType = transmissionType;
        this.sunroof = sunroof;
        this.depreciatedVehiclePrice = vehiclePrice;
        calculateCarValue();
    }

    /**
     * This method does all the calculations. It calculates depreciation based
     * on milage, transmission type and if the vehicle has a sunroof.
     *
     * I added some minor formatting to the transmissionType and sunroof strings
     * to make the output more user friendly.
     */
    private void calculateCarValue() {
        if (this.MILEAGE > 0 && this.MILEAGE < 60000) {
            this.depreciatedVehiclePrice -= this.VEHICLE_PRICE * .30;
        } else if (this.MILEAGE > 60000 && this.MILEAGE < 100000) {
            this.depreciatedVehiclePrice -= this.VEHICLE_PRICE * .35;
        } else if (this.MILEAGE > 100000 && this.MILEAGE < 200000) {
            this.depreciatedVehiclePrice -= this.VEHICLE_PRICE * .40;
        } else if (this.MILEAGE > 200000) {
            this.depreciatedVehiclePrice -= this.VEHICLE_PRICE * .50;
        }

        switch (transmissionType) {
            case "A":
                this.depreciatedVehiclePrice += this.VEHICLE_PRICE * .05;
                this.transmissionType = "Automatic";
                break;
            case "M":
                this.depreciatedVehiclePrice -= this.VEHICLE_PRICE * .05;
                this.transmissionType = "Manual";
                break;
        }

        if (sunroof.equals("Y")) {
            this.depreciatedVehiclePrice += this.VEHICLE_PRICE * .10;
            this.sunroof = "Yes";
        } else {
            this.sunroof = "No";
        }
    }

    /**
     * This method formats the results and adds them to a string which is
     * returned the main method.
     *
     * The
     *
     * @Override is error handling.
     *
     * @return
     */
    @Override
    public String toString() {
        DecimalFormat money = new DecimalFormat("$0.00");                       // Used to format VEHICLE_PRICE and depreciatedVehiclePrice to standard format.

        String vehicalInfo = "Original Vehicle Price:  " + money.format(this.VEHICLE_PRICE) + "\nMileage on Vehicle:  " + this.MILEAGE + "\nTransmission Type:  "
                + transmissionType + "\nSunroof Y/N:  " + sunroof + "\nYour vehicle is now valued at:  " + money.format(this.depreciatedVehiclePrice);
        return vehicalInfo;
    }
}
