import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        StringBuilder sb = new StringBuilder();
	    String input = scan.nextLine();
        int length = input.length();

	    for(int i = length - 1; i >= 0; i--){
	        sb.append(input.charAt(i));
        }
        System.out.println(sb);
    }
}
