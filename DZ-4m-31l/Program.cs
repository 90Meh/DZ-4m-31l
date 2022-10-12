

using DZ_4m_31l;
//Создание объекта класса словарь.
OtusDictionary<int> otusDictionary = new OtusDictionary<int>();
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
Console.WriteLine(otusDictionary[1]);


//Второй объект с индексацией
IndexClass.Dict<int> dict = new IndexClass.Dict<int>();

//Заполнение второго словаря
for (int i = 0; i < 50; i++)
{
    dict.Add(i, RandomVord());
}

dict.Add(110, "Ключ не по порядку");
dict.Add(543, null);

//Вывод на консоль второго словаря
for (int i = 0; i < 50; i++)
{
    Console.WriteLine($"Элемент {i}");
    Console.WriteLine($"Значение {dict.Get(i)}");
}

//Получение значения по индексу и с помощью метода Get
Console.WriteLine(dict[5].Value);
Console.WriteLine(dict.Get(5));

Console.WriteLine("110 ключ");
Console.WriteLine(dict.Get(110));
Console.WriteLine(dict.Get(543));


//Работа с индексатором OtusDictionary
otusDictionary[0] = "dsdfds";
otusDictionary[1] = "2";
Console.WriteLine(otusDictionary[0]);
Console.WriteLine(otusDictionary.Get(0));
Console.WriteLine(otusDictionary[1]);
Console.WriteLine(otusDictionary.Get(1));
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


