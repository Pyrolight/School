package inputgrades;

/**
 *
 * @author Michael
 * @since 1/20/2014
 * 
 * This class holds the values for each collegeCourse object.
 */
public class CollegeCourse {
    
    private String courseID = "Nothing Entered";                                // Default value for error handling.
    private int creditHours = 0;                                                // Default value for error handling.
    private String letterGrade = "Nothing Entered";                             // Default value for error handling.

    public String getCourseID() {
        return courseID;
    }

    public void setCourseID(String courseID) {
        this.courseID = courseID;
    }

    public int getCreditHours() {
        return creditHours;
    }

    public void setCreditHours(int creditHours) {
        this.creditHours = creditHours;
    }

    public String getLetterGrade() {
        return letterGrade;
    }

    public void setLetterGrade(String letterGrade) {
        this.letterGrade = letterGrade;
    }   
}
