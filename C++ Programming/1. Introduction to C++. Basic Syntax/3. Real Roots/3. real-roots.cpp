#include <iostream>
#include <cmath>
using namespace std;

int main ()
{
    /* This program reads the coefficients a, b and c of a quadratic equation a*x2 + b*x + c = 0
    and calculates and prints its real roots. */

    double a, b, c;
    // reads a, b , c;
    cin >> a >> b >> c;

    if(a == 0)
    {
        cout << "This is not a quadratic equation" << endl;
    }
    else
    {
        double discriminant = pow(b, 2) - (4 * a * c);

        if(discriminant > 0)
        {
            double x1 = ((-b + sqrt(discriminant)) / (2 * a));
            double x2 = ((-b - sqrt(discriminant)) / (2 * a));


            cout << "The equation roots are: "<< "nX1: " << x1 << " nX2: " << x2 << endl;
        }
        else if(discriminant == 0)
        {
            double x = -b / (2 * a);

            cout << "The equation has only one root: " << "X: " << x << endl;
        }
        else
        {
            cout << "This equation doesn't have solution" << endl;
        }
    }
    return 0;
}
