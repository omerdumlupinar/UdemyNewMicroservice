# 🚀 .NET 8 ile Modern Mikroservis Mimarisi – Eğitim Projesi

Bu repository, **.NET 8** kullanılarak geliştirilen ve bir eğitim süreci boyunca adım adım inşa edilen **Modern Mikroservis Mimarisi** örneğini içermektedir.

Proje, Udemy benzeri bir **Online Kurs Platformu** senaryosu üzerinden ilerlemekte olup, mikroservis mimarisinin gerçek hayatta nasıl uygulandığını öğrenmeyi hedefler.

> 🎯 Amaç: Mikroservis mimarisini teoriden pratiğe taşıyarak, modern backend geliştirme yaklaşımlarını birebir uygulamak.

---

## 📚 Eğitim Kapsamında Öğreneceklerim

- Mikroservis mimarisinin temel prensipleri ve avantajları
- Mikroservisler arası:
  - **Senkron iletişim (HTTP / REST)**
  - **Asenkron iletişim (RabbitMQ – Event Driven)**
- **OAuth 2.0 & OpenID Connect** ile kimlik doğrulama
- **Keycloak** ile Access Token / Refresh Token yönetimi
- **Eventual Consistency** yaklaşımı
- Docker & Docker Compose ile container tabanlı mimari
- API Gateway kullanımı (**YARP**)
- Polyglot Persistence (Birden fazla veritabanı kullanımı)
- Clean Architecture & CQRS Pattern

---

## 🧱 Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|---------|---------|
| .NET 8 | Mikroservis altyapısı |
| ASP.NET Core | Web API & Razor Pages |
| Docker | Containerization |
| Docker Compose | Ortam yönetimi |
| RabbitMQ | Message Broker |
| MassTransit | Asenkron iletişim |
| YARP | API Gateway |
| Keycloak | IdentityServer |
| MongoDB | Catalog servisi |
| Redis | Basket servisi |
| PostgreSQL | Discount & Identity |
| SQL Server | Order servisi |
| MediatR | CQRS Pattern |

---

## 🧩 Geliştirilen Mikroservisler

### 📦 Catalog Microservice
- Kurs bilgileri yönetimi
- MongoDB kullanımı
- One-to-Many & One-to-One ilişkiler

### 🛒 Basket Microservice
- Kullanıcı sepet işlemleri
- Redis ile geçici veri yönetimi

### 🎟 Discount Microservice
- Kullanıcı indirim kuponları
- PostgreSQL veritabanı

### 📑 Order Microservice
- Sipariş süreçleri
- Clean Architecture & CQRS
- SQL Server
- MediatR

### 💳 Fake Payment Microservice
- Ödeme sürecinin simülasyonu

### 🖼 File Microservice
- Kurs görsellerinin yönetimi

### 🔐 Identity Microservice (Keycloak)
- OAuth 2.0 / OpenID Connect
- Access Token & Refresh Token
- PostgreSQL

### 🌐 API Gateway
- Merkezi yönlendirme
- YARP ile yapılandırma

### 📬 Message Broker
- RabbitMQ
- Event-driven mimari
- MassTransit

### 🖥 ASP.NET Core Razor Pages UI
- Kullanıcı arayüzü
- Mikroservislerle entegrasyon

---

## ▶️ Projeyi Çalıştırma

```bash
docker-compose up -d
