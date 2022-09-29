using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4m_31l
{
    internal class IndexClass
    {
        //Элемент коллекции
        class CellDict
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }
        //Класс словарь
        class Dict
        {
            //Изначальный массив объектов
            private CellDict[] cellDicts = new CellDict[32];

            public CellDict this[int i]
            {
                get { return cellDicts[i]; }
                set { cellDicts[i] = value; }
            }

            //Методы словаря

            private void _resize()
            {
                // формируем массив в два раза длинееееееее
                CellDict[] newDictItems = new CellDict[cellDicts.Length * 2];

                // в цикле мы заново перераспределяем элементы
                foreach (var di in cellDicts)
                {
                    // элемент может отсутствовать
                    if (di != null)
                    {
                        int index = di.Key % newDictItems.Length;
                        newDictItems[index] = di;
                    }
                }

                // перезаписываем старый массив новым
                cellDicts = newDictItems;
            }
            public void Add(int key, string value)
            {
                int index = key % cellDicts.Length;
                var cell = new CellDict();
                cell.Key = key;
                cell.Value = value;
                if (cellDicts[index] != null)
                {
                    if (cellDicts[index].Key == key)
                    {
                        throw new Exception(String.Format("Элемент с индексом {0} существует", key));
                    }
                    _resize(); // перестраиваем весь массив, освобождая нужный индекс
                    index = key % cellDicts.Length; // рассчитываем новый индекс
                }
                {

                }
                cellDicts[index] = cell;
            }
            public void Get()
            {

            }

            
        }

    }

}

