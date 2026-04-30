# 📦 INBENT - Inbentario Jasangarriaren Kudeaketa

![C#](https://img.shields.io/badge/C%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-%235C2D91.svg?style=for-the-badge&logo=.net&logoColor=white)
![MySQL](https://img.shields.io/badge/MySQL-%2300f.svg?style=for-the-badge&logo=mysql&logoColor=white)
![IoT](https://img.shields.io/badge/IoT-Prest-%2300979D.svg?style=for-the-badge&logo=arduino)

**INBENT** C# eta Windows Forms erabiliz garatutako mahaigaineko aplikazio bat da, ikastetxeetako ekipamendu informatikoaren kudeaketa efizientea eta jasangarria egiteko diseinatua[cite: 1]. 

Proiektu honek inbentario soil baten mugak gainditzen ditu; izan ere, **Ekonomia Zirkularraren** printzipioak inplementatzen ditu datu-baseko diseinuaren eta logika espezifikoaren bidez (baja logikoak, matxuren historiala eta konponketen trazabilitatea)[cite: 1].

## ✨ Ezaugarri Nagusiak

*   🔐 **Baimen eta Rol Sistema:** Saioa hastean, sistemak erabiltzailearen rola (Irakaslea, Mintegi burua, IKT Arduraduna) detektatzen du eta interfazea dinamikoki moldatzen du segurtasuna bermatzeko[cite: 1].
*   ♻️ **Ekonomia Zirkularra (Soft Delete):** Gailuak ez dira zuzenean ezabatzen. Sistema `baja_arrazoia` eta matxuren historiala gordetzeko diseinatuta dago, osagaien berrerabilpena (*upcycling*) sustatuz[cite: 1].
*   🧬 **Objektuei Orientatutako Programazioa (OOP):** Datuen kudeaketa herentzian oinarritzen da (klase nagusia: `Gailua`, hortik eratorritakoak: `Ordenagailua` eta `Inprimagailua`)[cite: 1].
*   🔍 **Bilaketa eta Iragazki Dinamikoak:** Denbora errealean funtzionatzen duen bilatzailea, LINQ erabiliz gailuak markaren, gelaren, mintegiaren edo egoeraren arabera iragazteko[cite: 1].
*   🏗️ **Arkitektura Garbia:** Hiru geruzatan egituratutako diseinua (Entitateak, Kudeatzaileak/DAL eta Interfazea/Diseinuak) mantentze-lanak errazteko[cite: 1].

## 🛠️ Arkitektura eta Fitxategien Egitura

Proiektua logika eta bista bereizteko egituratuta dago[cite: 1]:

*   `/Entitateak/`: Datu-baseko taulen ispilu diren klaseak (`Erabiltzailea.cs`, `Gailua.cs`, `Matxura.cs`...).
*   `/Kudeatzaileak/`: MySQL-rekin komunikatzen diren klaseak, datuen CRUD eragiketak egiteko (`DBkonexioa.cs`, `Gailu_kudeatzailea.cs`...).
*   `/diseinuak/`: Windows Forms interfazeak (`FLogin.cs`, `FNagusia.cs`, etab.).

## ⚙️ Instalazioa eta Konfigurazioa

Proiektua zure ekipoan martxan jartzeko jarraitu pauso hauek:

### 1. Datu-basearen prestaketa
1. Sortu MySQL datu-base berri bat (adib. `INBENT`).
2. Kargatu proiektuko SQL fitxategia egitura sortzeko (taulak eta `ON DELETE CASCADE` erlazioak).

### 2. Aplikazioaren konexioa
1. Ireki klonatu duzun proiektua Visual Studio-n.
2. Joan `Kudeatzaileak/DBkonexioa.cs` fitxategira[cite: 1].
3. Eguneratu konexioaren parametroak zure MySQL zerbitzariaren datuekin:
   ```csharp
   private string zerbitzaria = "localhost";
   private string datuBasea = "INBENT";
   private string erabiltzailea = "zure_erabiltzailea";
   private string pasahitza = "zure_pasahitza";
   private string portua = "3306";
