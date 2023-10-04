using System;

namespace decomposingurls
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            string exampleURL = "www.docs.microsoft.com/dotnet/csharp/whats-new/csharp-version-history";
            // string exampleURL = "";
            Console.WriteLine($"Hit ENTER to break down the URL into its component parts: {exampleURL}");
            Console.ReadKey();

            // MARK: Result
            var components = BreakdownURL(exampleURL);
            for (int i = 0; i < components.Length; i++)
            {
                var indent = new string(' ', i * 2);
                Console.WriteLine($"{indent} -> {components[i]}");
            }
        }

        // MARK: Calculation
        public static string[] BreakdownURL(string urlString)
        {
            if (String.IsNullOrEmpty(urlString)) return Array.Empty<string>();
            // string urlToParse = urlString.StartsWith("www.") ? urlString.Substring(4) : urlString;
            //
            // string[] array = urlToParse.Split('/');
            //
            // for (int i = 0; i < array.Length; i++)
            // {
            //     array[i] = array[i].Replace('-', ' ');
            // }
            //
            // return array;
            // Alternative 
            string[] arrayOfStrings = urlString.Substring(4).Replace('-', ' ').Split('/');
            return arrayOfStrings;
        }
    }
}