#include<iostream>

using namespace std;

struct Color{
	string col1,col2,col3;
};

struct EyeColor{
	string col1,col2;
};

class Dog{
	public:
		Color color;
		EyeColor eyeColor;
		short int height;
		short int length;
		short int weight;
		string name;
		string race;
		
		void sit();
		void layDown();
		void shake();
		void come();
		void getData();
		
		Dog(Color color, EyeColor eyeColor, short int height, short int length, short int weight,string name,string race);
};

Dog::Dog(Color pColor, EyeColor pEyeColor, short int pHeight, short int pLength, short int pWeight,string pName, string pRace){
	color=pColor;
	eyeColor=pEyeColor;
	height=pHeight;
	length=pLength;
	weight=pWeight;
	name=pName;
	race=pRace;
}

void Dog::sit(){
	cout<<"\nPies siada.";
}

void Dog::layDown(){
	cout<<"\nPies k³adzie siê.";
}

void Dog::shake(){
	cout<<"\nPies krêci ogonem.";
}

void Dog::come(){
	cout<<"\nPies przychodzi.";
}

void Dog::getData(){
	cout<<"\nImiê: "<<name<<"\nRasa: "<<race<<"\nKolory sierœci: "<<color.col1<<", "
	<<color.col2<<", "<<color.col3<<"\nKolory oczu: "<<eyeColor.col1<<", "
	<<eyeColor.col2<<"\nWysokoœæ: "<<height<<"\nD³ugoœæ: "<<length<<"\nWaga: "<<weight;
}

int main(){
	setlocale(LC_CTYPE,"polish");
	Dog Rayne({"Gray","White","Black"},{"Blue","Brown"},18,36,30,"Rayne","Owczarek");\
	Rayne.getData();
	Rayne.sit();
	Rayne.layDown();
	Rayne.shake();
	Rayne.come();
	return 0;
}
