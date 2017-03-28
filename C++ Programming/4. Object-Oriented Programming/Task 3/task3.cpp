#include <iostream>
#include <string>
#include <sstream>
using namespace std;

/* This program creates class which stores registered cars with their properties and their owner. Every registration has its own unique id number.
    Owner of a car can be changed but only with it's age and the registration number.
    To check if works correct, output is printed on the console.*/

class Car
{
    class Owner
    {
        private:
            string name;
            int age = 0;
            int id = 0;

        public:
            Owner(string name, int age):  /* Owner class constructor*/
                name(name),
                age(age),
                id(idCounter){
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

            void setOwner(string name, int age)
            {
                this->changeYears(age);
                this->name = name;
            }
    };

        private:
            string brandName;
            string model;
            int horsePower = 0;
            string registationNumber;
            Owner owner;
            static int idCounter;

        public:
            Car(string brandName, string model, int horsePower, string registationNumber, string name, int age): /* Car class constructor*/
                brandName(brandName),
                model(model),
                horsePower(horsePower),
                registationNumber(registationNumber),
                owner(name, age) {
                    idCounter++;
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
};

int Car::idCounter = 0;

int main()
{
    Car firstCar("BWM", "X5", 330, "SA 4432 TM", "Emil", 20);
    Car secondCar("Mercedes", "S500", 360, "SA 2142 MM", "Emil", 20);
    cout << firstCar.getInfo() << endl;
    cout << secondCar.getInfo() << endl;
     secondCar.changeOwnerAndRegNumber("Kosio", 50, "PB 0423 MM");
     cout << secondCar.getInfo() << endl;
     vector<Car> vectorOfCars;


}
