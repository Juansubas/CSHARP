using Practicee.Errors;
using Practicee.Models;
using Practicee.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text.Json;
using System.Threading.Tasks;

namespace Practicee
{
    public static class Program
    {
        public class Beer
        {
            public string Name { get; set; }
            public int Alcohol { get; set; }
        }
        static async Task Main(string[] args)
        {
            var beers = new List<Beer>()
            {
                new Beer() { Name = "Ipa", Alcohol = 7},
                new Beer() { Name = "Pale ale", Alcohol = 8},
                new Beer() { Name = "Stout", Alcohol = 9},
                new Beer() { Name = "Tripel", Alcohol = 15}
            };

            ShowBeerThatIGetDrunk(beers, x => x.Alcohol >= 8);
        }

        static void ShowBeerThatIGetDrunk(this List<Beer> beers, Predicate<Beer> condition)
        {
            var evilBeers = beers.FindAll(condition);
            evilBeers.ForEach(d => Console.WriteLine(d.Name));
        }
    }
}
