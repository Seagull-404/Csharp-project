#include<iostream>
#include "Student.h"

double Add(double a, double b)
{
	return a + b;
}

int main()
{
	Student* pStu = new Student;
	//pStu->SayHello();
	double x = 2.0;
	double y = 4.0;
	double result = pStu->Add(x, y);
	std::cout << x << "+" << y << "=" << result;

	//std::cout << "hello world!";
	
	return 0;
}