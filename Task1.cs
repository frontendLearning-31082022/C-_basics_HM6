class Task1
{

    // Задача 1*. Написать программу, которая рекурсивным методом переводит числа из десятичной системы счисления в двоичную
    // 2 -> 10
    // 11 -> 1011
    // 16 -> 10000


    public static string Execute()
    {

        int inputInteger = MainClass.ReadInteger("Введите десятичное число для перевода в двоичное");
        string BinaryResult = OneDigitToBinary(inputInteger);
        return BinaryResult;

    }

    public static string OneDigitToBinary(double decimalNum)
    {
        string byRecVal = (decimalNum % 2).ToString();
        int NextDiv = (int)decimalNum / 2;
        if (decimalNum < 1) return "";
        return OneDigitToBinary(NextDiv) + byRecVal;
    }




}