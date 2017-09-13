
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String [] firstArr = scanner.nextLine().split(" ");
        String[] secondArr = scanner.nextLine().split(" ");
        String firstString = "";

        if(firstArr.length != secondArr.length){
            int shortestLength = Math.min(firstArr.length, secondArr.length);

            for(int i = 0; i < shortestLength; i++){

                if(firstArr[i].charAt(0) > secondArr[i].charAt(0)){
                    System.out.println(String.join("", firstArr));
                    System.out.println(String.join("", secondArr));
                    break;
                } else if (secondArr[i].charAt(0) > firstArr[i].charAt(0)) {
                    System.out.println(String.join("", secondArr));
                    System.out.println(String.join("", firstArr));
                    break;
                }

                if(i == shortestLength - 1){
                    if(shortestLength == firstArr.length){
                        System.out.println(String.join("", firstArr));
                        System.out.println(String.join("", secondArr));
                    } else {
                        System.out.println(String.join("", secondArr));
                        System.out.println(String.join("", firstArr));
                    }
                }
            }
        } else {

            for(int i = 0; i < firstArr.length; i++){

                if(firstArr[i].charAt(0) < secondArr[i].charAt(0)){
                    System.out.println(String.join("", firstArr));
                    System.out.println(String.join("", secondArr));
                    break;
                } else if (secondArr[i].charAt(0) < firstArr[i].charAt(0)) {
                    System.out.println(String.join("", secondArr));
                    System.out.println(String.join("", firstArr));
                    break;
                }

                if(i == firstArr.length - 1){
                    System.out.println(String.join("", secondArr));
                    System.out.println(String.join("", firstArr));

                }

            }

        }
    }
}
