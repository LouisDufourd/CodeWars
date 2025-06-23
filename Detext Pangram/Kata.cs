public static class Kata
{
    public static bool IsPangram(string str)
    {
        bool doesContainAllChar = true;

        for (int i = 0; i < 26; i++)
        {
            char currentLowercaseChar = (char)(97 + i);
            char currentUppercaseChar = (char)(65 + i);

            if (!str.Contains(currentUppercaseChar) && !str.Contains(currentLowercaseChar))
            {
                doesContainAllChar = false;
                break;
            }
        }

        return doesContainAllChar;
    }
}