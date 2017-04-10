import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static int getMostFrequentNumber(int[] nums){
        int currNum = 0;
        int frequence = 0;
        int mostFrequentNum = 0;

        for (int i = 0; i < nums.length; i++){
            currNum = nums[i];
            int count = 0;

            for (int j = i; j < nums.length; j++){
                if(currNum == nums[j]){
                    count++;
                }
            }
            if(count > frequence){
                mostFrequentNum = currNum;
                frequence = count;
            }
        }
        return mostFrequentNum;
    }


    public static void main(String[] args) {
        int[] nums = Arrays.stream(
        new Scanner(System.in).nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        System.out.println(getMostFrequentNumber(nums));
    }
}


