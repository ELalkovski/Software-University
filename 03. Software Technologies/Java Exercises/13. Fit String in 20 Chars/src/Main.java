import java.util.Scanner;

public class Main {


    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input = scan.nextLine();

        if(input.length() > 20){
            System.out.println(input.substring(0, 20));
        } else {

            for(int i = input.length(); i < 20; i++){
                input += "*";
            }
            System.out.println(input);
        }
    }
}
