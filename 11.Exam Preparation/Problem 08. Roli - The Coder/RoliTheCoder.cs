using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class RoliTheCoder
{
    public static void Main()
    {
        string inputPattern = @"(?<id>\d+)\s+#(?<eventName>[\w\d]+)(\s+(?:@\w+\s*)+)?";
        string input = Console.ReadLine();



        var events = new Dictionary<int, Event>();
        while (input != "Time for Code")
        {
            var eventDetails = Regex.Match(input, inputPattern);

            if (eventDetails.Success)
            {
                var id = int.Parse(eventDetails.Groups["id"].Value);
                var eventName = eventDetails.Groups["eventName"].Value;
                var participants = new string[0];

                var eventHasParticipants = input.Contains("@");
                if (eventHasParticipants)
                {
                    participants = input.Substring(input.IndexOf('@')).Split().Where(a => a != string.Empty).ToArray();
                }

                var currentEvent = new Event()
                {
                    Name = eventName,
                    Participants = participants.ToList()
                };

                if (!events.ContainsKey(id))
                {
                    events[id] = new Event()
                    {
                        Name = eventName,
                        Participants = new List<string>(new string[0])
                    };
                }

                if (events[id].Name == eventName)
                {
                    events[id].Participants.AddRange(participants);
                    events[id].Participants = events[id].Participants.Distinct().ToList();
                }  
            }

            input = Console.ReadLine();
        }

        var sordtedEvents = events.OrderByDescending(a => a.Value.Participants.Count).ThenBy(a => a.Value.Name).ToArray();

        foreach (var @event in sordtedEvents)
        {
            var eventName = @event.Value.Name;
            var sortedParticipants = @event.Value.Participants.OrderBy(a => a);

            Console.WriteLine($"{eventName} - {sortedParticipants.Count()}");
            foreach (var participant in sortedParticipants)
            {
                Console.WriteLine(participant);
            }

        }
    }
}
    public class Event
    {
        public string Name { get; set; }
        public List<string> Participants { get; set; }
    }