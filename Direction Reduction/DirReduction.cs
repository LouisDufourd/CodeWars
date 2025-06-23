using System;
using System.Collections.Generic;
public class DirReduction
{

    public static string[] dirReduc(String[] arr)
    {
        List<string> directions = [..arr];

        bool isModified = false;

        do
        {
            isModified = false;
            for (int i = 0; i < directions.Count - 1; i++)
            {
                string currentDirection = directions[i].ToUpper();
                string oppositDirection = getOpposit(currentDirection);
                for (int j = 1; j < directions.Count; j++)
                {
                    string nextDirection = directions[j].ToUpper();
                    if (nextDirection.Equals(oppositDirection, StringComparison.OrdinalIgnoreCase))
                    {
                        isModified = true;
                        directions.Remove(currentDirection);
                        directions.Remove(nextDirection);
                        break;
                    }
                }
            }
        } while (isModified);
        

        return directions.Count > 0 ? directions.ToArray() : arr;
    }

    public static string getOpposit(string dir)
    {
        switch(dir.ToUpper())
        {
            case "NORTH": return "SOUTH";
            case "SOUTH": return "NORTH";
            case "WEST": return "EAST";
            case "EAST": return "WEST";
            default: return "";
        }
    }
}