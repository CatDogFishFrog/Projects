#include <iostream>
#include <conio.h>
#include <windows.h>

using namespace std;

const int width = 20;
const int height = 20;
int tailX[100], tailY[100];
int nTail;
bool gameOver;
int x, y, fruitX, fruitY, score;
enum eDirection { STOP = 0, LEFT, RIGHT, UP, DOWN };
eDirection dir;
int dif;
bool acr;

void Setup() {
	system("cls");
	gameOver = false;
	cout << "Select difficulty\n(1 - Very Easy \\ 2 - Easy \\ 3 - Normal \\ 4 - Hard)" << endl;
r:
	switch (_getch())
	{
	case '1':
		dif = 1000;
		break;
	case '2':
		dif = 500;
		break;
	case '3':
		dif = 250;
		break;
	case '4':
		dif = 100;
		break;
	default:
		goto r;
		break;
	}

	cout << "Walk through walls? (Y\\N)" << endl;	q:	switch (_getch())	{	case 'y':		acr = true;		break;	case 'n':		acr = false;		break;	default:
		goto q;		break;	}

	dir = STOP;
	x = width / 2 - 1;
	y = height / 2 - 1;
	fruitX = rand() % width;
	fruitY = rand() % height;
	score - 0;

}

void Draw() {
	system("cls");
	for (int i = 0; i < width + 1; i++)
		cout << " #";
	cout << endl;

	for (int i = 0; i < height; i++) {
		for (int j = 0; j < width; j++) {
			if (j == 0 || j == width - 1)
				cout << " #";
			if (i == y && j == x)
				cout << " 0";
			else if (i == fruitY && j == fruitX)
				cout << " *";
			else {
				bool print = false;
				for (int k = 0; k < nTail; k++) {
					if (tailX[k] == j && tailY[k] == i) {
						print = true;
						cout << " o";
					}
				}
				if (!print)
					cout << "  ";
			}
		}
		cout << endl;
	}

	for (int i = 0; i < width + 1; i++)
	{
		cout << " #";
	}
	cout << endl;
	cout << "Score: " << score << endl;
}

void Input() {

	if (_kbhit()) {
		switch (_getch())
		{
		case 'a':
			if (dir != RIGHT)
				dir = LEFT;
			break;
		case 'd':
			if (dir != LEFT)
				dir = RIGHT;
			break;
		case 'w':
			if (dir != DOWN)
				dir = UP;
			break;
		case 's':
			if (dir != UP)
				dir = DOWN;
			break;
		case 'x':
			gameOver = true;
			break;
		}
	}
}

void Logic() {
	int prevX = tailX[0];
	int prevY = tailY[0];
	int prev2X, prev2Y;
	tailX[0] = x;
	tailY[0] = y;
	for (int i = 1; i < nTail; i++)
	{
		prev2X = tailX[i];
		prev2Y = tailY[i];
		tailX[i] = prevX;
		tailY[i] = prevY;
		prevX = prev2X;
		prevY = prev2Y;
	}

	switch (dir)
	{

	case LEFT:
		x--;
		break;
	case RIGHT:
		x++;
		break;
	case UP:
		y--;
		break;
	case DOWN:
		y++;
		break;
	}

	switch (acr)	{	case true:		if (x >= width-1)			x = 0;		else if (x < 0)			x = width - 2;		if (y >= height)			y = 0;		else if (y < 0)			y = height - 1;		break;	case false:		if (x > width - 1 || x<0 || y>height - 1 || y < 0)			gameOver = true;		break;	}

	for (int i = 0; i < nTail; i++) {
		if (tailX[i] == x&&tailY[i] == y) {
			gameOver = true;
		}
	}

	if (x == fruitX&&y == fruitY) {
		score += 10;
		fruitX = rand() % width;
		fruitY = rand() % height;
		nTail++;
	}
}

int main() {
l:
	Setup();
	while (!gameOver)
	{
		Sleep(dif);
		Draw();
		Input();
		Logic();
	}
	cout << "Game Ower!" << endl;
	cout << "Do you want to start the game again? (Y//N)" << endl;
e:
	switch (_getch())
	{
	case 'y':
		goto l;
		break;
	case 'n':
		return 0;
		break;
	default:
		goto e;

	}
	return 0;
}