
//Создание объекта класса словарь.
OtusDictionary otusDictionary = new OtusDictionary();

//Цикл для заполния словаря.
for (int key = 0; key <= 50; key++)
{
    otusDictionary.Add(key, RandomVord());
}

otusDictionary.Add(110, "Jopa");
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
        s += a;
    }
    return s;
}


//Класс Словарь
internal class OtusDictionary
{
    //Счётчик размера
    public int counter = 0;
    //Массивы для слова
    public int[] arrKeys = new int[32];
    private string[] arrValues = new string[32];

    //Методы словаря 
    public void Add(int key, string value)
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

