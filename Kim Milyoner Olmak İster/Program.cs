Console.WriteLine("Kim Milyoner Olmak İster yarışmasına hoşgeldiniz!");
Console.WriteLine("2 cevap şıklı 3 adet sorumuz var ! Yarışmacı 3 sorudan 2'sini doğru cevaplar  ise 1 Milyon TL'lik büyük ödülü kazanacak!");

int dogruCevapSayisi = 0; // Doğru cevapları kaydetmesi için ekledim, doğru cevaplarda ++ operatörü ile ekleme yapılacak.

Console.WriteLine("");

Console.WriteLine("Soru 1: Kızınca tüküren hayvan hangisidir ?");
Console.WriteLine("A: Lama" + "   " + "B: Deve");
string cevap1 = Console.ReadLine().ToUpper(); // ToUpper ile verilen cevaplar büyük harfli olacak.
if (cevap1 == "A")
{
    Console.WriteLine("Doğru cevap!");
    dogruCevapSayisi++;
}
else
{
    Console.WriteLine("Yanlış cevap!");
}

Console.WriteLine("Soru 2: Dünya'ya en yakın gezegen hangisidir ? ");
Console.WriteLine("A: Venüs" + "   " + "B: Mars");
string cevap2 = Console.ReadLine().ToUpper();
if (cevap2 == "A")
{
    Console.WriteLine("Doğru cevap!");
    dogruCevapSayisi++;
}
else
{
    Console.WriteLine("Yanlış cevap!");
}
// Kazanma kontrolü
if (dogruCevapSayisi == 2)
    Console.WriteLine("Tebrikler! Yarışmayı kazandınız! 1 Milyon TL'lik büyük ödül sizin!");
else if (dogruCevapSayisi == 0)
    Console.WriteLine("Üzgünüz, yeterli doğru cevabı veremediniz. Yarışmadan elendiniz.");

else
{
    Console.WriteLine("Soru 3: 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?");
    Console.WriteLine("A: 7" + "   " + "B: 12");
    string cevap3 = Console.ReadLine().ToUpper();
    if (cevap3 == "B")
    {
        Console.WriteLine("Doğru Cevap!");
        Console.WriteLine("Tebrikler! Yarışmayı kazandınız! 1 Milyon TL'lik büyük ödül sizin!");
    }
    else
        Console.WriteLine("Üzgünüz, yeterli doğru cevabı veremediniz. Yarışmadan elendiniz.");
}

