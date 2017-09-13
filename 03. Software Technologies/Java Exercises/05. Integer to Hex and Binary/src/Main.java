import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int num = scan.nextInt();
        System.out.println(Integer.toHexString(num).toUpperCase());
        System.out.println(Integer.toBinaryString(num).toUpperCase());
    }
}
