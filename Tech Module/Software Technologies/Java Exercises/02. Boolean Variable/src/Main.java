import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String word = scan.nextLine();

        boolean bool = (word.equals("True"));

        if(bool){
            System.out.println("Yes");
        } else {
            System.out.println("No");
        }
    }
}
