namespace Utilities
{
    public static class StringUtilities
    {

        public static double LongWordsCount(string input)
        {
            var split = input.Split(' ');
            return split.Count();
        }

        public static string ToSpinalCase(string input)
        {
            input = input.Replace(" ", "-");
            var spinalcase = input.ToLower();
            return spinalcase;
        }

        public static string ToSentence(string input)
        {
            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }
        public static string ToPascalCase(string input)
        {
            var split = input.Split(' ');
            var Pascal = new List<string>();
            for (int i = 0; i < split.Length; i++)
            {
                var word = ToSentence(split[i]);
                Pascal.Add(word);
            }
            return string.Join("", Pascal);
        }
    }
}