namespace Lesson07;

public static class MyStringExtension
{
    public static string ToUpperFirstLetter(this string str)
    {
        string newStr = "";
        if (str.Length == 0) return "";
        
        newStr = char.ToUpper(str[0])  + str.Substring(1);
        return newStr;
        
    }

    public static string AddSpaces(this string str)
    {
        string newStr = "";

        foreach (var c in str)
        {
            if (char.IsUpper(c))
                newStr += " ";
            
            newStr += c;
        }

        return newStr.Trim();
    }
}