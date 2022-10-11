// пример с 4 видом

string Method4(int count, string text)
{

    string result = String.Empty;
    for (int i = 0; i < count; i++)

    {
        result = result + text;

    }
    return result;
}
string res = Method4(10, "Z");
Console.WriteLine(res);