using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4m_31l
{
    internal class OtusDictionary
    {

        //Счётчик размера
        public int counter = 0;
        //Массивы для словаря
        public int[] arrKeys = new int[32];
        private string[] arrValues = new string[32];

        //Методы словаря 
        public void Add(int key, string value)
        {
            if (value != null)
            {
                try
                {
                    arrKeys[counter] = key;
                    arrValues[counter] = value;
                    counter++;
                }
                catch
                {
                    Array.Resize(ref arrKeys, arrKeys.Length * 2);
                    Array.Resize(ref arrValues, arrValues.Length * 2);
                }

            }
            else
            {
                Console.WriteLine("Невозможно добавить null значение");
            }

        }
        public string Get(int key)
        {
            try
            {
                return arrValues[key];
            }
            catch (Exception)
            {
                return "Неверное значение ключа.";
            }
        }
    }
}
