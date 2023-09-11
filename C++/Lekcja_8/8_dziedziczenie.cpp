#include<iostream>

using namespace std;

//klasa bazowa (rodzic)
class Animal{
	public: 
		string name, voice;
		float height, weight;
		void funcPublicAnimal(){
			cout<<"Funkcja publiczna klasy Animal\n";
		}
		void funcAnimal(){
			cout<<"Funkcja Animal\n";
		}
		void setVaccination(bool pVaccination){
			vaccination=pVaccination;
		}
		bool getVaccination(){
			return vaccination;
		}
	private:
		bool vaccination;
};

//klasa potomna (dziecko)
class Dog: public Animal{
	public:
		string breedOfDog;
		void aport(){
			cout<<"Aportowanie\n";
		}
		void funcAnimal(){
			cout<<"Funkcja Pies\n";
		}
};

int main()
{
	setlocale(LC_CTYPE,"polish");
	Animal zwierze;
	zwierze.funcPublicAnimal();
	zwierze.funcAnimal();
	zwierze.setVaccination(1);
	cout<<"Szczepienie: "<<zwierze.getVaccination()<<endl;
	
	Dog burek;
	burek.aport();
	burek.funcPublicAnimal();
	burek.funcAnimal();
	
	return 0;
}
