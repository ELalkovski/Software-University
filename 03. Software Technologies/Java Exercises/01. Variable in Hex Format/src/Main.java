import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String num = scan.nextLine();

        System.out.println(Integer.parseInt(num, 16));
    }
}
