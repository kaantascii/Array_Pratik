public class Program
{
    public static void Main(string[] args)
    {
        // Dizi tanımlama ve eleman ekleme
        int[] sayilar = new int[10];
        for (int i = 0; i < sayilar.Length; i++)
        {
            // Kullanıcıdan sayı alma
            Console.Write($"[{i + 1}] . sayıyı gir: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("\nGirdiğiniz sayılar:");
        foreach (int sayi in sayilar) // Dizi elemanlarını yazdırma
        {
            Console.Write(sayi + " "); //sayıları boşlukla ayırarak yazdırma
        }
        Console.Write("\n \n11. sayıyı girin :");
        int yeniSayi = Convert.ToInt32(Console.ReadLine());

        // Diziye yeni eleman ekleme
        int[] yeniDizi = new int[11];
        for (int i = 0; i < sayilar.Length; i++)
        {
            yeniDizi[i] = sayilar[i]; // Eski diziden elemanları yeni diziye kopyalama
        }
        yeniDizi[10] = yeniSayi; // Yeni sayıyı son elemana ekleme
        sayilar = yeniDizi; // Eski diziyi yeni dizi ile güncelleme
        Console.WriteLine("\nGüncellenmiş dizi:");

        Array.Sort(sayilar); // Diziyi sıralama
        Array.Reverse(sayilar); // Diziyi ters çevirme

        Console.WriteLine("\nBüyükten küçüğe sıralı: ");
        foreach (int sayi in sayilar) // Güncellenmiş diziyi yazdırma
        {
            Console.Write(sayi + " "); //sayıları boşlukla ayırarak yazdırma
        }
    }
}
