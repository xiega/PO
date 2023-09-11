#include<iostream>

using namespace std;

class Car{
	unsigned int id;
	public:
		string brand;
		string model;
		
		void getData();
		
		Car();
		Car(unsigned int pId);
		Car(unsigned int pId, string pBrand, string pModel);
};

void Car::getData(){
	cout<<"Id: "<<id<<"\nMarka: "<<brand<<", model: "<<model<<endl;
}

Car::Car():
	id{0},
	brand{"MARKA"},
	model{"MODEL"}
{
	cout<<"Konstruktor domyœlny\n";
}

Car::Car(unsigned int pId){
	id=pId;
}

Car::Car(unsigned int pId, string pBrand, string pModel):
	id{pId},
	brand{pBrand},
	model{pModel}
{
	cout<<"Konstruktor parametryczny\n";
}

//Car(unsigned int pId, string pBrand, string pModel);

int main(){
	setlocale(LC_CTYPE,"polish");
	
	Car fiat;
	fiat.getData();
	
	Car fiat1(10,"Fiat","Multipla");
	fiat1.getData();
	
	Car fiat2 = Car();
	fiat2.getData();
	
	Car fiat3 = Car(10,"Fiat","Multipla");
	fiat3.getData();
	
	Car fiat4(8);
	fiat4.getData();
	
//	cout<<endl<<"Id: "<<fiat4.id<<endl;
	return 0;
}
