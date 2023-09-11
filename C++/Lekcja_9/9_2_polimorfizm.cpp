#include <iostream>
using namespace std;

class Animal {
public:
    void className() {
        cout << "Klasa Animal\n";
    }
    virtual void speak() {
        cout << "Dźwięk zwierzaka\n";
    }
};

class Dog :public Animal {
public:
    void className() {
        cout << "Klasa Dog\n";
    }
    virtual void speak() {
        cout << "Hau Hau!!!\n";
    }
};

int main()
{
    setlocale(LC_CTYPE, "polish");

    Animal zwierze;
    cout << sizeof(zwierze) << endl;
    
    Dog* wskDog = new Dog();
    wskDog->className();
    wskDog->speak();

    Animal* wskAnimal = new Dog();
    wskAnimal->className();
    wskAnimal->speak();

    Animal x;
    wskAnimal = &x;
    wskAnimal->className();
    wskAnimal->speak();

    return 0;
}
