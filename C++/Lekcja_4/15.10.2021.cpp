#include <iostream>

using namespace std;

struct Date{
	unsigned short int dd,mm,yyyy;
};

class Worker{
	public:
		unsigned int id;
		string name, surname;
		Date dateBirthday;
		
		void getData();
		
	//	Worker(){
	//		id=100;
	//		name="Jerzy",surname="Sabiniewicz";
	//		dateBirthday={15,10,2021};
	//	}
		
		Worker();
		
		Worker(int id);
		
		Worker(int id,string name, string surname);
		
		Worker(int id,string name,string surname,Date dateBirthday);
};

Worker::Worker(int pId, string pName, string pSurname, Date pDateBirthday){
	id=pId;
	name=pName;
	surname=pSurname;
	dateBirthday=pDateBirthday;
}

Worker::Worker(int pId){
	id=pId;
}

Worker::Worker(int pId, string pName, string pSurname){
	id=pId;
	name=pName;
	surname=pSurname;
}

void Worker::getData(){
	cout<<"\nId: "<<id<<"\nImiê i nazwisko: "<<name<<" "<<surname<<"\nData urodzenia: "<<dateBirthday.dd<<"-"<<dateBirthday.mm<<"-"<<dateBirthday.yyyy;
}

int main(){
	setlocale(LC_CTYPE,"polish");
	Worker nowak(100,"Jerzy","Sabiniewicz",{15,10,2021});
	nowak.getData();
	
	Worker kowalski(26,"Bernie","WoofWoof");
	kowalski.getData();
	return 0;
}
