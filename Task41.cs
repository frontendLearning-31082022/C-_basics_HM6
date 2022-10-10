class Task41{

// Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 5
// 0
// 7
// 8
// -2
// -2 -> 2
// 5
// 1
// -7
// 567
// 89
// 223-> 3


    public static string Execute(){

        int Mcount= MainClass.ReadInteger("Сколько цифр будет введено?");
        int result=0;

        while(Mcount>0){
              int InputOneNumber= MainClass.ReadInteger("Введите число");
              if(InputOneNumber>0)result++;
              Mcount--;
        }


        return "Было введено чисел больше нуля - "+result;
    
    } 
}