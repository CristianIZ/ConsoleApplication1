using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActionsYDelegados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //var metronomo = new Metronome();
            //metronomo.Start();

            //Test.principal();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProcesarDelegados();

        }

        /* Explicacion breve
         * delegate bool Filtro(string s) equivale a Func<string, bool>.
         * Para dejar un poco más claras las cosas colocaré algunos ejemplos en código:
         * 
         * delegate int Cuenta(string a, int b); // Sería igual usar Func<string, int, int>
         * delegate char Separa(); // Es igual a usar Func<char>
         * delegate float Uhh(char a, int b, string c, double d); // Es igual a usar Func<char, int, string, double, float>
         */

        public static void ProcesarDelegados()
        {
            List<string> palabras = new List<string> { "uno", "dos", "tres", "cuatro" };
            Console.WriteLine("Palabras mayores a 3 caracteres");
            RealizaOperacionSecreta(palabras, PorTamano);

            Console.WriteLine("Palabras que comienzan con u");
            RealizaOperacionSecreta(palabras, SoloConU);
        }



        public static bool PorTamano(string s)
        {
            return s.Length > 3;
        }

        public static bool SoloConU(string s)
        {
            return s.StartsWith("u");
        }

        public static void RealizaOperacionSecreta(List<string> palabras, Func<string, bool> filtro)
        {
            foreach (string s in palabras)
            {
                if (filtro(s))
                    Console.WriteLine(s.ToUpper());
                else
                    Console.WriteLine(s);
            }
        }

        public static void RealizaOperacionSecreta(List<string> palabras, Func<string, bool> filtro, Action<string> accion)
        {
            foreach (string s in palabras)
            {
                if (filtro(s))
                    accion(s);
                else
                    Console.WriteLine(s);
            }
        }
    }
}
