package inputgrades;

import javax.swing.JOptionPane;

/**
 *
 * @author Michael Fesser
 * @since 1/20/2014
 * 
 * The purpose of this project is to allow a teacher to input for 10 students:  A student ID, a course ID, 
 * the course weight and the grade for the course.
 */
public class InputGrades {

    public static final Student[] STUDENTS = new Student[10];                   // The STUDENTS array constant, length 10.  
    public static final int NUMBER_OF_COURSES = 5;                              // Consant matching COURSE array size.

    /**
     * @author Michael Fesser
     * @since 1/20/2014
     * 
     * The purpose of the main method is to allow the input of the student ID, the creation
     * of both the student and collegeCourse objects and to and to pass the collegeCourse object to 
     * the student class where it is used to populate the COURSE array.
     * 
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int counter = 1;                                                        // Genertic counter used to allow more freindly input text.
        Student student;                                                        // Declate the sutdent object. 
        for (int index = 0; index < STUDENTS.length; index++) {                 // Loop through the whole STUDENTS array.
            int coursePosition = 0;                                             // Set coursePostion to 0 for each loop through STUDENTS array.
            student = new Student();                                            // Initialize the student object.
            student.setStudentID(Integer.parseInt(JOptionPane.showInputDialog(null, "Enter ID for student #" + counter)));
            CollegeCourse collegeCourse;                                        // Declare the collegeCourse object.
            while (coursePosition < NUMBER_OF_COURSES) {     
                collegeCourse = new CollegeCourse();                            // Initialize the collegeCourse object.
                student.setCourse(collegeCourse, coursePosition);               // Pass both coullegeCourse and coursePosition to the the Student class.
                coursePosition += 1;               
            }
            counter++;      
            STUDENTS[index] = student;                                          // Populate each location in the STUDENTS array.
        }    
    }
}
