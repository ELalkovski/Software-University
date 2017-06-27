import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int firstNum = scan.nextInt();
        int secondNum = scan.nextInt();
        int thirdNum = scan.nextInt();

        if(!checkSum(firstNum, secondNum, thirdNum) &&
                !checkSum(secondNum, thirdNum, firstNum) &&
                !checkSum(firstNum, thirdNum, secondNum)) {

            System.out.println("No");
        }
    }

    public static boolean checkSum(int firstNum, int secondNum, int sum){

        boolean isEqual = false;

        if(firstNum + secondNum != sum){
            return false;
        } else {

            if(firstNum <= secondNum){

                System.out.printf("%d + %d = %d\n", firstNum, secondNum, sum);
            } else {
                System.out.printf("%d + %d = %d\n", secondNum, firstNum, sum);
            }

            return true;
        }

    }
}
