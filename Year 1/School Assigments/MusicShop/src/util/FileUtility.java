package util;


import java.io.BufferedInputStream;
import java.io.BufferedOutputStream;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.Reader;
import java.nio.file.FileSystem;
import java.nio.file.FileSystems;
import java.nio.file.Files;
import java.nio.file.NoSuchFileException;
import java.nio.file.Path;
import java.nio.file.StandardOpenOption;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 * This class will hold functionality associated with file access.
 *
 * @author bjmaclean
 */
public class FileUtility {

    public static final String SYSTEM_FILE_NAME = "c:\\music\\output.txt";

    public static BufferedReader open() {
        FileSystem fs = FileSystems.getDefault();
        Path path = fs.getPath(SYSTEM_FILE_NAME);

        BufferedReader reader = null; //new BufferedReader(Files.newInputStream(path, StandardOpenOption.READ));
        try {
            InputStream buffer = new BufferedInputStream(Files.newInputStream(path, StandardOpenOption.READ));
            reader = new BufferedReader(new InputStreamReader(buffer));
        } catch (IOException ex) {
            Logger.getLogger(FileUtility.class.getName()).log(Level.SEVERE, null, ex);
        }
        return reader;
    }

    public static String readLine(BufferedReader buffer) throws IOException {
   
            return buffer.readLine();
   
    }
    
    public static void close(BufferedReader buffer){
        try {
            buffer.close();
        } catch (IOException ex) {
            Logger.getLogger(FileUtility.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    public static void appendToFile(String pathLocation, String outputToWrite) {
        FileSystem fs = FileSystems.getDefault();
        Path path = fs.getPath(pathLocation);

        try {
            OutputStream buffer;
            buffer = new BufferedOutputStream(Files.newOutputStream(path, StandardOpenOption.APPEND));
            byte[] data = outputToWrite.getBytes();
            buffer.write(data);
            buffer.close();
        } catch (NoSuchFileException ex) {
            OutputStream buffer;
            try {
                buffer = new BufferedOutputStream(Files.newOutputStream(path, StandardOpenOption.CREATE));
                byte[] data = outputToWrite.getBytes();
                buffer.write(Config.FILE_LAYOUT.getBytes());
                buffer.write(data);
                buffer.close();
            } catch (IOException ex1) {
                Logger.getLogger(FileUtility.class.getName()).log(Level.SEVERE, null, ex1);
            }

        } catch (IOException ex1) {
            Logger.getLogger(FileUtility.class.getName()).log(Level.SEVERE, null, ex1);
        }

    }
}
