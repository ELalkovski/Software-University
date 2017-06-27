import java.util.ArrayList;
import java.util.Comparator;

public  class Student {

    private String name;
    private ArrayList<Double> grades;


    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public ArrayList<Double> getGrades() {
        return grades;
    }

    public void setGrades(ArrayList<Double> grades) {
        this.grades = grades;
    }

    public double getAverageGrade(ArrayList<Double> grades){
        double gradesSum = 0.0;

        for(int i = 0; i < grades.size(); i++){
            gradesSum += grades.get(i);
        }

        double averageGrade = gradesSum / grades.size();
        return averageGrade;
    }

    public static Comparator<Student> getCompByName()
    {
        Comparator comp = new Comparator<Student>(){
            @Override
            public int compare(Student s1, Student s2)
            {
                return s1.name.compareTo(s2.name);
            }
        };
        return comp;
    }

    public static Comparator<Student> getCompByAverageGrade()
    {
        Comparator comp = new Comparator<Student>(){
            @Override
            public int compare(Student s1, Student s2) {
                if(s1.getAverageGrade(s1.getGrades()) > s2.getAverageGrade(s2.getGrades())){
                    return  -1;
                }
                if(s1.getAverageGrade(s1.getGrades()) < s2.getAverageGrade(s2.getGrades())){
                    return 1;
                } else {
                    return 0;
                }
            }
        };
        return comp;
    }

}
