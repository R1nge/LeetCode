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
void BubbleSort();
void Output();

int main ()
{
    if(GetFrameSize())
    {
        GetNumsInput();
        //Sort();
        BubbleSort();
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

void BubbleSort()
{
    bool swapped;

    for(int i = 0; i < frameSize - 1; i++)
    {
        swapped = false;
        for (int j = 0; j < frameSize -i - 1; j++)
        {
            if(numArr[j] > numArr[j + 1])
            {
                float temp = numArr[j];
                numArr[j] = numArr[j + 1];
                numArr[j + 1] = temp;
                swapped = true;
            }
            
            if(swapped == false)
                break;
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
