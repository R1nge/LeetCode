#include <iostream>
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
3
0.17 0.039 0.086
Sample Output 1:
0.039 0.086 0.170
*/
int frameSize;
const int FRAME_SIZE_LIMIT = 25;
vector <float> numArr;

bool GetFrameSize();
void GetNumsInput();
void Sort();
void BubleSort();
void Output();

int main ()
{
    if(GetFrameSize())
    {
        GetNumsInput();
        //Sort();
        BubleSort();
        Output();
    }
    return 0;
}

bool GetFrameSize()
{
    cout << "Enter Frame Size" << endl;
    cin >> frameSize;
    
    if(frameSize > FRAME_SIZE_LIMIT)
    {
        cout << "Number is greater than " << FRAME_SIZE_LIMIT;
        return false;
    }
    else if (frameSize % 2 == 0)
    {
        cout << "Number is not odd";
        return false;
    }
    return true;
}

void GetNumsInput()
{
    float num;
    cout << "Enter Numbers" << endl;
    for(int i = 0; i < frameSize; i++)
    {
        cin >> num;
        numArr.push_back(num);
    }
}

void Sort()
{
    for (int i = 0; i < frameSize; i++)
    {
        for (int j = i + 1; j < frameSize; j++)
        {
            if(numArr[i] > numArr[j])
            {
                float temp = numArr[i];
                numArr[i] = numArr[j];
                numArr[j] = temp;
            }
        }
    }        
}

void BubleSort()
{
    bool is_sorted = false;
    while (not is_sorted){
        int i = 0;
        is_sorted = true;
        while (i < frameSize - 1){
            if(numArr[i] > numArr[i+1])
            {
                float temp = numArr[i];
                numArr[i] = numArr[i+ 1];
                numArr[i+1] = temp;
                is_sorted = false;
            }
            i++;
        }
    }
}
void Output()
{
    for (int i = 0; i < frameSize; i++)
    {
        cout << setprecision(3) << fixed << numArr[i] << " ";
    }
}
