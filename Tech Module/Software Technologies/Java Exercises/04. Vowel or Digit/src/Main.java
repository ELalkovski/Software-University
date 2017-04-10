import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String symbol = scan.nextLine();

        if(symbol.equals("a") || symbol.equals("e") ||symbol.equals("i") ||
                symbol.equals("o") || symbol.equals("u")){
            System.out.println("vowel");
        } else if(symbol.equals("0") || symbol.equals("1") || symbol.equals("2") ||
                symbol.equals("3") || symbol.equals("4") || symbol.equals("5") ||
                symbol.equals("6") || symbol.equals("7") || symbol.equals("8") || symbol.equals("9")){
            System.out.println("digit");
        } else {
            System.out.println("other");
        }
    }
}
