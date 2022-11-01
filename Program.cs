using System.Xml.Schema;

namespace Daily
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int position = 1;
            // делаем список задач
            List<string> aB = new List<string>() { " 6.02.1983",  "  День рождения мамы" , "  Хоккейный матч ЦСКА", "  Тренировка", "  Работа" };
            List<string> aC = new List<string>() { " 24.07.2020", "  Сдать практическую работу", "  Запись в парикмахерскую" };
            List<string> aD = new List<string>() { " 11.05.2009", "  Сдать зачёт по математике" };
            List<string> aMain = aB;
   

            Menu(aMain); //отрисавывем меню

            Console.SetCursorPosition(0, 1);
            Console.WriteLine("->");

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(); // нажали клавишу

                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (aMain == aB) {aMain = aD;}
                    else if (aMain == aD) { aMain = aC;}
                    else if (aMain == aC) {aMain = aB;}
                    position = 1;
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    if (aMain == aB)
                    { aMain = aC;}
                    else if (aMain == aC) {aMain = aD;}
                    else if (aMain == aD) {aMain = aB;}
                    position = 1;
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    Zamet(aMain,position); // рисуем заметку
                }
                Console.Clear();
                Menu(aMain);  //Отрисовывем меню
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
            }




            static void Menu(List<string> aaL)   //рисуем меню
            {
                Console.WriteLine("Выбрана дата" + aaL[0]);

                for (int i = 1; i < aaL.Count; i++)
                {
                    Console.WriteLine(aaL[i]); // выводим элементы меню из массива
                }

            }

             static void Zamet(List<string> aaL, int pos) // рисуем заметку
             {
                Console.Clear();
                Console.WriteLine("Подробная информация:");
                Console.WriteLine("---------------------");
                Console.WriteLine(aaL[0]);
                Console.WriteLine(aaL[pos]);
                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();


             }




        
        }
    }
}