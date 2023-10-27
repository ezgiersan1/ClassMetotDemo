using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassMetotDemo.Program;

namespace ClassMetotDemo
{
    class musteriManager
    {
        Musteri musteri = new Musteri();
       public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Firstname + musteri.LastName + "Müşteri Eklendi");
        }

        public void List(Musteri musteri)
        {
            Console.WriteLine(musteri.Firstname + musteri.Lastname + musteri.MusteriID);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.FirstName + musteri.Lastname + "Müşteri Silindi");
        }
       
    }
}
