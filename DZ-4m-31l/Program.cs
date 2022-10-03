

using DZ_4m_31l;
//Создание объекта класса словарь.
OtusDictionary otusDictionary = new OtusDictionary();
//Второй объект с индексацией
IndexClass indexClass = new IndexClass();

//Цикл для заполния словаря.
for (int key = 0; key <= 50; key++)
{
    otusDictionary.Add(key, RandomVord());
}

otusDictionary.Add(110, "Ключ не по порядку");
otusDictionary.Add(543, null);
//Цикл вывода в консоль.
for (int i = 0; i < otusDictionary.counter; i++)
{
    Console.WriteLine($"Элемент {otusDictionary.arrKeys[i]}");
    Console.WriteLine($"Значение {otusDictionary.Get(i)}");
}

Console.WriteLine(otusDictionary.Get(110));
Console.ReadKey();

//Вспомогательный метод для создания случайных слов.
string RandomVord()
{
    Random r = new Random();
    string s = "";
    for (int i = 0; i < 5; i++)
    {
        char a = (char)r.Next(0, 255);
        s = (a != '\n') ? s += a : s += 'G';

    }
    return s;
}


