#include <iostream>
using namespace std;

int Double(int); //Перегрузка функции для типа int
float Double(float); //Перегрузка функции для типа float
long Double(long); //Перегрузка функции для типа long
double Double(double); //Перегрузка функции для типа double
unsigned short Double(unsigned short); //Перегрузка функции для типа unsigned short
unsigned int Double(unsigned int); //Перегрузка функции для типа unsigned int
inline int Fibonacci(int n); //Нахождение числа Фибоначи. РЕКУРСИЯ
unsigned long int Primeter(unsigned long int, unsigned long int);
short int Delenie(unsigned short int, unsigned short int);
unsigned long int GetPower(unsigned short n, unsigned short power); //Нахождение степени. РЕКУРСИЯ

int main()
{
	int myint = 5;
	float myfloat = 5.5f;
	long mylong = 99999;
	double mydouble = 55.55;
	unsigned short myshort = 55;
	unsigned int myunsint = 2000000000;
	int n, answer;

	cout << "\n\nIn Main():\n" << endl;
	cout << "MyInt: " << myint << endl;
	cout << "MyFloat: " << myfloat << endl;
	cout << "MyLong: " << mylong << endl;
	cout << "MyDouble: " << mydouble << endl;
	cout << "MyShort: " << myshort << endl;
	cout << "MyUnsInt: " << myunsint << "\n\n\n" << endl;

	cout << "In Double():\n";
	cout << "Doubled MyInt: " << Double(myint) << endl;
	cout << "Doubled MyFloat: " << Double(myfloat) << endl;
	cout << "Doubled MyLong: " << Double(mylong) << endl;
	cout << "Doubled MyDouble: " << Double(mydouble) << endl;
	cout << "Doubled MyShort: " << Double(myshort) << endl;
	cout << "Doubled MyUnsInt: " << Double(myunsint) << endl;

	/*cout << "\n\nEnter number to find: "; cin >> n;
	cout << "\n\n";
	answer = Fibonacci(n);
	cout << answer << " is the " << n << "th Fibonacci number\n";*/

	/*unsigned short int q, w;
	short int e;
	cout << "\n\nVvedite 2 chisla: ";
	cin >> q;
	cin >> w;
	e = Delenie(q, w);
	{
	if (e > -1)
	cout << q << " / " << w << " = " << e << endl;
	else
	cout << "Error. Vnjhjt chislo = 0\n";
	}*/

	unsigned short number, power;
	unsigned long int ans;
	cout << "\n\nEnter number: "; cin >> number;
	cout << "\nEnter pow: "; cin >> power;
	ans = GetPower(number, power);
	cout << number << " pow " << power << " = " << ans << endl;

	system("pause");
	return 0;
}

int Double(int n) //Перегрузка функции для типа int
{
	return n * 2;
}

float Double(float n) //Перегрузка функции для типа float
{
	return n * 2;
}

long Double(long n) //Перегрузка функции для типа long
{
	return n * 2;
}

double Double(double n) //Перегрузка функции для типа double
{
	return n * 2;
}

unsigned short Double(unsigned short n) //Перегрузка функции для типа unsigned short
{
	return n * 2;
}

unsigned int Double(unsigned int n) //Перегрузка функции для типа unsigned int
{
	return n * 2;
}

int Fibonacci(int n) //Нахождение числа Фибоначи. РЕКУРСИ
{
	cout << "Ptocessing fib (" << n << ")...";
	if (n < 3)
	{
		cout << "Return 1!\n";
		return (1);
	}
	else
	{
		cout << "Call Fibonacci(" << n - 2 << ") and Fibonacci(" << n - 1 << ").\n";
		return (Fibonacci(n - 1) + Fibonacci(n - 2));
	}
}

unsigned long int Primeter(unsigned long int x, unsigned long int y)
{
	return (x + y) * 2;
}

short int Delenie(unsigned short int x, unsigned short int y)
{
	if (y == 0)
		return -1;
	else
		return x / y;
}

unsigned long int GetPower(unsigned short n, unsigned short power) //Нахождение степени. РЕКУРСИЯ
{
	if (power == 1)
		return n;
	else
		return (n * GetPower(n, power - 1));
}