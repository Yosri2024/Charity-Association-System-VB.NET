# ❤️ Charity Association System — VB.NET WinForms

[![VB.NET](https://img.shields.io/badge/VB.NET-.NET%208-512BD4?logo=dotnet&logoColor=white)](PROJET.vbproj)
[![WinForms](https://img.shields.io/badge/WinForms-Desktop-0078D4)](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

Application de gestion pour association caritative : donateurs, nécessiteux, participants, responsables et gestion des dons. Projet VB.NET WinForms (`PROJET.sln`).

---

## 📸 Fonctionnalités

| Form | Rôle |
|------|------|
| `Form1.vb` | Menu principal (hub) |
| `Form2.vb` - `Form8.vb` | Gestion des entités (dons, répartition) |
| `donn.vb` / `partcp.vb` / `modif_1.vb` / `MDPP.vb` | CRUD Donnateurs, Participants, Modif, MDP |
| `ApplicationEvents.vb` | Événements appli |

**Données** `data/*.txt` (fichiers plats, pas de DB) :
* `Donnateurs.txt`, `Necessiteux.txt`, `Participants.txt`, `Responsables.txt`, `GESTION.txt`

---

## 🗂️ Structure

```
Charity-Association-System-VB.NET/
├── PROJET.sln / PROJET.vbproj  # net8.0-windows, WinForms
├── Form1.vb / Form1.Designer.vb / Form1.resx (x8 forms)
├── donn.vb / partcp.vb / modif_1.vb / MDPP.vb
├── ApplicationEvents.vb
├── My Project/Application.myapp
├── data/
│   ├── Donnateurs.txt
│   ├── Necessiteux.txt
│   ├── Participants.txt
│   ├── Responsables.txt
│   └── GESTION.txt
├── .github/workflows/dotnet.yml
├── .gitignore
└── README.md
```

---

## 🚀 Prérequis

* Windows 10/11
* .NET 8 SDK
* Visual Studio 2022 (VB.NET Desktop)

---

## ⚙️ Lancer

**Visual Studio :** Ouvrir `PROJET.sln` -> `F5`

**CLI :**
```bash
dotnet restore
dotnet build PROJET.sln -c Release
dotnet run --project PROJET.vbproj
# exe -> bin/Release/net8.0-windows/PROJET.exe
```

---

## 📄 Licence

MIT — voir [LICENSE](LICENSE).
