using System;
using System.Linq;
using System.Text.RegularExpressions;

public class WinningTicket
{
    public static void Main()
    {
        var tickets = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(t => t.Trim()).ToArray();

        foreach (var ticket in tickets)
        {
            if (ticket.Length != 20)
            {
                Console.WriteLine("invalid ticket");
                continue;
            }

            var left = new string(ticket.Take(10).ToArray());
            var right = new string(ticket.Skip(10).ToArray());

            var winnigSymbols = new string[] { "@", "#", "\\$","\\^" };
            var winningTicket = false;

            foreach (var symbol in winnigSymbols)
            {
                var regex = new Regex($"{symbol}{{6,}}");
                var leftMatch = regex.Match(left);
                if (leftMatch.Success)
                {
                    var rightMatch = regex.Match(right);
                    if (rightMatch.Success)
                    {
                        winningTicket = true;

                        var leftSymbolsLenght = leftMatch.Value.Length;
                        var rightSymbolsLenght = rightMatch.Value.Length;
                        var jackpot = leftSymbolsLenght == 10 && rightSymbolsLenght == 10
                            ? "Jackpot!"
                            : string.Empty;

                        Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(leftSymbolsLenght,rightSymbolsLenght)}{symbol.Trim('\\')} {jackpot}");
                        break;
                    }
                }
            }

            if (!winningTicket)
            {
                Console.WriteLine($"ticket \"{ticket}\" - no match");
            }
        }
    }
}
