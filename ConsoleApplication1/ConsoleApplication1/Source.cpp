#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");
	int x;
	int y;
	int answer;
	cout << "������, �����! \n";
	cout << "����� ��� ����� ������� ����������: ";
	cin >> x;
	cout << "+";
	cin >> y;
	answer = x + y;
	cout << "\n���������: " << x << "+" << y << "=" << answer << endl;
	system("pause");
	return 0;
}