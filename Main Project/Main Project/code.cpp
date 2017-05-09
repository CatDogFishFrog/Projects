#include <iostream>
using namespace std;

int Double(int); //���������� ������� ��� ���� int
float Double(float); //���������� ������� ��� ���� float
long Double(long); //���������� ������� ��� ���� long
double Double(double); //���������� ������� ��� ���� double
unsigned short Double(unsigned short); //���������� ������� ��� ���� unsigned short
unsigned int Double(unsigned int); //���������� ������� ��� ���� unsigned int
inline int Fibonacci(int n); //���������� ����� ��������. ��������
unsigned long int Primeter(unsigned long int, unsigned long int);
short int Delenie(unsigned short int, unsigned short int);
unsigned long int GetPower(unsigned short n, unsigned short power); //���������� �������. ��������

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

int Double(int n) //���������� ������� ��� ���� int
{
	return n * 2;
}

float Double(float n) //���������� ������� ��� ���� float
{
	return n * 2;
}

long Double(long n) //���������� ������� ��� ���� long
{
	return n * 2;
}

double Double(double n) //���������� ������� ��� ���� double
{
	return n * 2;
}

unsigned short Double(unsigned short n) //���������� ������� ��� ���� unsigned short
{
	return n * 2;
}

unsigned int Double(unsigned int n) //���������� ������� ��� ���� unsigned int
{
	return n * 2;
}

int Fibonacci(int n) //���������� ����� ��������. �������
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

unsigned long int GetPower(unsigned short n, unsigned short power) //���������� �������. ��������
{
	if (power == 1)
		return n;
	else
		return (n * GetPower(n, power - 1));
}