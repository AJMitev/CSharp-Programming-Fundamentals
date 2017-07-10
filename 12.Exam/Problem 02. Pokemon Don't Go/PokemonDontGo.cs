using System;
using System.Collections.Generic;
using System.Linq;

    public class PokemonDontGo
    {
        public static void Main()
        {
            var numberArray = Console.ReadLine().Split().Select(long.Parse).ToList();

            var removedPokemons = new List<long>();

            while (numberArray.Count > 0)
            {

                int currentIndex = int.Parse(Console.ReadLine());

                if (currentIndex < 0)
                {
                    long lastElem = numberArray[numberArray.Count - 1];

                    numberArray.RemoveAt(0);
                    numberArray.Insert(0, lastElem);

                    removedPokemons.Add(lastElem);

                    for (int i = 0; i < numberArray.Count; i++)
                    {
                        if (numberArray[i] <= lastElem)
                        {
                            numberArray[i] += lastElem;
                        }
                        else
                        {
                            numberArray[i] -= lastElem;
                        }
                    }
                    continue;
                }

                if (currentIndex >= numberArray.Count)
                {
                    long firstElem = numberArray[0];

                    numberArray.RemoveAt(numberArray.Count - 1);
                    numberArray.Insert(numberArray.Count, firstElem);

                    removedPokemons.Add(firstElem);

                    for (int i = 0; i < numberArray.Count; i++)
                    {
                        if (numberArray[i] <= firstElem)
                        {
                            numberArray[i] += firstElem;
                        }
                        else
                        {
                            numberArray[i] -= firstElem;
                        }
                    }
                    continue;
                }

                long currItem = numberArray[currentIndex];
                removedPokemons.Add(currItem);
                numberArray.RemoveAt(currentIndex);

                for (int i = 0; i < numberArray.Count; i++)
                {
                    if (numberArray[i] <= currItem)
                    {
                        numberArray[i] += currItem;
                    }
                    else
                    {
                        numberArray[i] -= currItem;
                    }
                }
            }

            long sum = removedPokemons.Sum();

            Console.WriteLine(sum);
        }
    }