import java.util.Scanner;
import java.util.TreeMap;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();
        TreeMap<String, Double> sumsByTown = new TreeMap<>();
        Scanner scanner = new Scanner(System.in);

        for(int i = 0; i < n; i++){



            String [] tokens = scanner.nextLine().split("\\|");

            String town = tokens[0].trim();
            double income = Double.parseDouble(tokens[1].trim());

            if(sumsByTown.containsKey(town)){
                sumsByTown.put(town, sumsByTown.get(town) + income);
            } else {
                sumsByTown.put(town, income);
            }

        }

        for(String key : sumsByTown.keySet()){
            System.out.println(key + " -> " + sumsByTown.get(key));
        }
    }
}
