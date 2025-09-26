#include<stdio.h>

double Add(double a, double b)
{
	return a + b;
}
int main()
{
	//printf("hello world!");
	double x = 4.0;
	double y = 6.0;
	double result = Add(x, y);
	printf("%f+%f=%f",x,y,result);
	return 0;

}