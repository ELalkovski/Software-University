import java.util.Arrays;
import java.util.Scanner;

public class Main {


    public static int calculateDistance(Point p1, Point p2){
        double distance = (Math.sqrt(Math.pow((p1.getX() - p2.getX()), 2) + Math.pow((p1.getY() - p2.getY()), 2)));

        return (int)distance;
    }

    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        int[] firstParams = Arrays.stream(
        scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        int[] secondParams = Arrays.stream(
                scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        Point p1 = new Point(firstParams[0], firstParams[1]);
        Point p2 = new Point(secondParams[0], secondParams[1]);

        Circle c1 = new Circle(p1, firstParams[2]);
        Circle c2 = new Circle(p2, secondParams[2]);

        int distance = calculateDistance(c1.getCenter(), c2.getCenter());

        if(distance <= (c1.getRadius() + c2.getRadius())){
            System.out.println("Yes");
        } else {
            System.out.println("No");
        }

    }
}

