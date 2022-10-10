class Task2
{

    // Задача 2*. Написать программу, которая принимает от пользователя положительные числа и считает среднее значение этих чисел.
    // Ввод числе осуществляется до тех пор, пока пользовател не введёт -1. Ввод чисел и расчёт должен происходит в рекурсии

    public static string Execute()
    {

        double lastResult = RecurAverangePositiv(0, 0);


        return "Прервано выполнение программы. Среднее значение всех чисел - " + lastResult;

    }


    static double RecurAverangePositiv(double sumNumbers, double counter)
    {
        int inputInteger = -2;
        do
        {
            inputInteger = MainClass.ReadInteger("Введите положительное число. Для выхода введите -1");
            if (inputInteger == -1) return sumNumbers / counter;
            if (inputInteger < 0) Console.WriteLine("Ошибка необходимо вводить положительные числа, введите заново");
        } while (inputInteger < 0);
        counter++;


        Console.WriteLine(">>>>>Введено чисел - " + counter + " штук. Среднее значение этих чисел " + (sumNumbers + inputInteger) / counter + "<<<<<");

        return RecurAverangePositiv(sumNumbers + inputInteger, counter);
    }


}