import java.util.Random;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        String[] phrases = {"Excellent product.", "Such a great product.", "I always use that product.",
        "Best product of its category.", "Exceptional product.", "I can’t live without this product."};

        String[] events = {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
        "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};

        String[] authors = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};

        String[] cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

        Random random = new Random();

        Scanner scan = new Scanner(System.in);
        int n = Integer.parseInt(scan.nextLine());

        for(int i = 0; i < n; i++){
            int phraseIndex = random.nextInt(phrases.length);
            int eventIndex = random.nextInt(events.length);
            int authorIndex = random.nextInt(authors.length);
            int cityIndex = random.nextInt(cities.length);

            System.out.printf("%s %s %s - %s \n", phrases[phraseIndex], events[eventIndex],
                    authors[authorIndex], cities[cityIndex]);
        }
    }
}
