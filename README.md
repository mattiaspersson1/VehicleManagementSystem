# Vehicle Management System

Detta projektet hanterar olika fordonstyper samt felhantering via polymorfism.

## Funktioner
- Inkapsling med validering
- Arv och polymorfism via fordonstyper
- Interface för ICleanable
- Polymorf felhantering via abstrakta klasser
- Exception-hantering

## Körinstruktioner
1. Öppna projektet i Visual Studio **eller**
2. Kör i terminal:
   ```bash
   dotnet build
   dotnet run
   ```

## Projektstruktur
```
VehicleManagementSystem/
│
├── VehicleManagementSystem.csproj
├── Program.cs
├── VehicleManagementSystem/
│   ├── Models/
│   │   └── Vehicle.cs
│   └── Errors/
│       └── SystemError.cs
```

## Frågor
// F: Vad händer om du försöker lägga till en Car i en lista av Motorcycle?
// S: Kompilatorfel – Car är inte en Motorcycle, de är syskonklasser.

// F: Vilken typ bör en lista vara för att rymma alla fordonstyper?
// S: List<Vehicle>, eftersom alla fordon ärver från Vehicle.

// F: Kommer du åt metoden Clean() från en lista med typen List<Vehicle>?
// S: Nej, inte direkt – måste först kolla och casta till ICleanable.

// F: Vad är fördelarna med att använda ett interface här istället för arv?
// S: Interface tillåter flera implementationer utan att påverka ärvda klasser.

---

© 2025
