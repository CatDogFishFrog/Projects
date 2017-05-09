#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");
	int x;
	int y;
	int answer;
	cout << "Привет, Алиса! \n";
	cout << "Введи два числа которые прибавятся: ";
	cin >> x;
	cout << "+";
	cin >> y;
	answer = x + y;
	cout << "\nРезультат: " << x << "+" << y << "=" << answer << endl;
	system("pause");
	return 0;
}