#include <string>
#include <list>
#include<iostream>
class students: std::string name, std::string Lastname, int age , double averageGrade  {
	std::array<std::string, 4>data;
public:
  public: std::string name;
  public: std::string LastName;
  public: int Age;
  public: double averageGrade;
  public: int  Course;
//создаем массив который будет заполнятья
		students(std::string a, std::string b, std::string с, std::string d, std::string s) {
			//заполняем
			 data = { name1,name2,name3,name4 };
}
//добавление студентов метод
public: std::string addStudents()
{
	std::array<std::string,5> {};

	if (students == "")
	{
		std::cout << "список студентов" << " " << "{students}";
	}
	else {
		std::cout << "вы не велли студентов";
	}
}
public: double returnAverageGrade()
{
	std::cout << "средние оценки стуудентов" << " " << " " << "{averageGrade}";
}

};