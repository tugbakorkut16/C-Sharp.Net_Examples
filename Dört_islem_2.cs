// kullanıcıya sunulan bir menü içinden seçilecek olan dört işlem tipine göre hesaplama yapınız.


Console.Write("Birinci sayi:");
var sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("ikinci sayi:");
var sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Toplama için: +");
Console.WriteLine("Çikarma için: -");
Console.WriteLine("Çarpma için : *");
Console.WriteLine("Bölme için  : /");

Console.Write("Seçiminiz: ");
var secim = Console.ReadLine();

double sonuc = 0;
bool ok = true;

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
   ok = false;
   Console.WriteLine("yanliş seçim tekrar deneyin");
}
if (ok){
Console.WriteLine($"{sayi1} {secim} {sayi2} = {sonuc}");
}





