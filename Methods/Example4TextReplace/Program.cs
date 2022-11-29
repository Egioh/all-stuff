string text = "Перечень необходимых работ, стоимость и сроки ремонта определяются" 
+"Исполнителем после проведения диагностики (срок диагностики не более 14 рабочих дней) и доводятся до" 
+"сведения Заказчик. При отсутствии со стороны Заказчика возражений относительно перечня работ," 
+"сроков и стоимости условия договора считаются согласованными сторонами.";
//Console.Write(text);

string replace(string Text, char oldChar, char newChar)
{
string newText = String.Empty;
int length = text.Length;
for (int i = 0; i<length; i++)
    {
        if (text[i]==oldChar) newText = newText + $"{newChar}";
        else newText = newText + $"{text[i]}";
    }
    return newText;
}
text = replace(text, ' ','*');
Console.WriteLine(text);