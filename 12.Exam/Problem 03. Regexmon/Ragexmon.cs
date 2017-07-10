using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

  public class Ragexmon
    {
        public static void Main()
        {
            string didimonPattern = @"[^a-zA-Z-]+";
            string bojomonPattern = @"[a-zA-Z]{1,}\-[a-zA-Z]{1,}";

            string input = Console.ReadLine();

            var result = new List<string>();

            while (true)
            {
                var didiMatches = Regex.Match(input, didimonPattern);

                if (!didiMatches.Success)
                {
                    break;
                }

                Console.WriteLine(didiMatches.Value);

                input = input.Substring(didiMatches.Index + didiMatches.Length);

                var bojoMatches = Regex.Match(input, bojomonPattern);

                if (!bojoMatches.Success)
                {
                    break;
                }

                Console.WriteLine(bojoMatches.Value);
                input = input.Substring(bojoMatches.Index + bojoMatches.Length);
            }


        }
    }