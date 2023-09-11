#include<iostream>

using namespace std;

class Worker{
	private:
		string name{""},surname{""};
		
	public:
		void setName(string pName){
			name=pName;
		}
		void setSurname(string pSurname){
			surname=pSurname;
		}
		string getName(){
			return name;
		}
		string getSurname(){
			return surname;
		}
		string getData(){
			return name+" "+surname;
		}
};

class Teacher:public Worker{
	private:
		string schoolSubject{""};
	public:
		void setSchoolSubject(string pSchoolSubject){
			schoolSubject=pSchoolSubject;
		}
		string getSchoolSubject(){
			return schoolSubject;
		}
		string getData(){
			return getName()+" "+getSurname()+" "+schoolSubject+"\n";
		}
};

class Supervisor:public Teacher{
	private:
		string schoolClass{""};
	public:
		void setSchoolClass(string pSchoolClass){
			schoolClass=pSchoolClass;
		}
		string getSchoolClass(){
			return schoolClass;
		}
		string getData(){
			return getName()+" "+getSurname()+" "+getSchoolSubject()+" "+schoolClass+"\n";
		}
};

int main(){
	setlocale(LC_CTYPE,"polish");
	Teacher nauczyciel;
	nauczyciel.setName("Marek Grzegorz");
	nauczyciel.setSurname("Nowak");
	nauczyciel.setSchoolSubject("BHP, EDB, PP");
	cout<<nauczyciel.getData();
	Supervisor wychowawca;
	wychowawca.setName("Ma³gorzata");
	wychowawca.setSurname("Rêkoœ");
	wychowawca.setSchoolSubject("Matematyka");
	wychowawca.setSchoolClass("2D");
	cout<<wychowawca.getData();
	return 0;
}
