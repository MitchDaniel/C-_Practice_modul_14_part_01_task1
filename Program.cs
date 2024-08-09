using System.Text.Json;

namespace CSharp_Practice_modul_14_part_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IntegerArray integerArray = new IntegerArray(5);
            //integerArray[0] = 14;
            //integerArray[1] = 23;
            //integerArray[2] = 44;
            //integerArray[3] = 53;
            //integerArray[4] = 67;
            //string json = IntegerArrayManager.Serialize(integerArray);
            //IntegerArrayManager.SaveToFile(json, @"C:\Users\Brill\Desktop\Четотам.json");

            //IntegerArray integerArray2 = IntegerArrayManager.Deserialize(json);
            //for (int i = 0; i < integerArray2.Size; i++)
            //{
            //    Console.WriteLine(integerArray2[i]);
            //}
            string json = IntegerArrayManager.LoadFromFile(@"C:\Users\Brill\Desktop\Четотам.json");
            Console.WriteLine(json);
            IntegerArray integerArray2 = IntegerArrayManager.Deserialize(json);
            for (int i = 0; i < integerArray2.Size; i++)
            {
                Console.WriteLine(integerArray2[i]);
            }
        }
    }
}

//Задание 1:
//Создайте программу для работы с массивом целых. Она должна иметь такую функциональность:
//1.Ввод массива целых с клавиатуры
//2. Фильтрация массива. В зависимости от выбора пользователя убираем простые числа или числа Фибоначчи
//3. Сериализация массива
//4. Сохранение сериализованного массива в файл
//5. Загрузка сериализованного массива из файла. После загрузки нужно произвести десериализацию
//Выбор конкретного формата сериализации необходимо сделать вам. Обращаем ваше внимание, что выбор должен быть обоснованным.