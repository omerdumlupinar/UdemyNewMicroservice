# 🚀 .NET 8 ile Modern Mikroservis Mimarisi  
### (Eğitim Amaçlı Birebir Uygulama – Fatih Çakıroğlu)

Bu repository, **Fatih Çakıroğlu** tarafından hazırlanan  
**“.NET ile Modern Mikroservis Mimarisi”** eğitim seti **birebir takip edilerek** geliştirilmiştir.

Amaç; mimari kararları, kullanılan teknolojileri ve uygulama detaylarını **derinlemesine öğrenmek** ve mikroservis mimarisini gerçek bir proje üzerinden deneyimlemektir.

> ⚠️ Bu proje **tamamen eğitim ve öğrenme amaçlıdır**.  
> Kod yapısı, servis kurgusu ve mimari yaklaşım eğitim seti ile **birebir aynıdır**.

---

## 🎯 Projenin Amacı

- Mikroservis mimarisini teoriden pratiğe geçirmek
- Dağıtık sistemlerde:
  - Senkron
  - Asenkron
  iletişim modellerini uygulamak
- Modern .NET ekosistemini gerçek bir projede kullanmak
- Clean Architecture ve CQRS gibi ileri seviye mimari desenleri öğrenmek

---

## 📚 Eğitimde Ele Alınan Konular

- Mikroservis mimarisi temel prensipleri
- Servisler arası iletişim:
  - HTTP / REST
  - RabbitMQ (Event Driven)
- OAuth 2.0 & OpenID Connect
- Keycloak ile IdentityServer kurulumu
- Access Token / Refresh Token yönetimi
- Eventual Consistency
- Docker & Docker Compose
- API Gateway (YARP)
- Clean Architecture
- CQRS Pattern (MediatR)
- Polyglot Persistence

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
| MongoDB | Catalog Microservice |
| Redis | Basket Microservice |
| PostgreSQL | Discount & Identity |
| SQL Server | Order Microservice |
| MediatR | CQRS Pattern |

---

## 🧩 Mikroservisler

- Catalog Microservice
- Basket Microservice
- Discount Microservice
- Order Microservice
- Fake Payment Microservice
- File Microservice
- Identity Microservice (Keycloak)
- API Gateway (YARP)
- Message Broker (RabbitMQ)
- ASP.NET Core Razor Pages UI

---

## ▶️ Projeyi Çalıştırma

```bash
docker-compose up -d
