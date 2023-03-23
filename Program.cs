/* Написать программу, которая из имеющегося массива строк формирует 
массив из строк, длинна которых меньше либо равна 3 символа. */

string[] textArray = new string[4]{ "hello", "2", "world", ":-)" };
int length = textArray.GetLength(0);
int resultArrayCount = 0;
string resultString = "[";
for (int i = 0; i < length; i++)
{
    if (textArray[i].Length <= 3){
        resultArrayCount++;
    }
    if (i + 1 < length){
        resultString += $"{textArray[i]}, ";
    } else {
        resultString += $"{textArray[i]}] -> [";
    }
}

string[] resultArray = new string[resultArrayCount];
resultArrayCount = 0;
for (int i = 0; i < textArray.GetLength(0); i++)
{
    if (textArray[i].Length <= 3){
        resultArray[resultArrayCount] = textArray[i];
        resultArrayCount++;
    }
}


for (int i = 0; i < resultArray.GetLength(0); i++)
{
    if (i + 1 < length){
        resultString += $"{resultArray[i]}, ";
    } else {
        resultString += $"{resultArray[i]}]";
    }
}

Console.Write(resultString);
