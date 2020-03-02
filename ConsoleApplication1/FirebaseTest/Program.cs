using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;

namespace FirebaseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DBContext<Dinosaur>();

            context.Save(new Dinosaur() { Altura = "125", Nombre = "T-Rex" });

        }

        public async static void asd()
        {
            var firebase = new FirebaseClient("https://dinosaur-facts.firebaseio.com/");



            var dinos = await firebase.Child("dinosaurs")
                        .OrderByKey()
                        .StartAt("pterodactyl")
                        .LimitToFirst(2)
                        .OnceAsync<Dinosaur>();

            foreach (var dino in dinos)
            {
                Console.WriteLine($"{ dino.Key} is { dino.Object.Altura }m high.");
            }

            firebase = new FirebaseClient("https://dinosaur-facts.firebaseio.com/");
            var dinos2 = await firebase
               .Child("dinosaurs")
               .OrderByKey()
               .StartAt("pterodactyl")
               .LimitToFirst(2)
               .OnceAsync<Dinosaur>();
            foreach (var dino in dinos2)
            {
                Console.WriteLine($"{ dino.Key} is { dino.Object.Altura }m high.");
            }
        }

    }

    public class Dinosaur
    {
        //[JsonProperty("height")]
        public string Nombre { get; set; }
        public string Altura { get; set; }
    }
}
