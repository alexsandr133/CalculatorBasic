// ConsoleApplication7.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "rus");
	cout << "решение задачи"<<endl;
	int time = 3;
	int speed = 60;
	int distance = speed * time;
	cout << "решение задачи" << " " << distance<<endl;
	cout << "решение втрой задачи"<<endl;
	int storona1 = 5;
	int storona2 = 7;
	int perometr = (storona1 * storona2) * 2;
	cout << "периметр прямоугольника" <<" "<<  perometr << endl;
	int square = storona1 * storona2;
	cout << "площадь прямоугольника" <<" "<< square << endl;
}   

