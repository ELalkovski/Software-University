import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String mail = scan.nextLine();
        String input = scan.nextLine();
        String[] mailTokens = mail.split("@");
        String username = mailTokens[0];
        String domain = mailTokens[1];
        String hiddenMail = "";

        for(int i = 0; i < username.length(); i++){
            hiddenMail += "*";
        }
        hiddenMail += "@" + domain;

        System.out.println(input.replace(mail, hiddenMail));
    }
}
