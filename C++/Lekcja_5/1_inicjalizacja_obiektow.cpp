#include<iostream>

using namespace std;

class Car{
	public:
		unsigned int id{10};
		string brand {"Ferrari"};
		string model {"F430"};
		
		void getData();
		
		Car();
		Car(unsigned int pId,string pBrand,string pModel);
};

void Car::getData(){
	cout<<"Id: "<<id<<"\nMarka: "<<brand
	<<", model: "<<model<<"\n";
}

//Car::Car(){
//	cout<<"Konstruktor bezparametrowy\n";
//}

Car::Car(){
	id=3;
	brand="Fiat";
	model="Punto";
}

Car::Car(unsigned int pId,string pBrand,string pModel){
	id=pId;
	brand=pBrand;
	model=pModel;
}

int main(){
	setlocale(LC_CTYPE,"polish");
	Car ferrari;
	ferrari.getData();
	
	Car zjuju=Car();
	zjuju.getData();
	return 0;
}
