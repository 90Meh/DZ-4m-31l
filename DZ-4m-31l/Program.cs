
OtusDictionary otusDictionary = new OtusDictionary();


class OtusDictionary
{
    public int counter = 0;
    //Массивы для слова
    private int[] arrKeys = new int[32];
    private string[] arrValues = new string[32];

    //Методы словаря 
    public void Add(int key, string value)
    {
        arrKeys[counter] = key;
        arrValues[counter] = value;
        counter++;
    }
    public string Get(int key)
    {
        return "";

    }
}

