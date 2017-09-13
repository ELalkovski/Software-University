import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input = scan.nextLine();
        String openCase = "<upcase>";
        String closeCase = "</upcase>";

        while(input.contains(openCase)){
            int firstOccurence = input.indexOf(openCase);
            int startIndex = firstOccurence + openCase.length();
            int endIndex = input.indexOf(closeCase);
            String toBeReplaced = input.substring(startIndex, endIndex);
            String replacement = input.substring(startIndex, endIndex).toUpperCase();
            input = input.replaceFirst(toBeReplaced, replacement);
            input = input.replaceFirst(openCase, "");
            input = input.replaceFirst(closeCase, "");
        }

        System.out.println(input);
    }
}
