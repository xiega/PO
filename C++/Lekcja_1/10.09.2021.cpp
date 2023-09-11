#include <iostream>

using namespace std;

class Worker{
	//deklaracja zmiennych cz�onkowskich (pola, cechy, w�a�ciwo�ci)
	public:
		string name;
		string surname;
		short int birthYear;
		string nationality;
		float height;
		char gender;
	
	//definicja funkcji cz�onkowskiej (metody)
	void showName(){
		cout<<"\nImi� pracownika: "<<name;
	}
		
	//deklaracja funkcji cz�onkowskiej (prototyp)
	void showSurname();
	void showNameSurname();
	void showAllData();
};

//definicja metody showSurname
void Worker::showSurname(){
	cout<<"\nNazwisko pracownika: "<<surname<<endl;
}

void Worker::showNameSurname(){
	cout<<"Imi� i nazwisko pracownika: "<<name<<" "<<surname<<"\n";
}

void Worker::showAllData(){
	cout<<"\nDane pracownika:\n";
	showNameSurname();
	cout<<"Narodowo��: "<<nationality<<"\nRok urodzenia: "<<birthYear<<", Wzrost: "<<height<<" cm\nP�e�: ";
	switch(gender){
		case 'm':
			cout<<"m�czyzna\n";
			break;
		case 'w':
			cout<<"kobieta\n";
			break;
		default:
			cout<<"-\n";
			break;
	}
}

int main(int argc, char** argv){
	setlocale(LC_CTYPE, "polish");
	Worker janusz;
	janusz.name="Janusz";
	janusz.surname="Nowak";
	janusz.birthYear=1985;
	janusz.nationality="Polak";
	janusz.height=182;
	janusz.gender='m';
//	janusz.age=18;
//	cout<<janusz.name;
//	cout<<"\nImi� i nazwisko: "<<janusz.name<<" "<<janusz.surname<<"\n\n";	
	janusz.showName();
	janusz.showSurname();
	janusz.showNameSurname();
	janusz.showAllData();
	return 0;
}
