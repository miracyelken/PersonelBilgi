var personel = new Personel();

Console.WriteLine("Ad: ");
personel.Ad = Console.ReadLine(); //kullanıcıdan bilgi alınan kısım
Console.WriteLine("Soyad: ");
personel.Soyad = Console.ReadLine();
Console.WriteLine("İşe giriş yılı: ");
personel.Girisyil = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(personel.PersonelBilgi());

class Personel
{
	public string Ad { get; set; } //fieldlar
	public string Soyad { get; set; }

	private double maas;
	public double Maas { get => maas; } //maaşı dışarıdan erişime kapattım

	private int girisyil;

	public int Girisyil //maaşını hesaplayan metot
	{
		get { return girisyil; }
		set
		{ 
			girisyil = value;
			this.maas = 10000 + ((DateTime.Now.Year - girisyil) * 1000);
		}
	}
	public string PersonelBilgi() => $"{this.Ad} {this.Soyad} isimli personelin hesaplanan maaşı: {this.maas}"; //çıktı
}