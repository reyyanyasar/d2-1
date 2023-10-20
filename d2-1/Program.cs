//// See https://aka.ms/new-console-template for more information
//using System.Diagnostics;

//Console.WriteLine("Hello, World!");
////Console.WriteLine("Lütfen yaşınızı giriniz.");
////int yas = Convert.ToInt32(Console.ReadLine());

////if (yas < 18)
////{
////    Console.WriteLine("Ehliyet alamaz");
////}
////else
////{
////    Console.WriteLine("Ehliyet alailir.");
////}
//// Yorum satırı için Ctrl + K+ C

//Console.WriteLine("1 . Sayıyı giriniz: ");
//int sayi1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("+, - bunlardan birini seçiniz.");
//string islem = Console.ReadLine();


//Console.WriteLine("2. Sayıyı giriniz.");
//int sayi2 = Convert.ToInt32(Console.ReadLine());

////if (islem == "+")
////{
////    Console.WriteLine($"{sayi1} ve {sayi2} nin toplamı : {toplam}");
////}
////else if (islem == "-")
////{
////    int sonuc = sayi1 - sayi2;
////    Console.WriteLine($" {sayi1} ve {sayi2} nin farkı : {sonuc}");
////}
////else
////    Console.WriteLine("Yanlış karkater girdiniz.");
////Console.WriteLine("uygulama bitti");   int toplam = sayi1 + sayi2;


////************************* Switch case ************************* 

////try 
////{ 

////    Console.WriteLine("1 . Sayıyı giriniz: "); 
////    int sayi1 = Convert.ToInt32(Console.ReadLine()); 


////    Console.WriteLine("+, - bunlardan birini seçiniz."); 
////    string islem = Console.ReadLine(); 

////    Console.WriteLine("2. Sayıyı giriniz."); 
////    int sayi2 = Convert.ToInt32(Console.ReadLine()); 

////    switch (islem) 
////    { 
////        case "+": 
////            { 
////                int toplam = sayi1 + sayi2; 
////                Console.WriteLine("sayıların toplamı: " + toplam); 
////                break; 
////            } 
////        case "-": 
////            { 
////                int sonuc = sayi1 - sayi2; 
////                Console.WriteLine("Sayıların farkı: " + sonuc); 
////                break; 
////            } 

////        default: 
////            { 
////                Console.WriteLine("Yanlış Karakter girdiniz"); 
////                break; 
////            } 
////    } 

////}catch (FormatException e) 
////{ 
////    Console.WriteLine(e.Message); 
////} 
//// Pascal Case 
//int ilkDeger = 0;
//Console.WriteLine("While Döngüsü ile");
//while (ilkDeger <= 10)
//{
//    Console.WriteLine(ilkDeger);
//    // 1. Yöntem 
//    ilkDeger += 3;
//}

//Console.WriteLine("For döngüsü ile");
//for (int i = 0; i <= 10; i += 5)
//{
//    Console.WriteLine(i);

//    // Değer tipler
//    // int,bool,char,double,float
//    // Değer tipler nool değerler almazlar
//    // hafızanın stack kısmında depolanır

//    // Referans tipler
//    // string,arraylist,list,Map,enum,class ve interface
//    // referans tipler null değer alabilir

//    string ad = "Gülsu Doğan";
//    Console.WriteLine($"ad metninde ğ harfi var mı:(ad.contains);

//// Colletions 
//string [] sehirler ={ "Elazığ","Kahramanmaraş","Malatya"};

////Console.Writeline(sehiler0);
////Console.Writeline(sehiler1);
////Console.Writeline(sehiler2);

//// 1.yöntem for döngüsü ile
//for (int i=0;1<sehirler.Length;i++)
//    {
//        Console.WriteLine(sehirler[i]);

//    }
//    // foreach yöntemi ile
//    int[] sayılar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//    foreach (int sayı in sayılar)
//    {
//        Console.WriteLine(sayi);
//    }
//    // Listeler
//    List<string> meyveler = new List<string>() {

//        "Karpuz", "Çilek","Elma"
//    };
//    meyveler.Add("Kavun")
//    meyveler.Add("Armut")

//    List<string> eklenecekmeyveler = new List<string>()
//    {
//        "Ejderha meyvesi", "Mango"

//    };
//    meyveler.AddRange(eklenecekmeyveler);



//    //foreach(string meyve in meyveler)
//    //{
//    // Console.Writeline(meyve);

//    //predicate,lamda
//    meyveler.ForEach(meyve => Console.WriteLine(meyve));

//    List<int> numbers = new()
//    {
//        1, 4, 2, 3, 7, 6, 8, 9, 11, 10
//    };

//    numbers.Sort();//küçükten büyüğe sıralar

//    numbers.Reverse();//büyükten küçüğe sıralar
//    //11,10,9,8,7,6,5,4,3,2,1

//    numbers.Remove(7);//listede 7 elemanı olan siler
//    //11,10,9,8,6,5,4,3,2,1
//    numbers.ForEach(number => Console.WriteLine(number));
//    Console.WriteLine($"listedeki 3 olan değerin indeksi:{numbers.};
//    Console.WriteLine($"listedeki tüm elemanların toplamı:{numbers.};
//    Console.WriteLine($"listedeki en küçük sayı: {numbers.Min()"};
//    Console.WriteLine($"listedeki en büyük  sayı : {numbers.Max()}"); 

// // 1. Yöntem  
// List<int> numbers1 = new() 
// { 
//     1,4,2,3,7,6,8,9,11,10 
// }; 

//List<int> evenNumers = new(); 
// ************** For Yöntem ************** 

//for (int i = 0; i<numbers1.Count; i++) 
//{ 
//    if (numbers1[i]%2==0) 
//    { 
//        evenNumers.Add(numbers1[i]); 
//    } 
//} 

//for(int i = 0; i<evenNumers.Count; i++) 
//{ 
//    Console.WriteLine(evenNumers[i]); 
//} 

//foreach (int number in numbers1) 
//{ 
//    if (number %2 ==0) 
//    { 
//        evenNumers.Add(number); 
//    } 
//} 
//// ************** Foreach Yöntem ************** 
//foreach (int ciftsayi in evenNumers) 
//{ 
//    Console.WriteLine(ciftsayi); 
//} 

//string[] sebzeler = { "barbunya", "bamya", "soğan" };
//Console.WriteLine(sebzeler[0]);
//Console.WriteLine(sebzeler[1]);
//Console.WriteLine(sebzeler[2]);







//List<string> sebzeler = new();

//Kalıtım

//class Hayvanlar
//{

//    public void yürür()

//    {
//        Console.WriteLine("Hayvanlar yürür");

//    }


//}
//class At : Hayvanlar
//{
//    public void arpayerler()

//    {
//         Console.WriteLine("Hayvanlar arpa yer");
//    }
//}


//class Kus:Hayvanlar
//{

//        public void ucar()

//        {
//            Console.WriteLine("kuşlar uçar");


//        }
//}

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Hayvanlar hayvanlar = new Hayvanlar();
//        hayvanlar.yürür();
//        Kus kus = new Kus();
//        kus.ucar();

//    }
//}

//using System.Runtime.CompilerServices;

//class ABC
//{
//    String ad;
//    int boyut;
//    String renk;
//    float fiyat;


//    ABC(String ad, int boyut, String renk, float fiyat)

//    {
//        this.ad = ad;
//        this.boyut = boyut;
//        this.renk = renk;
//        this.fiyat = fiyat;

    

//}
//    public static void Main()
//    {
////        ABC orn = new ABC("parfum",155," kahverengi", (float)1.181);
////        Console.WriteLine("Ürünün adı= " +  orn.ad + " " + "Ürün boyutu=" + orn.boyut);
//    }
//}




 
















 