//int[,] matrix = new int[3, 3]; //Создание двумерного массива
//int figure = 2;//Создание переменной для 

//while (!CheckEnd(matrix))//Создание цикла для повторения функций
//{
//    PrintMatrix(matrix);
//    Input(matrix, ref figure);
//}

//PrintMatrix(matrix);
//Console.WriteLine("игра завершена");
//Console.WriteLine("победа");



///////////////////

//void PrintMatrix(int[,] matrix) //Создание функции для вывода 
//{
//    Console.Clear();//Отчистка поля
//    for (int i = 0; i < 3; i++)
//    {
//        for (int j = 0; j < 3; j++)
//        {
//            switch (matrix[i, j]) //switch case для заполнения поля при вводе
//            {
//                case 0:
//                    Console.Write(" ");
//                    break;
//                case 1:
//                    Console.Write(" X ");
//                    break;
//                case 2:
//                    Console.Write(" O ");
//                    break;
//            }
//            if (j < 2) //Ввод вертикальной стены
//                Console.Write("|");
//        }
//        Console.WriteLine();
//        if (i <= 1)//Ввод горизонтальной стены
//        {
//            Console.WriteLine("-----------");
//        }
//    }
//}

//void Input(int[,] matrix, ref int figure)//Создание функции для ввода 
//{
//    int x, y;//Создание переменных для ввода координат 
//    Console.WriteLine("введите координаты :: ");
//    Console.Write("x :: ");
//    x = Convert.ToInt32(Console.ReadLine());
//    Console.Write("y :: ");
//    y = Convert.ToInt32(Console.ReadLine());

//    if (x > 0 && x <= 3 && y > 0 && y <= 3 && matrix[x - 1, y - 1] == 0)
//    {
//        if (figure % 2 == 0)
//        {
//            matrix[x - 1, y - 1] = 1;//х-1 и y-1 используем для простоты пользования
//            figure++;//Используем, чтобы чередовались Х и О
//        }
//        else if (figure % 2 != 0)
//        {
//            matrix[x - 1, y - 1] = 2;
//            figure--;
//        }
//    }

//}

//bool CheckEnd(int[,] matrix)//Создание функции для проверки окончания игры 
//{
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//        if (matrix[0, i] == matrix[1, i] && matrix[0, i] == matrix[2, i] && matrix[0, i] != 0)
//            return true;//Если по вертикали есть 3 одинаковых значения, конец игры 
//    }
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//        if (matrix[i, 0] == matrix[i, 1] && matrix[i, 0] == matrix[i, 2] && matrix[i, 0] != 0)
//            return true;//Если по горизонтали есть 3 одинаковых значения, конец игры 
//    }

//    if (matrix[0, 0] == matrix[1, 1] && matrix[0, 0] == matrix[2, 2] && matrix[0, 0] != 0)
//    {
//        return true;//Если по диагонали есть 3 одинаковых значения, конец игры 
//    }

//    if (matrix[0, 2] == matrix[1, 1] && matrix[0, 2] == matrix[2, 0] && matrix[0, 2] != 0)
//    {
//        return true;//Если по диагонали есть 3 одинаковых значения, конец игры 
//    }

//    return false;
//}

using System.ComponentModel;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Computer c1= new Computer("Asus",1000,"Intel I5");

//c1.HDD = 1000;
//c1.motherboard = "Asus";
//c1.CPU="Intel I5";
c1.Info();
Computer c2 = new Computer("Asus", "Inter I5");
c2.Info();
//c1.Motherboard = "Oleg";
//Console.WriteLine(c1.Motherboard);
c1.HDD = 12;
Console.WriteLine(c1.HDD);
//////////

class Computer
{
    public string Motherboard { get; set; }
    private int hdd;
    public int HDD { 
        get 
        {
            return hdd;
        }
        set
        { 
            if (value >0)
            {
                hdd = value;
            }
            else
            {
                hdd = 0;
            }
        }
    }
    public string CPU { get; set; }

    public Computer(string motherboard,int HDD, string CPU)
    {
        this.Motherboard = motherboard;
        this.HDD = HDD;
        this.CPU = CPU;
    }

    public Computer(string motherboard,string CPU)
    {
        this.Motherboard=motherboard;
        this.CPU = CPU;

    }

    public void On()
    {
        Console.WriteLine("Включение");
    }

    public void ReadingFiles( )
    {
        Console.WriteLine("Файл считался");
     }
     public void Info()
    {
        Console.WriteLine("Информация о компьютере ::");
        Console.WriteLine("Материнская плата :: " + Motherboard + " Жесткий диск :: "+ HDD + " Процессор ::" + CPU);
    }




}