using System;

class Hewan
{
    public string nama;
    public int umur;

    public virtual void Suara()
    {
        Console.WriteLine("Hewan ini bersuara");
    }

    public void infoHewan()
    {
        Console.WriteLine($"Nama: {nama}\nUmur: {umur}");
    }
}

class Mamalia : Hewan
{
    public int jumlahKaki;

    public override void Suara()
    {
        Console.WriteLine("Mamalia ini bersuara");
    }
}

class Reptil : Hewan
{
    public double panjangTubuh;

    public override void Suara()
    {
        Console.WriteLine("Reptil ini bersuara");
    }
}

class Singa : Mamalia
{
    public override void Suara()
    {
        Console.WriteLine("Mengaum");
    }

    public void Mengaum()
    {
        Console.WriteLine("Aummm");
    }
}

class Gajah : Mamalia
{
    public override void Suara()
    {
        Console.WriteLine("Pruum");
    }
}

class Ular : Reptil
{
    public override void Suara()
    {
        Console.WriteLine("Sssshhhh");
    }

    public void Merayap()
    {
        Console.WriteLine("Ular sedang merayap");
    }
}

class Buaya : Reptil
{
    public override void Suara()
    {
        Console.WriteLine("Ada yang marah?");
    }
}

class KebunBinatang
{
    public List<Hewan> koleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        foreach (var hewan in koleksiHewan)
        {
            hewan.infoHewan();
            if (hewan is Mamalia mamalia)
            {
                Console.WriteLine($"Jumlah Kaki: {mamalia.jumlahKaki}");
            }
            else if (hewan is Reptil reptil)
            {
                Console.WriteLine($"Panjang Tubuh: {reptil.panjangTubuh}");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();

        Singa singa1 = new Singa();
        singa1.nama = "Singaraja";
        singa1.umur = 5;
        singa1.jumlahKaki = 4;

        Gajah gajah1 = new Gajah();
        gajah1.nama = "Gajahmu";
        gajah1.umur = 10;
        gajah1.jumlahKaki = 4;

        Ular ular1 = new Ular();
        ular1.nama = "Piton";
        ular1.umur = 3;
        ular1.panjangTubuh = 2.5;

        Buaya buaya1 = new Buaya();
        buaya1.nama = "Buaya Darat";
        buaya1.umur = 8;
        buaya1.panjangTubuh = 3.0;

        kebunBinatang.TambahHewan(singa1);
        kebunBinatang.TambahHewan(gajah1);
        kebunBinatang.TambahHewan(ular1);
        kebunBinatang.TambahHewan(buaya1);

        Console.WriteLine("Daftar Hewan di Kebun Binatang:");
        kebunBinatang.DaftarHewan();

        Console.WriteLine("\nAnalisis 1");
        gajah1.Suara();
        ular1.Suara();

        Console.WriteLine("\nAnalisis 2");
        singa1.Mengaum();

        Console.WriteLine("\nAnalisis 3");
        singa1.infoHewan();
        Console.WriteLine($"Jumlah Kaki: {singa1.jumlahKaki}");

        Console.WriteLine("\nAnalisis 4");
        ular1.Merayap();

        Console.WriteLine("\nAnalisis 5");
        Reptil reptil = buaya1;
        reptil.Suara();
    }
}
