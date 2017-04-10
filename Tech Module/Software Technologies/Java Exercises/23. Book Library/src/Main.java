import java.util.*;

public class Main {

    public static class Library{

        private ArrayList<Book> booksList;

        public ArrayList<Book> getBooksList() {
            return booksList;
        }

        public void setBooksList(ArrayList<Book> booksList) {
            this.booksList = booksList;
        }
    }

    public static class Book{

        private String title;
        private String author;
        private String publisher;
        private String releaseDate;
        private int isbnID;
        private double price;

        public String getTitle() {
            return title;
        }

        public void setTitle(String title) {
            this.title = title;
        }

        public String getAuthor() {
            return author;
        }

        public void setAuthor(String author) {
            this.author = author;
        }

        public String getPublisher() {
            return publisher;
        }

        public void setPublisher(String publisher) {
            this.publisher = publisher;
        }

        public String getReleaseDate() {
            return releaseDate;
        }

        public void setReleaseDate(String releaseDate) {
            this.releaseDate = releaseDate;
        }

        public int getIsbnID() {
            return isbnID;
        }

        public void setIsbnID(int isbnID) {
            this.isbnID = isbnID;
        }

        public double getPrice() {
            return price;
        }

        public void setPrice(double price) {
            this.price = price;
        }

    }

    public static <K, V extends Comparable<V>> Map<K, V> sortByValues(final Map<K, V> map) {
        Comparator<K> valueComparator =  new Comparator<K>() {
            public int compare(K k1, K k2) {
                int compare = map.get(k2).compareTo(map.get(k1));
                if (compare == 0) return 1;
                else return compare;
            }
        };
        Map<K, V> sortedByValues = new TreeMap<K, V>(valueComparator);
        sortedByValues.putAll(map);
        return sortedByValues;
    }

    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        int n = Integer.parseInt(scan.nextLine());
        Library library = new Library();
        ArrayList<Book> books = new ArrayList<>();

        for(int i = 0; i < n; i++){

            String[] inputTokens = scan.nextLine().split(" ");

            String title = inputTokens[0];
            String author = inputTokens[1];
            String publisher = inputTokens[2];
            String realeaseDate = inputTokens[3];
            int idNum = Integer.parseInt(inputTokens[4]);
            double price = Double.parseDouble(inputTokens[5]);

            Book currBook = new Book();
            currBook.setTitle(title);
            currBook.setAuthor(author);
            currBook.setPublisher(publisher);
            currBook.setReleaseDate(realeaseDate);
            currBook.setIsbnID(idNum);
            currBook.setPrice(price);

            books.add(currBook);
        }

        library.setBooksList(books);

        TreeMap<String, Double> summedPricesByAuthor = new TreeMap<>();

        for(int i = 0; i < books.size(); i++){

            if(!summedPricesByAuthor.containsKey(books.get(i).getAuthor())){

                summedPricesByAuthor.put(books.get(i).getAuthor(), books.get(i).getPrice());
            } else {
                summedPricesByAuthor.put(books.get(i).getAuthor(), summedPricesByAuthor.get(books.get(i).getAuthor()) + books.get(i).getPrice());
            }
        }



        for(String key : sortByValues(summedPricesByAuthor).keySet()){

            System.out.printf("%s -> %.2f \n", key, summedPricesByAuthor.get(key));
        }
    }
}
