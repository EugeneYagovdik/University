#include <iostream>
#include <ctime>
using namespace std;

int main()
{
    setlocale(LC_ALL, ".1251");

    int n, x;
    float min = -20, max = 30;
    float* arr;
    int count = 0, imax = 0, imin = 0;
    
    cout << "������� ����������� ������� ";
    do
    {
        cin >> n;
        if ((n <= 100) && (n > 1))
            break;
        cout << "�������� ���������� ���������. ��������� ����: ";
    } while (1);

    arr = new float[n];

    cout << "��������� ������ ���������� ������� (0) ��� ������� (1)? ";
    cin >> x;
    if (x == 1)
    {

        cout << "������� ������" << endl;

        for (int i = 0; i < n; i++)
            cin >> arr[i];
    }
    else
    {
        srand(time(NULL));
        for (int i = 0; i < n; i++)
        {
            //arr[i] = min + rand() % (max - min);
            arr[i] = min + (float)rand() / (float)(RAND_MAX / (max - min));
            cout << arr[i] << endl;
        }
    }

    int imin = 0;
    delete[] arr;
}