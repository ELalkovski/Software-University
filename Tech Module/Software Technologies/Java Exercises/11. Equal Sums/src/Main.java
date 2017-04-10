import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static int getSearchedIndex(int[] nums){
        int leftSum = 0;
        int rightSum = 0;
        int index = -1;

        for(int i = 0; i < nums.length; i++){

            for(int left = 0; left < i; left++){
                leftSum += nums[left];
            }

            for(int right = i + 1; right < nums.length; right++){
                rightSum += nums[right];
            }
            if(leftSum == rightSum){

                index = i;
                break;
            } else {
                leftSum = 0;
                rightSum = 0;
            }
        }
        return index;
    }

    public static void main(String[] args) {
	    int[] nums = Arrays.stream(
        new Scanner(System.in).nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        if(getSearchedIndex(nums) != -1){
            System.out.println(getSearchedIndex(nums));
        } else {
            System.out.println("no");
        }
    }
}
