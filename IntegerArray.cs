using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace CSharp_Practice_modul_14_part_01
{
    [Serializable]
    internal class IntegerArray
    {
       
        int[] _array;

        public int[] Array
        {
            get => _array;
            set => _array = value;
        }
        public int Size { get; set; }

        public IntegerArray(int size) 
        { 
            Size = size;
            _array = new int[Size];
        }


        public int this[int index]
        {
            set
            {
                if (index > _array.Length || index < 0) throw new ArgumentOutOfRangeException();
                _array[index] = value;
            }
            get
            {
                if (index > _array.Length || index < 0) throw new ArgumentOutOfRangeException();
                return _array[index];
            }
        }

        public int[] Filter(Predicate<int> predicate)
        {
            if (predicate is null) throw new ArgumentNullException();
            List<int> temp = new List<int>();
            foreach (int i in _array)
            {
                if (predicate(i))
                {
                    temp.Add(i); 
                }
            }
            return temp.ToArray();
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