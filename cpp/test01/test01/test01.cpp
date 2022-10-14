#include <iostream>
#include <fstream>
#include <cmath>
using namespace std;

const int MATRIX_LENGTH = 100;

int main()
{
	ofstream fout("result.txt");

	bool Matrix[MATRIX_LENGTH][MATRIX_LENGTH] = { {false} };
	int a, b, r;

	cout << "테스트 : ";
	cin >> a >> b;

	cout << "테스트 : ";
	cin >> r;

	for (int x = 0; x < MATRIX_LENGTH; x++) {
		/** (x - a)^2 + (y - b)^2 = r^2
			(y - b)^2 = r^2 - (x - a)^2
			(y - b)^2 = (r + x - a)(r - x + a)
			y - b = 짹��{(r + x - a)(r - x + a)}
			�� y = b 짹 ��{(r + x - a)(r - x + a)}
		**/
		int y1 = b + sqrt((r + x - a) * (r - x + a));
		int y2 = b - sqrt((r + x - a) * (r - x + a));

		if (0 <= y1 && y1 < MATRIX_LENGTH) {
			Matrix[y1][x] = true; Matrix[x][y1] = true;
		}
		if (0 <= y2 && y2 < MATRIX_LENGTH) {
			Matrix[y2][x] = true; Matrix[x][y2] = true;
		}
	}

	for (int i = 0; i < MATRIX_LENGTH; i++) {
		for (int j = 0; j < MATRIX_LENGTH; j++) {
			if (Matrix[i][j]) fout << "ye";
			else fout << "ue";
		}
		fout << endl;
	}

	return 0;
}