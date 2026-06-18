CocoaLite🍫🌱 

CocoaLite adalah aplikasi desktop berbasis C# Windows Forms dan PostgreSQL yang digunakan untuk mengelola proses manajemen kakao pada PT Cacao Prima Nusantara. Aplikasi ini dirancang untuk membantu pencatatan data supplier, penerimaan bahan baku kakao, pemeriksaan kualitas, pembentukan batch, pengelolaan stok inventory, pengiriman, dashboard, activity log, dan laporan operasional.
Project ini dikembangkan dengan pendekatan Pemrograman Berorientasi Objek (PBO), sehingga setiap class tidak hanya berisi data, tetapi juga memiliki behavior atau logika utama sesuai tanggung jawabnya.

## Tujuan Aplikasi

CocoaLite dibuat untuk mempermudah proses pengelolaan data kakao dari awal penerimaan bahan baku sampai proses distribusi. Sistem ini membantu perusahaan dalam:

* Mencatat data supplier kakao.
* Mencatat penerimaan bahan baku dari supplier.
* Melakukan pemeriksaan kualitas kakao berdasarkan moisture, fermentation, defect, dan bean size.
* Menentukan grade kualitas kakao.
* Membuat batch dari hasil quality control.
* Mengelola stok batch di inventory.
* Membuat shipment berdasarkan stok yang tersedia.
* Memantau ringkasan data melalui dashboard.
* Mencatat aktivitas pengguna melalui activity log.
* Membuat laporan operasional.

## Fitur Utama

 1. Login dan Role User

Aplikasi memiliki sistem login dengan dua role utama:
* Admin
* Quality Controller (QC)

Admin dapat mengakses modul supplier, receiving, batch, inventory, shipment, dashboard, activity log, dan report. Quality Controller berfokus pada proses pemeriksaan kualitas kakao dan laporan quality control.

 2. Supplier Management

Modul Supplier digunakan untuk mengelola data pemasok kakao. Data yang dikelola meliputi nama supplier, alamat, nomor telepon, dan email.

Fitur utama:
* Tambah data supplier
* Ubah data supplier
* Hapus data supplier
* Validasi nomor telepon dan email

 3. Receiving Management

Modul Receiving digunakan untuk mencatat penerimaan bahan baku kakao dari supplier.

Fitur utama:

* Memilih supplier
* Mencatat kode receiving
* Mencatat tanggal penerimaan
* Mencatat berat kakao
* Mencatat nomor kendaraan
* Menghubungkan receiving dengan supplier

 4. Quality Control

Modul Quality Control digunakan untuk memeriksa kualitas kakao berdasarkan beberapa parameter:

* Moisture
* Fermentation
* Defect
* Bean Size

Sistem dapat menentukan grade kakao berdasarkan parameter tersebut.

Grade yang digunakan:

* Grade A
* Grade B
* Grade C
* Reject

Jika hasil pemeriksaan adalah Reject, maka status QC menjadi Rejected. Jika hasil pemeriksaan bukan Reject, maka status QC menjadi Approved.

5. Batch Management

Modul Batch digunakan untuk membuat batch berdasarkan data Quality Control yang telah disetujui.

Fitur utama:

* Mengambil data QC yang Approved
* Membuat kode batch
* Menentukan berat batch
* Menentukan status batch
* Menghubungkan batch dengan shipment

6. Inventory Management

Modul Inventory digunakan untuk mengelola stok batch kakao di gudang.

Status inventory ditentukan berdasarkan jumlah stok:

* Empty jika stok 0
* Low Stock jika stok kurang dari 300 kg
* Available jika stok 300 kg atau lebih

Fitur utama:

* Menambahkan stok batch ke gudang
* Mengubah data stok
* Menentukan lokasi gudang
* Menampilkan status stok otomatis

 7. Shipment Management

Modul Shipment digunakan untuk mencatat pengiriman kakao dari batch yang tersedia di inventory.

Fitur utama:

* Memilih batch yang masih memiliki stok
* Menampilkan stok tersedia pada batch
* Menentukan tujuan pengiriman
* Menentukan berat pengiriman
* Mencatat kendaraan dan driver
* Mengubah status shipment

Status shipment:

* Pending
* Shipped
* Delivered
* Cancelled

Sistem melakukan validasi agar berat pengiriman tidak melebihi stok yang tersedia di inventory.

 8. Dashboard

Dashboard menampilkan ringkasan data operasional seperti:

* Total supplier
* Total receiving
* Total quality control
* Total batch
* Total stok
* Total shipment

Dashboard membantu pengguna melihat kondisi sistem secara cepat.

9. Activity Log

Activity Log digunakan untuk mencatat aktivitas pengguna dalam sistem. Modul ini membantu admin memantau aktivitas yang terjadi pada aplikasi.

10. Report

Modul Report digunakan untuk membuat laporan operasional berdasarkan data yang ada di sistem.

Laporan yang dapat dibuat meliputi:

* Supplier
* Receiving
* Batch
* Inventory
* Quality Control
* Shipment
* Laporan gabungan


## Teknologi yang Digunakan

Project ini menggunakan teknologi berikut:

* C#
* Windows Forms
* .NET
* PostgreSQL
* Npgsql
* QuestPDF
* Visual Studio


## Struktur Folder Project


Cocoalite
├── Controllers
│   ├── LoginController.cs
│   ├── SupplierController.cs
│   ├── ReceivingController.cs
│   ├── QualityControlController.cs
│   ├── BatchController.cs
│   ├── InventoryController.cs
│   ├── ShipmentController.cs
│   ├── DashboardController.cs
│   ├── ActivityLogController.cs
│   └── ReportController.cs
│
├── Helpers
│   ├── DbConnection.cs
│   ├── LoginSession.cs
│   ├── PasswordHasher.cs
│   ├── CodeGenerator.cs
│   └── CocoaTheme.cs
│
├── Interfaces
│   ├── IPengguna.cs
│   ├── IDapatDilaporkan.cs
│   ├── IProsesQC.cs
│   ├── IProsesPengiriman.cs
│   └── IContextInterfaces.cs
│
├── Models
│   ├── Entity
│   │   ├── AppUser.cs
│   │   ├── AdminUser.cs
│   │   ├── QualityControllerUser.cs
│   │   ├── Supplier.cs
│   │   ├── Receiving.cs
│   │   ├── QualityParameter.cs
│   │   ├── QualityControl.cs
│   │   ├── Batch.cs
│   │   ├── Inventory.cs
│   │   ├── Shipment.cs
│   │   ├── ActivityLog.cs
│   │   └── DashboardSummary.cs
│   │
│   ├── Context
│   │   ├── LoginContext.cs
│   │   ├── SupplierContext.cs
│   │   ├── ReceivingContext.cs
│   │   ├── QualityControlContext.cs
│   │   ├── BatchContext.cs
│   │   ├── InventoryContext.cs
│   │   ├── ShipmentContext.cs
│   │   ├── DashboardContext.cs
│   │   └── ActivityLogContext.cs
│   │
│   └── Service
│       └── CocoaWorkflowManager.cs
│
└── Views
    ├── Main
    ├── Core
    ├── Supply
    ├── Production
    └── Distribution
