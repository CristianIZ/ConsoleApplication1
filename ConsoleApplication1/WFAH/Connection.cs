using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Database.Extensions;
using Firebase.Database.Http;
using Firebase.Database.Offline;
using Firebase.Database.Streaming;
using Firebase.Database.Offline.Internals;
using Firebase.Auth;

namespace WFAH
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Conectar();
        }

        private async void Conectar()
        {
            var firebase = new FirebaseClient("https://micancha-39ba8.firebaseio.com/");
            var observable = firebase
              .Child("dinosaurs")
              .AsObservable<Dinosaur>()
              .Subscribe(d => Console.WriteLine(d.Key));

            //var authProvider = new FirebaseAuthProvider(new FirebaseConfig("AAAA_2zAT_A:APA91bEvTCtdwEa8SCWpvIgc8O7IVx1MRTsdnS_KoaE9u-898bw975g6qER6rkJwIolEh6GRIHlIpkWRggh3yVxnY7mmEMlyzbFrqMcsshLI8qgNNit9VlxEmu6dQoSBpJt8PX-fqDyL"));
            //var facebookAccessToken = "<login with facebook and get oauth access token>";
            //
            //var auth = await authProvider.SignInWithOAuthAsync(FirebaseAuthType.Facebook, facebookAccessToken);
            //
            //var firebase = new FirebaseClient(
            //  "https://micancha-39ba8.firebaseio.com/",
            ///*"https://dinosaur-facts.firebaseio.com/"*/
            //new FirebaseOptions
            //{
            //    AuthTokenAsyncFactory = () => Task.FromResult(auth.FirebaseToken)
            //});
            //
            //var dinos = await firebase
            //  .Child("dinosaurs")
            //  .OnceAsync<Dinosaur>();
            //
            //foreach (var dino in dinos)
            //{
            //    Console.WriteLine($"{dino.Key} is {dino}m high.");
            //}
        }
    }

    public class Dinosaur
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
