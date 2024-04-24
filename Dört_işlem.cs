// kullanıcıya sunulan bir menü içinden seçilecek olan dört işlem tipine göre hesaplama yapınız.

Console.WriteLine("Toplama için: +");
Console.WriteLine("Çikarma için: -");
Console.WriteLine("Çarpma için : *");
Console.WriteLine("Bölme için  : /");

Console.Write("Seçiminiz: ");
var secim = Console.ReadLine();

Console.Write("Birinci sayi:");
var sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("ikinci sayi:");
var sayi2 = Convert.ToInt32(Console.ReadLine());

double sonuc = 0;

if (secim == "+") {
   //toplama
   sonuc = sayi1 + sayi2;
} else if (secim =="-") {
   //çıkarma
   sonuc = sayi1 - sayi2;  
} else if (secim =="*") {
   //çarpma
   sonuc = sayi1 * sayi2;
} else if (secim =="/") {
   //bölme
   sonuc = sayi1 / sayi2;  
} else {
   //yanlış seçim,
   Console.WriteLine("yanliş seçim tekrar deneyin");
}
Console.WriteLine("sonuc="+ sonuc);




