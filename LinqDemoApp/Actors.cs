using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemoApp
{
    static class Actors
    {
        static public void Run()
        {
            string data = @"[
			[""Harrison Ford"", 4871.7, 41, 118.8, ""Star Wars: The Force Awakens"", 936.7],
			[""Samuel L. Jackson"", 4772.8, 69, 69.2, ""The Avengers"", 623.4],
			[""Morgan Freeman"", 4468.3, 61, 73.3, ""The Dark Knight"", 534.9],
			[""Tom Hanks"", 4340.8, 44, 98.7, ""Toy Story 3"", 415],
			[""Robert Downey Jr."", 3947.3, 53, 74.5, ""The Avengers"", 623.4],
			[""Eddie Murphy"", 3810.4, 38, 100.3, ""Shrek 2"", 441.2],
			[""Tom Cruise"", 3587.2, 36, 99.6, ""War of the Worlds"", 234.3],
			[""Johnny Depp"", 3368.6, 45, 74.9, ""Dead Man's Chest"", 423.3],
			[""Michael Caine"", 3351.5, 58, 57.8, ""The Dark Knight"", 534.9],
			[""Scarlett Johansson"", 3341.2, 37, 90.3, ""The Avengers"", 623.4],
			[""Gary Oldman"", 3294, 38, 86.7, ""The Dark Knight"", 534.9],
			[""Robin Williams"", 3279.3, 49, 66.9, ""Night at the Museum"", 250.9],
			[""Bruce Willis"", 3189.4, 60, 53.2, ""Sixth Sense"", 293.5],
			[""Stellan Skarsgard"", 3175, 43, 73.8, ""The Avengers"", 623.4],
			[""Anthony Daniels"", 3162.9, 7, 451.8, ""Star Wars: The Force Awakens"", 936.7],
			[""Ian McKellen"", 3150.4, 31, 101.6, ""Return of the King"", 377.8],
			[""Will Smith"", 3149.1, 24, 131.2, ""Independence Day"", 306.2],
			[""Stanley Tucci"", 3123.9, 50, 62.5, ""Catching Fire"", 424.7],
			[""Matt Damon"", 3107.3, 39, 79.7, ""The Martian"", 228.4],
			[""Robert DeNiro"", 3081.3, 79, 39, ""Meet the Fockers"", 279.3],
			[""Cameron Diaz"", 3031.7, 34, 89.2, ""Shrek 2"", 441.2],
			[""Liam Neeson"", 2942.7, 63, 46.7, ""The Phantom Menace"", 474.5],
			[""Andy Serkis"", 2890.6, 23, 125.7, ""Star Wars: The Force Awakens"", 936.7],
			[""Don Cheadle"", 2885.4, 34, 84.9, ""Avengers: Age of Ultron"", 459],
			[""Ben Stiller"", 2827, 37, 76.4, ""Meet the Fockers"", 279.3],
			[""Helena Bonham Carter"", 2822, 36, 78.4, ""Harry Potter / Deathly Hallows(P2)"", 381],
			[""Orlando Bloom"", 2815.8, 17, 165.6, ""Dead Man's Chest"", 423.3],
			[""Woody Harrelson"", 2815.8, 50, 56.3, ""Catching Fire"", 424.7],
			[""Cate Blanchett"", 2802.6, 39, 71.9, ""Return of the King"", 377.8],
			[""Julia Roberts"", 2735.3, 42, 65.1, ""Ocean's Eleven"", 183.4],
			[""Elizabeth Banks"", 2726.3, 35, 77.9, ""Catching Fire"", 424.7],
			[""Ralph Fiennes"", 2715.3, 36, 75.4, ""Harry Potter / Deathly Hallows(P2)"", 381],
			[""Emma Watson"", 2681.9, 17, 157.8, ""Harry Potter / Deathly Hallows(P2)"", 381],
			[""Tommy Lee Jones"", 2681.3, 46, 58.3, ""Men in Black"", 250.7],
			[""Brad Pitt"", 2680.9, 40, 67, ""World War Z"", 202.4],
			[""Adam Sandler"", 2661, 32, 83.2, ""Hotel Transylvania 2"", 169.7],
			[""Daniel Radcliffe"", 2634.4, 17, 155, ""Harry Potter / Deathly Hallows(P2)"", 381],
			[""Jonah Hill"", 2605.1, 29, 89.8, ""The LEGO Movie"", 257.8],
			[""Owen Wilson"", 2602.3, 39, 66.7, ""Night at the Museum"", 250.9],
			[""Idris Elba"", 2580.6, 26, 99.3, ""Avengers: Age of Ultron"", 459],
			[""Bradley Cooper"", 2557.7, 25, 102.3, ""American Sniper"", 350.1],
			[""Mark Wahlberg"", 2549.8, 36, 70.8, ""Transformers 4"", 245.4],
			[""Jim Carrey"", 2545.2, 27, 94.3, ""The Grinch"", 260],
			[""Dustin Hoffman"", 2522.1, 43, 58.7, ""Meet the Fockers"", 279.3],
			[""Leonardo DiCaprio"", 2518.3, 25, 100.7, ""Titanic"", 658.7],
			[""Jeremy Renner"", 2500.3, 21, 119.1, ""The Avengers"", 623.4],
			[""Philip Seymour Hoffman"", 2463.7, 40, 61.6, ""Catching Fire"", 424.7],
			[""Sandra Bullock"", 2462.6, 35, 70.4, ""Minions"", 336],
			[""Chris Evans"", 2457.8, 23, 106.9, ""The Avengers"", 623.4],
			[""Anne Hathaway"", 2416.5, 25, 96.7, ""The Dark Knight Rises"", 448.1]
		]";
            List<Actor> actorList = new List<Actor>();
            JArray a = JArray.Parse(data);
            //show actors with higer than 4000 earnings
            foreach (var item in a)
            {
                Actor actor = new Actor
                {
                    name = (string)item[0],
                    totalGross = (decimal)item[1],
                    movieCout = (int)item[2],
                    avgPerMovie = (decimal)item[3],
                    topMovie = (string)item[4],
                    topMovieGros = (decimal)item[5]
                };
                actorList.Add(actor);
            }
            Console.WriteLine(actorList.Count);

            List<Actor> richActors = new List<Actor>();
            foreach (var item in actorList)
            {
                if (item.totalGross > 4000)
                {
                    richActors.Add(item);
                }
            }
            //Linq statements
            var richActors2 = from actor in actorList where actor.totalGross > 4000 orderby actor.totalGross descending select actor;
            //lambda statements
            var richActors3 = actorList.Where(a => a.totalGross > 4000);
            Console.WriteLine(printList(richActors));
            Console.WriteLine();
            Console.WriteLine(printList(richActors2));
            Console.WriteLine();
            Console.WriteLine(printList(richActors3));

            //show actors in an even number of films
            var actorsWithEvenNuber = new List<Actor>();
            foreach (var item in actorList)
            {
                if (item.movieCout % 2 == 0)
                {
                    actorsWithEvenNuber.Add(
                        new Actor
                        {
                            name = item.name,
                            movieCout = item.movieCout
                        });

                }
            }
            //using linq
            var actorsWithEvenNuber2 = from actor in actorList where actor.movieCout % 2 == 0 select new Actor { name = actor.name, movieCout = actor.movieCout };
            //using lamba statements
            var actorsWithEvenNuber3 = actorList.Where(a => a.movieCout % 2 == 0).Select(x => new Actor { name = x.name, movieCout = x.movieCout });
            Console.WriteLine();
            Console.WriteLine("show actors in an even number of films");
            Console.WriteLine(printList(actorsWithEvenNuber));
            Console.WriteLine();
            Console.WriteLine(printList(actorsWithEvenNuber2));
            Console.WriteLine();
            Console.WriteLine(printList(actorsWithEvenNuber3));
            //show star wars actors

            var starWarsActors1 = new List<Actor>();
            foreach (var item in actorList)
            {
                if (item.topMovie.Contains("Star Wars"))
                {
                    starWarsActors1.Add(new Actor { name = item.name, topMovie = item.topMovie });
                }
            }
            //using linq
            var starWarsActors2 = from actor in actorList where actor.topMovie.Contains("Star Wars") select new Actor { name = actor.name, topMovie = actor.topMovie };
            //using lambda statements
            var starWarsActors3 = actorList.Where(a => a.topMovie.Contains("Star Wars")).Select(x => new Actor { name = x.name, topMovie = x.topMovie });
            Console.WriteLine();
            Console.WriteLine("show star wars actors");
            Console.WriteLine(printList(starWarsActors1));
            Console.WriteLine();
            Console.WriteLine(printList(starWarsActors2));
            Console.WriteLine();
            Console.WriteLine(printList(starWarsActors3));

            //grouping objects together
            var groupByMovies = from actor in actorList
                                group actor by actor.topMovie into newGroup
                                orderby newGroup.Key
                                from acotrinGroup in newGroup
                                select new Actor
                                {
                                    name = acotrinGroup.name,
                                    topMovie = acotrinGroup.topMovie
                                };
            Console.WriteLine();
            Console.WriteLine("grouping objects together");
            Console.WriteLine(printList(groupByMovies));

            //group only star wars people
            var groupByStarWars= from actor in actorList
                                where actor.topMovie.Contains("S")
                                group actor by actor.topMovie into newGroup
                                orderby newGroup.Key
                                from acotrinGroup in newGroup
                                select new Actor
                                {
                                    name = acotrinGroup.name,
                                    topMovie = acotrinGroup.topMovie
                                };
            Console.WriteLine();
            Console.WriteLine(printList(groupByStarWars));

            //grouping with lambda
            var group2 = actorList.GroupBy(a => a.topMovie)
                .OrderBy(b => b.Key)
                .SelectMany(c => c)
                .Select(d => new Actor
                {
                    name = d.name,
                    topMovie = d.topMovie
                });
            Console.WriteLine();
            Console.WriteLine(printList(group2));
        }

        
        private static bool printList(IEnumerable<Actor> richActors)
        {
            foreach (var item in richActors)
            {
                Console.WriteLine(item.ToString());
            }
            return true;
        }
    }
}
