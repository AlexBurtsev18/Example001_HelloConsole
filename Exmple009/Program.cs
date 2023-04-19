string text = "Попадая в ряды копирайтеров данной биржи, Вы сможете окунуться в настоящий квест-стратегию c призами,"
+ "бонусами и интересными заданиями. Нужно всего лишь набрать рейтинг,"
+ "чтобы впоследствии перейти с уровня на уровень, набирая очки за выполнение работы."
+ "Есть вероятность потерять заслуженный статус в случае отказа от заказов."
+ "Text.ru считается отличной биржей копирайтинга для новичков."
+ "Вы сможете попробовать для себя все преимущества удаленной работы. Многие азартные и творческие люди уже проверили,"
+ "как это писать тексты, общаться с заказчиками, получать первую прибыль.";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    
    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', '$');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'Л', 'Щ');
Console.WriteLine(newText);
