
public static class CustomStringMethods
{
    // Özel bir metot örneği: Bir metin içinde belirli bir alt metni arama
    public static bool ContainsSubstring(this string str, string substring)
    {
        return str.Contains(substring);
    }

    // Özel bir metot örneği: Metindeki boşlukları kaldırma
    public static string RemoveSpaces(this string str)
    {
        return str.Replace(" ", string.Empty);
    }

    // Daha fazla özel metot ekleyebilirsiniz
}
