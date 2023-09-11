#include<iostream>

using namespace std;

class Car{
	public:
		unsigned int id;
		string brand;
		string model;
		
		void getData();
		
		Car();
		Car(unsigned int pId,string pBrand,string pModel);
};

void Car::getData(){
	cout<<"Id: "<<id<<"\nMarka: "<<brand
	<<", model: "<<model<<"\n";
}

Car::Car(){
	id=0;
	brand="Domyœlna marka";
	model="Domyœlny model samochodu";
	cout<<"Konstruktor domyœlny\n"; 
}

Car::Car(unsigned int pId,string pBrand,string pModel){
	id=pId;
	brand=pBrand;
	model=pModel;
	cout<<"Konstruktor parametryczny\n";
}

int main(){
	setlocale(LC_CTYPE,"polish");
	
	Car matiz=Car{1,"Daewoo","Matiz"};
	matiz.getData();
	
	Car car1 (2,"Daewoo","Tico");
	car1.getData();
	
	return 0;
}
