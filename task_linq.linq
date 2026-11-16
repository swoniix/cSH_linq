<Query Kind="Program" />

class firm
{
    public string name;
    public int days_ago;
    public string business;
    public string director;
    public int employees;
    public string address;
}

void Main()
{
    firm[] firms =
    {
        new firm
        {
            name = "White Food",
            days_ago = 123,
            business = "Marketing",
            director = "Anna White",
            employees = 150,
            address = "London"
        },

        new firm
        {
            name = "Black and White IT",
            days_ago = 1460,
            business = "IT",
            director = "John Black",
            employees = 120,
            address = "London"
        },

        new firm
        {
            name = "Green Food Market",
            days_ago = 365,
            business = "Marketing",
            director = "Mary Green",
            employees = 90,
            address = "Oxford"
        },

        new firm
        {
            name = "Bright Finance",
            days_ago = 1825,
            business = "Finance",
            director = "Peter Brown",
            employees = 45,
            address = "Bristol"
        }
    };


    // Отримати інформацію про всі фірми
    var result1 =
        from item in firms
        select item;

    result1.Dump("все фирмы");


    // Отримати фірми, які мають у назві слово «Food»
    var result2 =
        from item in firms
        where item.name.Contains("Food")
        select item;

    result2.Dump("фирмы со словом Food");


    // Отримати фірми, які працюють у галузі маркетингу
    var result3 =
        from item in firms
        where item.business == "Marketing"
        select item;

    result3.Dump("фирмы в области маркетинга");


    // Отримати фірми, які працюють у галузі маркетингу або IT
    var result4 =
        from item in firms
        where item.business == "Marketing" || item.business == "IT"
        select item;

    result4.Dump("фирмы в области маркетинга или IT");


    // Отримати фірми з кількістю працівників більшою, ніж 100
    var result5 =
        from item in firms
        where item.employees > 100
        select item;

    result5.Dump("фирмы, где больше 100 работников");


    // Отримати фірми з кількістю працівників у діапазоні від 100 до 300
    var result6 =
        from item in firms
        where item.employees >= 100 && item.employees <= 300
        select item;

    result6.Dump("фирмы от 100 до 300 работников");


    // Отримати фірми, які знаходяться в Лондоні
    var result7 =
        from item in firms
        where item.address == "London"
        select item;

    result7.Dump("фирмы в Лондоне");


    // Отримати фірми, в яких прізвище директора White
    var result8 =
        from item in firms
        where item.director.EndsWith("White")
        select item;

    result8.Dump("фирмы с директором White");


    // Отримати фірми, які засновані більше двох років тому
    var result9 =
        from item in firms
        where item.days_ago > 730
        select item;

    result9.Dump("фирмы, основанные больше двух лет назад");


    // Отримати фірми, з дня заснування яких минуло 123 дні
    var result10 =
        from item in firms
        where item.days_ago == 123
        select item;

    result10.Dump("фирмы, основанные 123 дня назад");


    // Отримати фірми, в яких прізвище директора Black і мають у назві фірми слово «White»
    var result11 =
        from item in firms
        where item.director.EndsWith("Black")
            && item.name.Contains("White")
        select item;

    result11.Dump("директор Black и слово White в названии");
}