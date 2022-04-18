#include <iostream>
#include <string>
#include <vector>
#include <iomanip>
using namespace std;
/*  
На вход программы первой строчкой поступает размер окна – целое нечетное число, 
не превышающее размер массива входного сигнала. 
На второй строчке идет строка чисел входного сигнала, 
округленных до 3-го знака после запятой и разделенных пробелами. 
Количество значений входного сигнала может быть различным, но не больше 25.

Формат выходных данных

Необходимо вывести на стандартный вывод отфильтрованный массив данных. 
Все значения должны быть выведены в одну строку через пробел
и округлены до трех знаков после запятой по правилам математического округления. 
Количество значений в выходной строке всегда должно совпадать с количеством значений входного сигнала.

Sample Input 1:
5
0.039 0.086 0.277 0.278 0.17 0.719 0.606 0.572 0.678 0.876
Sample Output 1:
0.039 0.086 0.170 0.306 0.410 0.469 0.549 0.690 0.678 0.876
*/
int frameSize, numCount;
const int numLimit = 25;
double num;
vector <double> numArr;
bool isValid = true;

void GetFrameSize()
{
    cin >> frameSize;
    
    if(frameSize > numLimit)
    {
        cout << "Number is greater than " << numLimit;
        isValid = false;
    }
    else if (frameSize % 2 == 0)
    {
        cout << "Number is not odd";
        isValid = false;
    }
}

void GetNumsInput()
{
    for(int i = 0; i < frameSize; i++)
    {
        cin >> num;
        numArr.push_back(num);
        numCount++;
    }
}

void Filter()
{
    
}

void Output()
{
    for (int i = 0; i < numCount; i++)
    {
        cout << setprecision(3) << fixed << numArr[i] << " ";
    }
}

int main ()
{
    GetFrameSize();
    if(isValid)
    {
        GetNumsInput();
        Filter();
        Output();
    }
    return 0;
}




