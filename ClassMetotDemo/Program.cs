using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassMetotDemo.Program;

namespace ClassMetotDemo
{
    internal class Program
    {
        
        static void Main(string[] args, MusteriManager musterimanager, musteriManager musteriManager)
        {
            Musteri musteri = new Musteri();
            musteri.MusteriID = 2;
            musteri.Firstname = "Ayşe";
            musteri.Lastname = "Ak";
            musteri.Age = 25;

            Musteri musteri1 = new Musteri();
            musteri1.MusteriID = 4;
            musteri1.Firstname = "Ali";
            musteri1.Lastname = "Altay";
            musteri1.Age = 45;

            Musteri[] musteriler = new Musteri[] { musteri, musteri1 };

            foreach (var Musteri in musteriler) 
            {
                Console.WriteLine(musteri.MusteriID + " ");
                Console.WriteLine(musteri.Firstname + musteri.Lastname);
                Console.WriteLine(musteri.Age);
            }

            Console.WriteLine("Müşteri Ekle");
            musteriManager.Add(musteri);
            musteriManager.Add(musteri1);
            Console.WriteLine();

            Console.WriteLine("Müşterileri Listele");
            musteriManager.List(musteri);
            musteriManager.List(musteri1);
            Console.WriteLine();

            Console.WriteLine("Müşteri Sil");
            musteriManager.Delete(musteri);
            musteriManager.Delete(musteri1);
            Console.ReadKey();
        }

        
        

    }

    internal class MusteriManager
    {
    }
}
