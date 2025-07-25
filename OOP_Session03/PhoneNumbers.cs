
    internal struct PhoneBook
    {
     string[] names;
    long[] numbers;
    int _size;
    //create parameter constructor
    public PhoneBook(int size)
    {
        names = new string[size];
        numbers = new long[size];
        _size = size;
    }
    //indexer property
    public long this[string name]
    {
        get
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == (name))
                {
                    return numbers[i];
                }

            }

            return -1;
        }
        set
        {

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == (name))
                {
                    numbers[i] = value;
                }

            }
        }
    }
    public string this[int index]
    {
        get
        {
            return $"index: {index}, Name: {names[index]},Number: {numbers[index]}";
        }
    }
    //function to get size
    public int getSize()
    {
        return _size;
    }
    //function to add name and phoneNumber
    public void AddPerson(string name, long number, int position)
    {
        if (position >= 0 && position < _size)
        {
            names[position] = name;
            numbers[position] = number;
        } }
        // function to get phone of spesfic name
       public long GetPhoneNumber(string name)
        {
        //  int index =Array.IndexOf(names, name);
        // long phoneNumber = numbers[index];
        for (int i=0;i< names.Length; i++)
        {
            if (names[i]==(name))
            {
                return numbers[i];
            }
            
        }

        return -1;


    }
    public void UpdatePhoneNumber(string name,long number)
    {
     
        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] == (name))
            {
                 numbers[i]=number;
            }

        }


    }
}

