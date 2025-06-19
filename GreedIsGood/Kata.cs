using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GreedIsGood
{
    class Kata
    {
        public static int Score(int[] dice)
        {
            var result = new Dictionary<string, int>();
            var score = 0;

            foreach (var number in dice)
            {
                string value = Value($"1 {number}", result);
                if (result.ContainsKey(value))
                {
                    result[value]++;
                }
                else result[value] = 1;
            }

            foreach (var keyValue in result)
            {
                score += ValueToScore(keyValue);
            }

            return score;
        }

        public static int ValueToScore(KeyValuePair<string, int> pair)
        {
            string key = pair.Key.Split(' ')[1];
            int keyValue = int.Parse(key);

            if (pair.Value < 3)
            {
                switch(keyValue)
                {
                    case 1: return 100 * pair.Value;
                    case 5: return 50 * pair.Value;
                    default: return 0;
                }
            }

            int score = 0;

            if (keyValue == 1)
            {
                score = 1000;
            }
            else
            {
                score = 100 * keyValue;
            }

            return score;
        }

        public static string Value(string firstKey, Dictionary<string, int> keyValuePairs)
        {
            string currentKey = firstKey;

            int i = 0;

            while(keyValuePairs.ContainsKey(currentKey) && i < 3)
            {
                if (keyValuePairs[currentKey] < 3)
                {
                    return currentKey;
                }

                var regex = new Regex(Regex.Escape($"{i}"));
                currentKey = regex.Replace(currentKey, $"{i + 1}", 1);
                i++;
            }

            return currentKey;
        }
    }
}
