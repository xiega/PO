#include <iostream>
#include <conio.h>
using namespace std;

struct Date {
    unsigned short int dd, mm, yyyy;
};

class Worker {
    public:
        unsigned int id {};
        string name {}, surname {};
        Date birthdayDate {};

        void showAllData();
        void setData(unsigned int id, string name, string surname, Date birthdayDate = {});
};

void Worker::showAllData() {
    cout<<"Dane pracownika:"
        <<"\nID: "<<id
        <<"\nImie: "<<name
        <<"\nNazwisko: "<<surname
        <<"\nData urodzenia: "<<birthdayDate.dd<<"."<<birthdayDate.mm<<"."<<birthdayDate.yyyy<<" r.\n";
}

void Worker::setData(unsigned int id, string name, string surname, Date birthdayDate) {
    Worker::id = id;
    Worker::name = name;
    Worker::surname = surname;
    Worker::birthdayDate = birthdayDate;
}

int main(int argc, char** argv) {
    setlocale(LC_CTYPE, "polish");

    Worker pracownik;
    pracownik.setData(10, "Zygzak", "Mak³in", {1, 2, 1998});
    pracownik.showAllData();
    
    getch();
    return 0;
}
