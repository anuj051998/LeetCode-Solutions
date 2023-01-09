using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    public const char SPACE_CHAR = ' ';
    /// <summary>
    /// Split the words to array
    /// </summary>
    /// <param name="words">array of wrods</param>
    /// <param name="maxWidth">width</param>
    /// <returns>List of string builder</returns>
    public IList<IList<string>> SpliToArray(string[] words, int maxWidth)
    {
        IList<IList<string>> stringBuilders = new List<IList<string>>();
        int index = 0; // start with index 0
        int length = 0; // length = 0
        for (int i = 0; i < words.Length; i++) // go through each words
        {
            length += words[i].Length + 1;
            if (length > maxWidth)
            {
                index++;
                length = words[i].Length;
            }
            if (stringBuilders.Count == index)
            {
                stringBuilders.Add(new List<string>());
            }
            stringBuilders[index].Add($"{words[i]}{SPACE_CHAR}");
        }
        return stringBuilders;
    }

    public string GetSpace(int count)
    {
        return new string(SPACE_CHAR, count);
    }

    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        IList<IList<string>> wordsAsList = SpliToArray(words, maxWidth);
        IList<string> result = new List<string>();
        for (int i = 0; i < wordsAsList.Count; i++)
        {
            StringBuilder stringBuilder = new();
            int letterCount = wordsAsList[i].Select(x => x.Length).Sum();
            int numberOfSpaceRequired = maxWidth - letterCount;
            if (numberOfSpaceRequired > 0)
            {
                _ = stringBuilder.Append(wordsAsList[i][0]);
                int wordCount = wordsAsList[i].Count > 1 ? wordsAsList[i].Count : 1;
                int numberOfSpacesRequiredPerWord = numberOfSpaceRequired / wordCount;
                if (numberOfSpaceRequired % wordCount != 0)
                {
                    _ = stringBuilder.Append(GetSpace(numberOfSpaceRequired % wordCount));
                }
                _ = stringBuilder.Append(GetSpace(numberOfSpacesRequiredPerWord));
                for (int j = 1; j < wordCount; j++)
                {
                    _ = stringBuilder.Append(wordsAsList[i][j]);
                    _ = stringBuilder.Append(GetSpace(numberOfSpacesRequiredPerWord));
                }
            }

            else
            {
                _ = stringBuilder.Append(string.Join(string.Empty, wordsAsList[i]));
            }
            result.Add(stringBuilder.ToString());
        }
        return result;
    }
}