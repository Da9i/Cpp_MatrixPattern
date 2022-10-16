#include<iostream>
using namespace std;
int main()
{
	int arr1[5][5] = { {1,2,3,4,5} ,{1,2,3,4,5} ,{1,2,3,4,5} ,{1,2,3,4,5} ,{1,2,3,4,5} };
	int draw = 5;
	cout << "FIRST MATRIX :\n" << endl;
	//for displaying the first matrix.
	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j < i; j++)
		{
			cout << "  ";
		}
		for (int k = 0; k < draw; k++)
		{
			cout << arr1[i][k] << " ";
		}
		cout << endl;
		draw--;
	}
	cout << endl;
	cout << "SECOND MATRIX :\n" << endl;
	//for displaying the second matrix.
	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j < 5; j++)
		{
			cout << arr1[i][j] << " ";
		}
		cout << endl;
	}
	cout << endl;
	cout << "THIRD MATRIX :\n" << endl;
	//for displaying the third matrix.
	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j <= i; j++)
		{
			cout << arr1[i][j] << " ";
		}
		cout << endl;
	}
	cout << endl;


	system("pause>0");
} 
