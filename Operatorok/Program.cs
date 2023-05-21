using System.Collections.Immutable;
using System.Text;
using Operatorok;

List<operatorok> operatorok = new List<operatorok>();


StreamReader sr = new StreamReader("kifejezesek.txt");
sr.ReadLine();
while (!sr.EndOfStream)
{
    string[] adat = sr.ReadLine().Split();
    operatorok.Add(new operatorok(int.Parse(adat[0]), adat[1], int.Parse(adat[2])));
}
sr.Close();

Console.WriteLine($"2. feladat: {operatorok.Count()}");

Console.WriteLine($"3. feladat: {operatorok.Count(x => x.OpJel == "mod")}");

Console.WriteLine($"4. feladat: {(operatorok.First(x => x.OpElso % 10 == 0 && x.OpMas % 10 == 0) != null ? "Van" : "Nincs")}");

Console.WriteLine("5. feladat: Statisztika");
Console.WriteLine($"mod -> {operatorok.Count(x => x.OpJel == "mod")} db");
Console.WriteLine($"/ -> {operatorok.Count(x => x.OpJel == "/")} db");
Console.WriteLine($"div -> {operatorok.Count(x => x.OpJel == "div")} db");
Console.WriteLine($"- -> {operatorok.Count(x => x.OpJel == "-")} db");
Console.WriteLine($"* -> {operatorok.Count(x => x.OpJel == "*")} db");
Console.WriteLine($"+ -> {operatorok.Count(x => x.OpJel == "+")} db");

