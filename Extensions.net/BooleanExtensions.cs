namespace Extensions.net
{
    public static class BooleanExtensions
    {
        /// <summary>
        /// Maps to bool.TryParse
        /// </summary>
        /// <param name="output"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static void TryParseExt(this ref bool output, string input) => bool.TryParse(input, out output);

        /// <summary>
        /// Maps to bool.Parse
        /// </summary>
        /// <param name="output"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static void ParseExt(this ref bool output, string input) => output = bool.Parse(input);

        /// <summary>
        /// Maps to bool.Equals
        /// </summary>
        /// <param name="output"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool EqualsExt(this bool output, bool input) => bool.Equals(output, input);
    }
}
