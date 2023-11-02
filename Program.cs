using System;
using System.Collections.Generic;

namespace generic_list;

class Program
{
    static void Main(string[] args)
    {
        /*
            List<T> class
            System.Collections.Generic
            T => object türündedir.
        */
        List<int> sayiListesi = new List<int>();
        sayiListesi.Add(23);
        sayiListesi.Add(10);
        sayiListesi.Add(4);
        sayiListesi.Add(5);
        sayiListesi.Add(92);
        sayiListesi.Add(34);

        List<string> renkListesi = new List<string>();
        renkListesi.Add("Kırmızı");
        renkListesi.Add("Mavi");
        renkListesi.Add("Turuncu");
        renkListesi.Add("Sarı");
        renkListesi.Add("Yeşil");

        // Count
        Console.WriteLine(sayiListesi.Count);
        Console.WriteLine(renkListesi.Count);

        // ForEach ve List.ForEach ile elemanlara erişim
        foreach (int sayi in sayiListesi)
            Console.WriteLine(sayi);

        foreach (string renk in renkListesi)
            Console.WriteLine(renk);

        sayiListesi.ForEach(Console.WriteLine);
        renkListesi.ForEach(Console.WriteLine);

        // Listeden eleman çıkarma
        sayiListesi.Remove(4);
        renkListesi.Remove("Yeşil");

        sayiListesi.RemoveAt(0);
        renkListesi.RemoveAt(1);

        sayiListesi.ForEach(Console.WriteLine);
        renkListesi.ForEach(Console.WriteLine);

        // Liste içerisinde arama
        if (sayiListesi.Contains(10))
            Console.WriteLine("10 değeri liste içerisinde buludu!");

        // Eleman ile index'e erişme
        Console.WriteLine(renkListesi.BinarySearch("Sarı"));

        // Diziyi List'e çevirme
        string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};
        List<string> hayvanListesi = new List<string>(hayvanlar);

        // Listeyi temizleme
        hayvanListesi.Clear();

        // Liste içerisinde nesne tutmak
        List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

        Kullanicilar kullanici1 = new Kullanicilar();
        kullanici1.Isim = "Vahdet";
        kullanici1.Soyisim = "Savcı";
        kullanici1.Yas = 22;

        Kullanicilar kullanici2 = new Kullanicilar();
        kullanici2.Isim = "Berkay";
        kullanici2.Soyisim = "Çimen";
        kullanici2.Yas = 26;

        kullaniciListesi.Add(kullanici1);
        kullaniciListesi.Add(kullanici2);

        List<Kullanicilar> yeniKullanicilar = new List<Kullanicilar>();

        yeniKullanicilar.Add(new Kullanicilar(){
            Isim = "Esmanur",
            Soyisim = "Kibar",
            Yas = 10
        });

        foreach (Kullanicilar kullanici in kullaniciListesi)
        {
            Console.WriteLine("Kullanıcı Adı: " + kullanici.Isim);
            Console.WriteLine("Kullanıcı Soyadı: " + kullanici.Soyisim);
            Console.WriteLine("Kullancı Yaş: " + kullanici.Yas);
        }

        yeniKullanicilar.Clear();
    }
}

class Kullanicilar
{
    private string isim;
    private string soyisim;
    private int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
}
