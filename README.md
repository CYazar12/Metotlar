www.patika.dev
# Metotlar


Metodlar tek baslarina yazilabilen-cagirabiler yapilar degiller. Bir class icinde yazilmali ve yine erisimi(cagrilmasi) mevcut bulundugu class icinden olmali.

Metotlar direkt metod adiyla cagirabilidigi gibi eger baska bir class icine yazilmis metodu cagirmak(erismek) istersek o classin öncelikle bir instancesini 

yani bir örnegini olusturmak zorundayiz,o örnek üzerinden ancak o methoda ulasabiliriz.

 Syntax:
 
  erisim_belirteci geri_donustipi metot_adi(parametreListesi/arguman) {
 
  komutlar
  
  return
  
 ---------------------------------------------------------------------------------------------------------
  
  
namespace metot

{
   
   internal class Program
    
    {
        
        static void Main(string[] args)
        {
         int a = 2;
         int b = 3;
        Console.WriteLine(a+b);
        int sonuc =Topla(a,b) 
 
toplama islemini yapiyor ,deger1=a deger2=b degerlerini veriyoruz.Call by Value islemi : dolayisiyla deger1 ve deger2 sadece fonksiyonun calisma süresice vardirlar, sadece fonksiyon icinde erisilebilirler.


'''Console.WriteLine(sonuc);
Metotlar ornek = new Metotlar();
ornek.EkranaYazdir(Convert.ToString(sonuc));''' 


EkranaYazdir metotu string tipinde bir veritipi bekliyor parameter olarak ama sonuc integer tipinde bir veri tipdolayisiyla test edemiyor.burda Convert.ToString diyip integeri stringe ceviriyoruz.

'''int sonuc2 = ornek.ArttirVeTopla(a,b); 

ornek.EkranaYazdir(Convert.ToString(sonuc2));'''


a ve b nin lokal degerlerini 1 artttirip topladigimizda Cikti:7

'ornek.EkranaYazdir(Convert.ToString(a+b));' 


burda Console.WriteLine(a+b) de diyebiliriz,a ve b nin lokal degerlerini artirmadan önce topladigimizda Cikti:5

Yukarda a ve b nin degerlerini global olarak fonksiyon disinda da o deger üzerinden islem görmesi icin ref i kullanacagiz.

'int sonuc2 = ornek.ArttirVeTopla(ref a, ref b);'
 

 'ornek.EkranaYazdir(Convert.ToString(sonuc2));'  /*Burda a ve b global degerini 1 artirip topluyoruz  Cikti :7


'ornek.EkranaYazdir(Convert.ToString(a+b));  }'   /* burda deger1 ve deger2 üzerinden a ve b nin degerini degistirip topluyor.Cikti :7 
'static int Topla (int deger1, int deger2){'
Yukardaki toplama isleminin aynisini bir metot ile yapmak istiyoruz. Ayni class icerisinde Topla diye bir metot olisturduk,static demek zorundayiz,cünkü yukardaki Main metot static bir metod ve static bir metod icinde ancak static metodlara erisilebilir.

 'return(deger1 +deger2);}}'
a ve b degiskenlerine deger1 ve deger2 olarak farkli isimler verdik.ikicinci metotumuzu mevcut class in icinde degil baska bir class in icinde yapmak istiyoruzkinci metotumuzdan beklentimiz Console.WriteLine lari bir metot a yazdimak.

'class Metotlar
{ 
 public void EkranaYazdir(string veri);{'  
 
 geriye bir veri dönmüyor sadece yazma islemi yapiyor dolayisiyla void olacak
 'Console.WriteLine(veri);}'
bu asamada farkli classda oldugumuz icin classimizin bir instance yani bir örnegini yukarda olusturmamaiz lazim olusturdugumuz class in instance ile metotda ulasmayi deniycez, olusturdugumuz class in instance na erisebilmek icin public yazmak zorundayiz

/*****Call by Reference 

'''public int ArttirVeTopla(int deger1, int deger2) 
 {
   deger1+=1;
   deger2+=1;
 return deger1+deger2;'''

Normalde bu degere fonksiyon icinde ulasabiliriz digiskenin lokal olarak degistirmek icin böyle yaziyoruz

'''public int ArttirVeTopla( ref int deger1,ref int deger2)
 {
           deger1+=1;
           deger2+=1;
           return deger1+deger2;}}''' 
degiskenin global olarak degistirmek Normalde ben bu degere fonksiyon icinde ulasabilirken ref kullanarak deger1 ve deger2 nin degerini global olarak degistiriyoruz.

                                                             
                                                                
