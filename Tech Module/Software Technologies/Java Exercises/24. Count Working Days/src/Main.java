import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.LocalDate;
import java.util.Calendar;
import java.util.Date;
import java.util.GregorianCalendar;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);


        SimpleDateFormat format = new SimpleDateFormat("dd-MM-yyyy");
        Date firstDate = null;
        Date secondDate = null;

        String inputOne = scan.nextLine();
        String inputTwo = scan.nextLine();
        try{
            firstDate = format.parse(inputOne);
            secondDate = format.parse(inputTwo);
        } catch (ParseException e){
            System.out.println("Sorry, try again");
        }

        GregorianCalendar cal = new GregorianCalendar();
        cal.setTime(firstDate);

        int workingDays = 0;

        while(!cal.getTime().after(secondDate)){

        }


    }
}
