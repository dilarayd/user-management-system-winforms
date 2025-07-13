# User Management System (Windows Forms)

## Project Description

This project is a comprehensive user management system developed using C# Windows Forms. The application handles essential functionalities such as user registration, secure login, and profile updates, prioritizing user experience and data security. It was developed as an application exam within the "Visual Programming" course.

## Key Features

* **User Registration:**
    * User registration with full name, email, password, and password confirmation.
    * Empty field validation and correct email format validation.
    * Instant feedback on password strength (Weak, Medium, Strong).
    * Random character verification code that refreshes every 60 seconds.
    * Specific warning messages for unsuccessful registration attempts.
* **User Login:**
    * Secure user login with email and password.
    * Password show/hide feature.
    * Redirection to the main application screen upon successful login.
* **Profile Update:**
    * Ability for logged-in users to update their phone number, gender, and address information.
    * All updates are listed with a timestamp using a `ListView` component.
* **Error Handling:**
    * Detailed and user-friendly warning messages for user input errors.

## Technologies Used

* **Programming Language:** C#
* **User Interface (UI):** Windows Forms (.NET Framework / .NET)

## Setup and Run

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/dilarayd/user-management-system-winforms.git](https://github.com/dilarayd/user-management-system-winforms.git)
    ```
2.  **Open the Project:**
    * Open Visual Studio (for Windows) or Visual Studio for Mac (for macOS).
    * Navigate to the cloned folder and open the `UserManagementSystemWinForms.sln` (or your project's `.sln` solution file).
3.  **Build and Run:**
    * Inside Visual Studio, build the project (`Build` menu -> `Build Solution`).
    * Press the `Start` button or `F5` to launch the application.

---

# Kullanıcı Yönetim Sistemi (Windows Forms)

## Proje Tanımı

Bu proje, C# Windows Forms kullanılarak geliştirilmiş kapsamlı bir kullanıcı yönetim sistemidir. Uygulama, kullanıcı kaydı, güvenli giriş ve profil güncelleme gibi temel işlevleri yerine getirirken, kullanıcı deneyimini ve veri güvenliğini ön planda tutar. Öğrenilen "Görsel Programlama" dersi kapsamında bir uygulama sınavı olarak geliştirilmiştir.

## Temel Özellikler

* **Kullanıcı Kaydı:**
    * Kullanıcı kaydı için isim-soyisim, e-posta, şifre ve şifre tekrarı alınır.
    * Boş alan kontrolü ve doğru e-posta formatı doğrulaması yapılır.
    * Şifre gücü analizi (Zayıf, Orta, Güçlü) ile anlık geri bildirim sağlanır.
    * 60 saniyede bir yenilenen rastgele karakterli doğrulama kodu mevcuttur.
    * Başarısız kayıt girişimlerinde kullanıcıya özel uyarı mesajları verilir.
* **Kullanıcı Girişi:**
    * E-posta ve şifre ile güvenli kullanıcı girişi yapılır.
    * Şifre gizle/göster özelliği bulunur.
    * Başarılı girişin ardından ana uygulama ekranına yönlendirme yapılır.
* **Profil Güncelleme:**
    * Giriş yapan kullanıcının cep telefonu, cinsiyet ve adres bilgilerini güncelleme imkanı sunulur.
    * Yapılan her güncelleme, zaman damgası ile birlikte bir `ListView` bileşeni kullanılarak listelenir.
* **Hata Yönetimi:**
    * Kullanıcı giriş hatalarına karşı detaylı ve kullanıcı dostu uyarı mesajları sağlanır.

## Kullanılan Teknolojiler

* **Programlama Dili:** C#
* **Kullanıcı Arayüzü (UI):** Windows Forms (.NET Framework / .NET)

## Kurulum ve Çalıştırma

1.  **Depoyu Klonlayın:**
    ```bash
    git clone [https://github.com/dilarayd/user-management-system-winforms.git](https://github.com/dilarayd/user-management-system-winforms.git)
    ```
2.  **Projeyi Açın:**
    * Visual Studio (Windows için) veya Visual Studio for Mac (macOS için) uygulamasını açın.
    * Klonladığınız klasörün içine gidin ve `UserManagementSystemWinForms.sln` (veya projenizin `.sln` uzantılı çözüm dosyasının adı) dosyasını açın.
3.  **Derleyin ve Çalıştırın:**
    * Visual Studio içerisinde projeyi derleyin (`Derle` menüsü -> `Çözümü Derle`).
    * Uygulamayı başlatmak için `Başlat` (Start) butonuna veya `F5` tuşuna basın.