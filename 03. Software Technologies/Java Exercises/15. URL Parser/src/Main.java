import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input = scan.nextLine();
        String protocol = "";
        String server = "";
        String resource = "";

        if(input.contains("://")){
            String[] inputTokens = input.split("://");
            protocol = inputTokens[0].trim();

            if(inputTokens[1].contains("/")){
                String[] secondTokens = inputTokens[1].split("/", 2);
                server = secondTokens[0].trim();
                resource = secondTokens[1].trim();
            } else {
                server = inputTokens[1].trim();
            }
        } else {

            if(input.contains("/")){
                String[] secondTokens = input.split("/", 2);
                server = secondTokens[0].trim();
                resource = secondTokens[1].trim();
            } else {
                server = input.trim();
            }
        }
        if(protocol != ""){
            System.out.printf("[protocol] = \"%s\"\n", protocol);
        } else {
            System.out.println("[protocol] = \"\"");
        }
            System.out.printf("[server] = \"%s\"\n", server);

        if(protocol != ""){
            System.out.printf("[resource] = \"%s\"", resource);
        } else {
            System.out.println("[resource] = \"\"");
        }
    }
}
