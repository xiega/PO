using namespace std;

class Dog :public Animal, public Mammal {
public:
    void className() {
        cout << "Klasa Dog\n";
    }
    virtual void speak() {
        cout << "Hau Hau!!!\n";
    }
    virtual void breath() {
        cout << "Oddycha p³ucami\n";
    }
};
