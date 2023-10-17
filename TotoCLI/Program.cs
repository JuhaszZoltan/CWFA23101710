namespace TotoCLI
{
    internal class Program
    {
        static void Main()
        {
            List<FogadasiFordulo> fordulok = new();
            using StreamReader sr = new(@"..\..\..\src\toto.txt");
            _ = sr.ReadLine();
            while (!sr.EndOfStream) fordulok.Add(new(sr.ReadLine()));

            Console.WriteLine($"3. feladat: Fordulók száma: {fordulok.Count}");

            int f4 = fordulok.Sum(f => f.T13p1);
            Console.WriteLine($"4.. feladat: Telitalálatos szelvények száma: {f4} db");

            double f5 = fordulok
                //.Where(f => f.T13p1 > 0 || f.Ny13p1 > 0)
                .Average(f => f.T13p1 * f.Ny13p1);
            Console.WriteLine($"5. feladat: Átlag: {f5:0} Ft");

            var f6 = fordulok.Where(f => f.T13p1 > 0);
                //.OrderBy(f => f.Ny13p1);
            Console.Write($"6. feladat:");
            AdatokKiirasa("Legnagyobb", f6.MaxBy(f => f.Ny13p1));
            AdatokKiirasa("Legkisebb", f6.MinBy(f => f.Ny13p1));

            //var f8a = fordulok.Any(f => new EredmenyElemzo(f.Eredmenyek).NemvoltDontetlenMerkozes);
            //Console.WriteLine($"8. feladat: {(f8a ? "Volt" : "Nem volt")} döntetlen nélkülö mérközés");

            //int i = 0;
            //while (i < fordulok.Count && !new EredmenyElemzo(fordulok[i].Eredmenyek).NemvoltDontetlenMerkozes)
            //{
            //    i++;
            //}
            //if (i < fordulok.Count) Console.WriteLine("Volt dötetlen nélkülöi");
            //else Console.WriteLine("nem volt döntetlen nélküli");

            var f8b = fordulok.Any(f => !f.VanDontetlen);
            Console.WriteLine($"8. feladat: {(f8b ? "Volt" : "Nem volt")} döntetlen nélkülö mérközés");
        }

        static void AdatokKiirasa(string fejlec, FogadasiFordulo fordulo)
        {
            Console.WriteLine($"\n\t{fejlec}:");
            Console.WriteLine($"\tÉv: {fordulo.Ev}");
            Console.WriteLine($"\tHét: {fordulo.Het}.");
            Console.WriteLine($"\tForduló: {fordulo.Fordulo}.");
            Console.WriteLine($"\tTelitalálat: {fordulo.T13p1} db");
            Console.WriteLine($"\tNyeremény: {fordulo.Ny13p1} Ft");
            Console.WriteLine($"\tEredmények: {fordulo.Eredmenyek}");
        }
    }
}