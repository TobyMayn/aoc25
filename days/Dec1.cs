using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace aoc25
{
    public class Dec1
    {
        string[] lines;
        public Dec1(string filePath)
        {
            lines = readInput(filePath);
        }

        private string[] readInput(string filePath)
        {
            try
            {
                return File.ReadAllLines(filePath);

            } catch (FileNotFoundException)
            {
                System.Console.WriteLine($"Input file not found: {filePath}");
                return new string[] { };

            } catch (IOException e)
            {
                System.Console.WriteLine("An error occurred while reading the file:");
                System.Console.WriteLine(e.Message);
                return new string[] { };
            }
        }

        public int Run()
        {
            int i = 50;
            int code = 0;
            var re = new Regex(@"(?<direction>(R|L))(?<steps>\d+)");
            foreach (string line in lines)
            {
                var reMatch = re.Match(line);

                if (reMatch.Groups["direction"].Value == "R")
                {
                    i = (i + int.Parse(reMatch.Groups["steps"].Value)) % 100;
                } else
                {
                    i = (i - int.Parse(reMatch.Groups["steps"].Value)) % 100;
                    if (i < 0) i += 100;
                }
                if (i == 0) code++; 
            }

            return code;

        }
    }
}