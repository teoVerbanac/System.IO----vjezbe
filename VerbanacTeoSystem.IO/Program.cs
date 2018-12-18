using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerbanacTeoSystem.IO
{
    class Program
    {
        static void Main(string[] args)
        {
          
                /*//3.4.1 klasa Directory

                Console.Write("Unesite putanju direktorija: ");
                string putanja = Console.ReadLine();

                // Provjeravamo postoji li uneseni direktorij
                if (Directory.Exists(putanja))
                {
                    // Ispisujemo sve datoteke u direktoriju
                    Console.WriteLine("Datoteke:");
                    foreach (string datoteka in Directory.GetFiles(putanja))
                    {
                        Console.WriteLine(datoteka);
                    }

                    // Provjeravamo postoji li poddirektorij TEST
                    string putanjaPoddirektorija = putanja + "\\TEST";
                    if (!Directory.Exists(putanjaPoddirektorija))
                    {
                        // Ako ne postoji, kreiramo ga
                        Directory.CreateDirectory(putanjaPoddirektorija);
                    }

                    // Ispisujemo sve poddirektorije
                    Console.WriteLine("Poddirektoriji:");
                    foreach (string poddirektorij in Directory.GetDirectories(putanja))
                    {
                        Console.WriteLine(poddirektorij);
                    }

                    // Brišemo poddirektorij TEST
                    Directory.Delete(putanjaPoddirektorija);

                    // Ponovno ispisujemo sve poddirektorije
                    Console.WriteLine("Nakon brisanja direktorija TEST:");
                    foreach (string poddirektorij in Directory.GetDirectories(putanja))
                    {
                        Console.WriteLine(poddirektorij);
                    }
                }
                else
                {
                    Console.WriteLine("Putanja ne postoji na računalu!");
                }*/

           
                //3.4.2. klasa File

                /*Console.Write("Unesite Vaše ime: ");
                string ime = Console.ReadLine();
                string datoteka2 = "ime.txt";
                // Provjeravamo postoji li datoteka ime.txt
                if (File.Exists(datoteka2))
                {
                    // Ako postoji kopiramo ju u backup direktorij
                    if (!Directory.Exists("backup"))
                    {
                        Directory.CreateDirectory("backup");
                    }
                    File.Copy(datoteka2, "backup\\ime_"+DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss+")+ ".txt");
                    // Brišemo tu datoteku
                    File.Delete(datoteka2);
                }
                // U datoteku spremamo novo ime
                File.WriteAllText(datoteka2, ime);*/


                Console.WriteLine();
                //3.4.3 klasa Path

                Console.Write("Unesite putanju izvornog direktorija:");
                string izvorniDirektorij = Console.ReadLine();
                Console.Write("Unesite putanju ciljnog direktorija:");
                string ciljniDirektorij = Console.ReadLine();
                try
                {
                    // Kopiramo sve datoteke iz izvornog u ciljni direktorij
                    foreach (string datoteka3 in Directory.GetFiles(izvorniDirektorij))
                    {
                        // Dohvaćamo ime datoteke (bez putanje)
                        string imeDatoteke = Path.GetFileName(datoteka3);

                        // Kreiramo putanju ciljne datoteke
                        string ciljnaDatoteka = Path.Combine(ciljniDirektorij, imeDatoteke);

                        // Kopiramo datoteku s izvorne na ciljnu putanju
                        File.Copy(datoteka3, ciljnaDatoteka, true);
                    }
                    Console.WriteLine("Gotovo!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Greška: { 0}", ex.Message);
                }

                //3.4.4. klasae DirectoryInfo i FileInfo
                Console.Write("Unesite putanju direktorija: ");
                string putanja = Console.ReadLine();

                // Instanciramo DirectoryInfo objekt
                DirectoryInfo diIzvor = new DirectoryInfo(putanja);

                // Ispisujemo sve poddirektorije
                Console.WriteLine("\n-- Poddirektoriji:");
                foreach (DirectoryInfo di in diIzvor.GetDirectories())
                {
                    Console.WriteLine("{ 0}\t{ 1}\t{ 2}", di.Name, di.CreationTime, di.LastAccessTime);

                }

                // Ispisujemo sve datoteke
                Console.WriteLine("\n-- Datoteke:");
                foreach (FileInfo fi in diIzvor.GetFiles())
                {
                    Console.WriteLine("{ 0}\t{ 1}\t{ 2}", fi.Name, fi.CreationTime, fi.LastAccessTime);

                }


                Console.ReadKey();
            }
        }
   }
 
