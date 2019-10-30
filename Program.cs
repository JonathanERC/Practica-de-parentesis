using System;
using System.IO;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Globalization;
using System.Text.RegularExpressions;


namespace parentesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Original();
            SP();
            CP();
            SCP();
            EOF();
        }

        static public void Original()
        {
            //archivo
            string ruta = @".\caracteres.txt";
            //string text = File.ReadAllText(ruta);
            string[] lines = File.ReadAllLines(ruta);
            //muestra texto original
            var contador = 0;
            Console.WriteLine("------------Texto original------------");
            foreach (string line in lines)
            {
                Console.WriteLine(contador++ + " - " + line);
            }
            Console.WriteLine("------------Texto original------------");
        }

        static public void SP()
        {
            //archivo
            string ruta = @".\caracteres.txt";
            //string text = File.ReadAllText(ruta);
            string[] lines = File.ReadAllLines(ruta);
            //muestra texto original            

            var contador = 0;
            //muestra solo dentro del parentesis
            Console.WriteLine("\n");
            Console.WriteLine("------------Sin parentesis------------");
            foreach (string line in lines)
            {
                var sp = line.ToString().Replace("("," ").Replace(")", " ");
                Console.WriteLine(contador++ + " - " + sp);
            }
            Console.WriteLine("------------Sin parentesis------------");
        }

        static public void CP()
        {
            //archivo
            string ruta = @".\caracteres.txt";
            //string text = File.ReadAllText(ruta);
            string[] lines = File.ReadAllLines(ruta);
            //muestra texto original            

            var contador = 0;
            //muestra solo contenido dentro del parentesis
            Console.WriteLine("\n");
            Console.WriteLine("------------Contenido del parentesis------------");
            foreach (string line in lines)
            {
                var cp = line.Substring(line.IndexOf("(") + 1);
                var cpp = cp.Substring(0, cp.LastIndexOf(")"));
                Console.WriteLine(contador++ + " - " + cpp);
            }
            Console.WriteLine("------------Contenido del parentesis------------");
        }

        static public void SCP()
        {
            //archivo
            string ruta = @".\caracteres.txt";
            //string text = File.ReadAllText(ruta);
            string[] lines = File.ReadAllLines(ruta);
            //muestra texto original            

            var contador = 0;
            //no muestra contenido dentro del parentesis
            Console.WriteLine("\n");
            Console.WriteLine("------------Sin contenido del parentesis------------");
            foreach (string line in lines)
            {
                string regex = "('.*')|(\\(.*\\))";
                Regex rgx = new Regex(regex);
                string scp = rgx.Replace(line, " ");

                Console.WriteLine(contador++ + " - " +  scp);
            }
            Console.WriteLine("------------Sin contenido del parentesis------------");
        }

        static public void EOF()
        {
            //EOF
            Console.ReadLine();
        }
    }
}
