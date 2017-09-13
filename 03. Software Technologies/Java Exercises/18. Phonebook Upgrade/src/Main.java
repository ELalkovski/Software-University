import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        Map<String, String> phonebook = new TreeMap<String, String>();
        String command = scan.nextLine();

        while(!command.equals("END")){
            String[] tokens = command.split(" ");
            String action = tokens[0];

            if(action.equals("A")){

                String key = tokens[1];
                String value = tokens[2];

                if(!phonebook.containsKey(key)){
                    phonebook.put(key, value);
                } else {
                    phonebook.put(key, value);
                }
            } else if(action.equals("S")) {
                String key = tokens[1];

                if(phonebook.containsKey(key)){
                    System.out.println(key + " -> " + phonebook.get(key));
                } else {
                    System.out.printf("Contact %s does not exist.\n", key);
                }
            } else {
                for(String key : phonebook.keySet()){
                    System.out.println(key + " -> " + phonebook.get(key));
                }
            }

            command = scan.nextLine();
        }
    }
}
