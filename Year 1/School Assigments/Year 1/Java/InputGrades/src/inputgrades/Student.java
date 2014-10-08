package inputgrades;

import javax.swing.JOptionPane;

/**
 *
 * @author Michael Fesser
 * @since 1/20/2014
 *
 * The purpose of this class is to populate the COURSE array, return the output
 * of a position in the COURSE array and to pass the courseID, creditHours and
 * letterGrade variables to the InputGrades class.
 */
public class Student {

    private int studentID;
    private final CollegeCourse[] COURSE = new CollegeCourse[5];                // The COURSE array constant, length 5.

    public int getStudentID() {
        return studentID;
    }

    public void setStudentID(int studentID) {
        this.studentID = studentID;
    }

    /*
     * This method returns a string with the information located at an index of the 
     * COURSE array defined by the value of coursePosition.
     */
    public String getCourse(int coursePosition) {
        while (coursePosition < 0 || coursePosition > 4) {
            coursePosition = Integer.parseInt(JOptionPane.showInputDialog("That was out of bounds, please enter a postion from 0 to 4."));  // Validate the coursePosition from 0 through 4. 
        }
        String output = "Course Name: " + COURSE[coursePosition].getCourseID()
                + "\nCredit Hours: " + COURSE[coursePosition].getCreditHours()
                + "\nLetter Grade: " + COURSE[coursePosition].getLetterGrade();
        return output;
    }

    /*
     * This method is passed two arguments, the collegeCourse object and the coursePosition int.
     * The method uses setters to populate the CollegeCourse class for each collegeCourse object.  
     * It also validates the letter grade.  
     * Finally the method populates the COURSE array at the index represented by the value of
     * coursePosition.
     */
    public void setCourse(CollegeCourse collegeCourse, int coursePosition) {
        while (coursePosition < 0 || coursePosition > 4) {
            coursePosition = Integer.parseInt(JOptionPane.showInputDialog("That was out of bounds, please enter a postion from 0 to 4."));  // Validate the coursePosition from 0 through 4. 
        }
        collegeCourse.setCourseID(JOptionPane.showInputDialog("Enter course ID #" + (coursePosition + 1)));
        collegeCourse.setCreditHours(Integer.parseInt(JOptionPane.showInputDialog("What are the credit hours for the course?")));
        do {                                                                    // Grade validation.
            collegeCourse.setLetterGrade(JOptionPane.showInputDialog("What is the grade?  Please enter A, B, C, D, F").toUpperCase());
        } while (!collegeCourse.getLetterGrade().toLowerCase().substring(0, 1).equals("a")
                && !collegeCourse.getLetterGrade().toLowerCase().substring(0, 1).equals("b")
                && !collegeCourse.getLetterGrade().toLowerCase().substring(0, 1).equals("c")
                && !collegeCourse.getLetterGrade().toLowerCase().substring(0, 1).equals("d")
                && !collegeCourse.getLetterGrade().toLowerCase().substring(0, 1).equals("f"));
        COURSE[coursePosition] = collegeCourse;                                 // Populate COURSE at the index reprsented by coursePosition.
    }
}
