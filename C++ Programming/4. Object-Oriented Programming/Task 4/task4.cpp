#include <iostream>
#include <string>
#include <sstream>
#include <fstream>
#include <vector>
using namespace std;

/* This program creates class which stores registered cars with their properties and their owner. Every registration has its own unique id number.
    Owner of a car can be changed but only with it's age and the registration number.
    Next, data is stored into a file and then it can be red by it also.
    To check if the program works correct, output is printed on the console. */

class Car
{
    class Owner
    {
        private:
            string name;
            int age = 0;
            int id = 0;

        public:
            Owner(string name, int age): /* Owner class constructor*/
                name(name),
                age(age),
                id(idCounter){
                }

            Owner(){
            }

            void changeYears(int years)
            {
                this->age = years;
            }

            string getInfo()
            {
                ostringstream info;

                info << "Id: " << this->id
                    << ", Name: " << this->name
                    << ", Age: " << this->age;

                return info.str();
            }

            string getName()
            {
                return this->name;
            }

            int getAge()
            {
                return this->age;
            }

            int getId()
            {
                return this->id;
            }

            void setOwner(string name, int age)
            {
                this->changeYears(age);
                this->name = name;
            }
            friend istream& operator>>(istream& lhs, Car& car);
    };

        private:
            string brandName;
            string model;
            int horsePower = 0;
            string registationNumber;
            Owner owner;
            static int idCounter;

        public:
            Car(string brandName, string model, int horsePower, string registationNumber, string name, int age):  /* Car class constructor*/
                brandName(brandName),
                model(model),
                horsePower(horsePower),
                registationNumber(registationNumber),
                owner(name, age) {
                    idCounter++;
                }

            Car(){
            }

            string getBrandName()
            {
                return this->brandName;
            }

            void setBrandName(string brandName)
            {
                this->brandName = brandName;
            }

            string getModel()
            {
                return this->model;
            }

            int getHorsePower()
            {
                return this->horsePower;
            }

            string getRegNumber()
            {
                return this->registationNumber;
            }

            Owner getOwner()
            {
                return this->owner;
            }

            string getInfo()
            {
                ostringstream info;

                info << "Manufacturer Name: " << this->brandName
                    << ", Model: " << this->model
                    << ", Horse Power: " << this->horsePower
                    << ", Registration Number: " << this->registationNumber
                    << ", " << this->owner.getInfo();

                return info.str();
            }

            void changeOwnerAndRegNumber(string name, int age, string regNumber)
            {
                this->owner.setOwner(name, age);
                this->registationNumber = regNumber;
            }

            friend istream& operator>>(istream& lhs, Car& car);
};

/* Constructors predefined to store data in files*/
ostream& operator<<(ostream& lhs, Car& car)
{
    return lhs << car.getBrandName() << ' ' << car.getModel() << ' ' << car.getHorsePower() << ' ' << car.getRegNumber() << ' ' << car.getOwner().getId() << ' ' << car.getOwner().getName() << ' ' << car.getOwner().getAge();
}

istream& operator>>(istream& lhs, Car& car)
{
    return lhs >> car.brandName >> car.model >> car.horsePower >> car.registationNumber >> car.owner.id >> car.owner.name >> car.owner.age;
}
/*-----------------------------------------------------*/

int Car::idCounter = 0;
typedef vector<Car> AllCars;

int main()
{

    AllCars carsOut;
    ofstream input("cars.txt");

    carsOut.push_back(Car("BWM", "X5", 330, "SA0032TM", "Emil", 20));
    carsOut.push_back(Car("Opel", "Vectra", 100, "SA3332KK", "Pesho", 34));
    carsOut.push_back(Car("Mercedes", "S500", 270, "SA1232LM", "Tosho", 25));
    carsOut.push_back(Car("Peugeot", "306", 80, "SA4252TE", "Gosho", 19));

    for(int i = 0; i < carsOut.size(); i++)
    {
        input << carsOut[i] << endl;
    }

    AllCars carsIn;

    ifstream output("cars.txt");
    for(int i = 0; i < carsOut.size(); i++)
    {
        Car x;
        output >> x;
        carsIn.push_back(x);
        cout << carsIn[i].getInfo() << endl;

    }
}

