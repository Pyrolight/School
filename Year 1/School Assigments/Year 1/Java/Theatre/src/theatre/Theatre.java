package theatre;

import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.Scanner;

/**
 * 
 * This class will hold attributes/functionality for a theatre.  
 *
 * @author BJ, Michael Fesser
 * @since 2014-01-27
 */
public class Theatre {

    //Number of rows in the theatre
    public static final int NUMBER_OF_ROWS = 10;
    //Number of seats that are in each row
    public static final int NUMBER_OF_SEATS_IN_ROW = 15;
    private ArrayList<Row> rows = new ArrayList();                              // ArrayList to hold the rows in the theatre.
    private String theatreName;                                                 // Not currently used for output, hold the name of theatre.
    DecimalFormat df = new DecimalFormat("#.00");                               // Format the output of total of all seat sales.
    Row currentRow;                                                             // Declare the currentRow object.

    public Theatre(String theatreName) {
        this.theatreName = theatreName;
    }

    /**
     * This method prompts for row and seat number, checks to see if it is taken, it if 
     * is it alerts the user, if not, it creates the row and passes the seat to the
     * Row class.
     */
    public void reserveSeat() {
        Scanner input = new Scanner(System.in);
        int row;
        int seat;
        int arrayCounter = 0;                                                   // Used as a counter to iterate through the ArrayList.
        boolean rowExists = false;                                              // Set row exists to false.
        int arrayPosition = 0;                                                  // Set the position of the array to 0;
        //Gathering row number with validation
        do {
            System.out.print("Please select row: ");
            row = input.nextInt();
            row--;
        } while (row < 0 || row >= NUMBER_OF_ROWS);
        //Gathering seat number with validation
        do {
            System.out.print("Please select seat: ");
            seat = input.nextInt();
            seat--;
        } while (seat < 0 || seat >= NUMBER_OF_SEATS_IN_ROW);
        
        row++;                                                                  // Increase row by one for comparisons and to set the row number in the Row class.
        
        while (arrayCounter < rows.size()) {                                    // Loop to the end of the ArrayList.
            if (rows.get(arrayCounter).getRowNumber() == (row)) {               // Check to see if the user imputed row already exists at a position of the array.  
                arrayPosition = arrayCounter;                                   // Set the array position to the current ArrayList index.
                rowExists = true;                                               // If row exists set to true to skip creating of a new row.
            }
            arrayCounter++;
        }

        if (!rowExists) {                                                       // The row is not found.
            currentRow = new Row();                                             // Initialize the currentRow object.
            currentRow.setRowNumber(row);                                       // Set the row number.
            currentRow.reserveSeat(seat);                                       // Pass the seat number to the Row class.
            rows.add(currentRow);                                               // Populate the seats ArrayList.
        } else {
            rows.get(arrayPosition).reserveSeat(seat);
        }

    }

    /**
     * This method calculates the total value of seats sold and displays it.
     */
    public void showTotalValue() {
        double totalValue = 0;
        for (Row row : rows) {                                                  // Iterate over the ArrayList.
            totalValue += row.getSeatTotal();                                   // Get the total for the seats from each row and add all the rows them together.
        }
        System.out.println("The total value of seats sold is $" + df.format(totalValue));
    }

    public ArrayList<Row> getRows() {
        return rows;
    }

}
