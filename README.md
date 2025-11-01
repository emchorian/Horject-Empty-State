# Horject - Empty State 🎓

**Horject**, C# ile yapılmış basit ama işlevsel bir **proje koleksiyonu görüntüleme ve düzenleme arayüzüdür.**  
Okulda yapılan 20 farklı C# projesini tek bir uygulamada toplar, öğrencinin proje adlarını düzenlemesine ve doğrudan o projeyi açmasına imkân tanır.

---

## 📦 Genel Bilgi

Bu uygulama, öğrencilerin veya öğretmenlerin **hazır 20 projeyi** bir arada görmesini sağlar.  
Yeni proje **eklenmez**, yalnızca **mevcut 20 projenin isimleri değiştirilebilir** veya **görüntülenebilir**.

Program, her projenin kendi form sınıfına (`_1`, `_2`, `_3`, … `_20`) yönlendirir.

---

## ⚙️ Kurulum ve Çalıştırma

1. Visual Studio veya Rider gibi bir IDE aç.
2. Proje klasörünü aç (`Horian_Project_Collector.sln` dosyasını seç).
3. `F5` veya **Start** tuşuna basarak projeyi çalıştır.
4. Alternatif olarak, `Projeyi_Başlat.bat` dosyasına çift tıklayarak programı doğrudan `.exe` olarak başlatabilirsin.

---

## 🧭 Kullanım

### 🔢 Numara Tuş Takımı
- Arayüzdeki sayılara tıklayarak **proje numarasını** girersin.
- Örneğin:
  - “1” → `_1` isimli form (Birinci Proje)
  - “10” → `_10` isimli form (Onuncu Proje)
- Ardından **Enter** butonuna basarak o projeyi açarsın.

> ⚠️ Geçersiz numara (ör. 0, 21 gibi) girersen uyarı penceresi çıkar.

---

### 📜 Proje Listesi
- Sol tarafta veya ortada (arayüzüne göre) bir **ListBox** bulunur.
- Bu listede 1’den 20’ye kadar tüm projelerin isimleri yazar:
  ```
  1.) Birinci Proje
  2.) İkinci Proje
  ...
  20.) Yirminci Proje
  ```
- Herhangi bir satıra **çift tıklayarak** o projeyi açabilirsin.

---

### ✏️ Proje İsimlerini Değiştirme

Proje adları `Anasayfa.cs` dosyasındaki `anasayfa_Load` metodunda belirlenir:

```csharp
private void anasayfa_Load(object sender, EventArgs e)
{
    list.Items.Add("1.) Birinci Proje");
    list.Items.Add("2.) İkinci Proje");
    ...
    list.Items.Add("20.) Yirminci Proje");
}
```

İstediğin şekilde düzenleyebilirsin.  
Örneğin:
```csharp
list.Items.Add("1.) Hesap Makinesi");
list.Items.Add("2.) Öğrenci Takip Sistemi");
```

---

### 💡 Kod Akışı

| Metot | Görev |
|--------|--------|
| `anasayfa_Load` | Listeye sabit 20 projenin isimlerini ekler. |
| `numberX_Click` | Tuş takımından rakam ekler (`numericLabel`’a yazar). |
| `delete_Click` | Ekrandaki rakamları siler. |
| `enter_Click` | Girilen numaraya göre ilgili formu açar (`_1`, `_2`, … `_20`). |
| `list_DoubleClick` | Listede çift tıklanan projenin formunu açar. |
| `numericLabel_TextChanged` | Sayı uzunluğu 2 karakteri geçerse kullanıcıyı uyarır. |

---

## 🧩 Yeni Proje Eklenebilir mi?

Hayır.  
Bu uygulama **tam olarak 20 proje** içindir.  
Yeni proje eklemek istersen:
- Yeni bir form oluştur (`_21.cs` gibi),
- Ardından `enter_Click` ve `list_DoubleClick` fonksiyonlarına uygun koşul ekle.

Ancak mevcut sürümde tasarım gereği proje sayısı **20 ile sabittir.**

---

## 🧱 Formların Mantığı

Her proje formu (`_1.cs`, `_2.cs`, ... `_20.cs`) kendi içinde bağımsız çalışır.  
Bu formlarda öğrenci kendi proje kodunu yerleştirir.  
Örneğin:
```csharp
public partial class _1 : Form
{
    public _1()
    {
        InitializeComponent();
    }
}
```

---

## 📘 Özet

- **Yeni proje eklenmez.**
- **20 proje sabittir.**
- Her biri ayrı formdadır (`_1` - `_20`).
- Liste isimleri `Anasayfa.cs`’te düzenlenir.
- Seçim hem **numarayla** hem **listeden çift tıklamayla** yapılabilir.

---

## 📄 Lisans

Bu proje eğitim amaçlıdır.  
Okul içinde C# projelerinin saklanması, organize edilmesi ve sunulması için hazırlanmıştır.
