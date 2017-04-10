import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        int n = Integer.parseInt(scan.nextLine());
        ArrayList<Student> studentsList = new ArrayList<>();

        for(int i = 0; i < n; i++){

            String[] inputLine = scan.nextLine().split(" ");
            Student currStudent = new Student();
            currStudent.setName(inputLine[0]);
            ArrayList<Double> currGrades = new ArrayList<>();

            for(int j = 1; j < inputLine.length; j++){

                double currGrade = Double.parseDouble(inputLine[j]);
                currGrades.add(currGrade);
            }
            currStudent.setGrades(currGrades);
            studentsList.add(currStudent);
        }


        Collections.sort(studentsList, Student.getCompByAverageGrade());
        Collections.sort(studentsList, Student.getCompByName());

        for (int i = 0; i < studentsList.size(); i++){

            if(studentsList.get(i).getAverageGrade(studentsList.get(i).getGrades()) >= 5.0){

                System.out.printf("%s -> %.2f \n", studentsList.get(i).getName(), studentsList.get(i).getAverageGrade(studentsList.get(i).getGrades()));
            }
        }
    }
}
