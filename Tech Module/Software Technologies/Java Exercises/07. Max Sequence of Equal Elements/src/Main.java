import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	    int[] nums = Arrays.stream(
        new Scanner(System.in).nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
	    int start = 0;
	    int bestStart = 0;
	    int count = 1;
	    int bestCount = 0;

	    for (int i = 1; i < nums.length; i++){
            int currNum = nums[i];
            int prevNum = nums[i - 1];

            if(currNum == prevNum){
                count++;

                if(count > bestCount){
                    bestStart = start;
                    bestCount = count;
                }
            } else {
                start = i;
                count = 1;
            }
        }

        for(int i = bestStart; i < bestStart + bestCount; i++){
	        System.out.printf("%d ", nums[i]);
        }
    }
}
