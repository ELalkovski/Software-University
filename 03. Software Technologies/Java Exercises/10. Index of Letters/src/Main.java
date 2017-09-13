import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String word = scanner.nextLine();
	    String alphabet = "abcdefghijklmnopqrstuvwxyz";

	    for (int i = 0; i < word.length(); i++){
	        for(int j = 0; j < alphabet.length(); j++){
	            if(word.charAt(i) == alphabet.charAt(j)){
	                System.out.printf("%s -> %d\n",word.charAt(i), j);
                }
            }
        }
    }
}
