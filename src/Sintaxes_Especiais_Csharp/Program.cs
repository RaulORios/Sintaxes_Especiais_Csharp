using System;
using System.Globalization;

namespace Sintaxes_Especiais_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inferência tipo: var

            //var x = 10;
            //var y = 20.0;
            //var z = "Maria";

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //________________________________________________________________________

            // switch-case

            //int x = int.Parse(Console.ReadLine());
            //string day;

            //switch (x)
            //{
            //    case 1:
            //        day = "Sunday";
            //        break;
            //    case 2:
            //        day = "Monday";
            //        break;
            //    case 3:
            //        day = "Tuesday";
            //        break;
            //    case 4:
            //        day = "Wednesday";
            //        break;
            //    case 5:
            //        day = "Thursday";
            //        break;
            //    case 6:
            //        day = "Friday";
            //        break;
            //    case 7:
            //        day = "Saturday";
            //        break;
            //    default:
            //        day = "Invalid value";
            //        break;
            //}

            //Console.WriteLine($"Day: {day}");

            //________________________________________________________________________

            //Expressão Condicional Ternária

            //double preco = double.Parse(Console.ReadLine());

            //double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            //Console.WriteLine(desconto);

            //________________________________________________________________________

            //Funções interessantes para String

            //string original = "abcde FGHIJ ABC abc DEFG    ";

            //// Converter tudo para maisculo.
            //string s1 = original.ToUpper();
            //// Converter tudo para minusculo.
            //string s2 = original.ToLower();
            //// Apaga os espaços em breanco.
            //string s3 = original.Trim();

            //// Procura primeira
            //int n1 = original.IndexOf("bc");
            //// Procura ultima
            //int n2 = original.LastIndexOf("bc");

            //// Cortar um String            
            //string s4 = original.Substring(3); // corta a partir da posição informada
            //string s5 = original.Substring(3, 5); // corta a partir da posição informada e mostra qtos caracteres após conforme informado também

            //// Substituir parte da string por outra            
            //string s6 = original.Replace('a', 'x'); // por letra
            //string s7 = original.Replace("abc", "xy"); // por string

            //// String Vazia
            //bool b1 = string.IsNullOrEmpty(original);
            //bool b2 = string.IsNullOrWhiteSpace(original);



            //Console.WriteLine($"Original: - {original} -");
            //Console.WriteLine();
            //Console.WriteLine($"ToUpper: - {s1} -");
            //Console.WriteLine();
            //Console.WriteLine($"ToLower: - {s2} -");
            //Console.WriteLine();
            //Console.WriteLine($"Trim: - {s3} -");
            //Console.WriteLine();
            //Console.WriteLine($"IndexOf('bc'): {n1}");
            //Console.WriteLine();
            //Console.WriteLine($"LastindexOf('bc'): {n2}");
            //Console.WriteLine();
            //Console.WriteLine($"SubString(3): - {s4} -");
            //Console.WriteLine();
            //Console.WriteLine($"SubString(3,5): - {s5} -");
            //Console.WriteLine();
            //Console.WriteLine($"Replace('a','x'): - {s6} -");
            //Console.WriteLine();
            //Console.WriteLine($"Replace('abc','xy'): - {s7} -");
            //Console.WriteLine();
            //Console.WriteLine($"IsNullOrEmpty: - {b1} -");
            //Console.WriteLine();
            //Console.WriteLine($"IsNullOrWhiteSpace: - {b2} -");

            //________________________________________________________________________

            // DateTime

            //DateTime d1 = DateTime.Now; // horario atual do sistema

            //DateTime d2 = new DateTime(2021, 10, 04); //Instaciando o datetime
            //DateTime d3 = new DateTime(2021, 10, 04, 13, 19, 00);

            //DateTime d4 = DateTime.Today;
            //DateTime d5 = DateTime.UtcNow;

            //DateTime d6 = DateTime.Parse("2000-08-15");
            //DateTime d7 = DateTime.Parse("2000-08-15 13:05:08");
            //DateTime d8 = DateTime.Parse("15/08/2000 13:05:08");

            //DateTime d9 = DateTime.ParseExact("2021-10-04", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            //DateTime d10 = DateTime.ParseExact("04/10/2021 13:31:30", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            //Console.WriteLine(d1);
            //Console.WriteLine(d1.Ticks);

            //Console.WriteLine();
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);
            //Console.WriteLine(d5);
            //Console.WriteLine(d6);
            //Console.WriteLine(d7);
            //Console.WriteLine(d8);
            //Console.WriteLine(d9);
            //Console.WriteLine(d10);

            //________________________________________________________________________

            // TimeSpan

            //TimeSpan t1 = new TimeSpan(0, 1, 30);
            //TimeSpan t2 = new TimeSpan();
            //TimeSpan t3 = new TimeSpan(900000000L);
            //TimeSpan t4 = new TimeSpan(02, 11, 21);
            //TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
            //TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);

            //TimeSpan t7 = TimeSpan.FromDays(1.5);
            //TimeSpan t8 = TimeSpan.FromHours(1.5);
            //TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            //TimeSpan t10 = TimeSpan.FromSeconds(1.5);
            //TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
            //TimeSpan t12 = TimeSpan.FromTicks(900000000L);

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);
            //Console.WriteLine(t4);
            //Console.WriteLine(t5);
            //Console.WriteLine(t6);
            //Console.WriteLine();

            //Console.WriteLine(t7);
            //Console.WriteLine(t8);
            //Console.WriteLine(t9);
            //Console.WriteLine(t10);
            //Console.WriteLine(t11);
            //Console.WriteLine(t12);

            //________________________________________________________________________

            // DateTime Propriedades e Operações

            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            //Console.WriteLine(d);
            //Console.WriteLine("1) Date: " + d.Date);
            //Console.WriteLine("2) Day: " + d.Day);
            //Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            //Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            //Console.WriteLine("5) Hour: " + d.Hour);
            //Console.WriteLine("6) Kind: " + d.Kind);
            //Console.WriteLine("7) Millisecond: " + d.Millisecond);
            //Console.WriteLine("8) Minute: " + d.Minute);
            //Console.WriteLine("9) Month: " + d.Month);
            //Console.WriteLine("10) Second: " + d.Second);
            //Console.WriteLine("11) Ticks: " + d.Ticks);
            //Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            //Console.WriteLine("13) Year: " + d.Year);
            //Console.WriteLine();

            //d = new DateTime(2001, 8, 15, 13, 45, 58);

            //string s1 = d.ToLongDateString();
            //string s2 = d.ToLongTimeString();
            //string s3 = d.ToShortDateString();
            //string s4 = d.ToShortTimeString();
            //string s5 = d.ToString();

            //Console.WriteLine();
            //string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            //string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(s4);
            //Console.WriteLine(s5);
            //Console.WriteLine();
            //Console.WriteLine(s6);
            //Console.WriteLine(s7);

            //Console.WriteLine();
            //DateTime d2 = d.AddHours(2);
            //DateTime d3 = d.AddMinutes(3);

            //Console.WriteLine(d);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);

            //DateTime x = ... // Operações
            //DateTime y = x.Add(timeSpan);
            //DateTime y = x.AddDays(double);
            //DateTime y = x.AddHours(double);
            //DateTime y = x.AddMilliseconds(double);
            //DateTime y = x.AddMinutes(double);
            //DateTime y = x.AddMonths(int);
            //DateTime y = x.AddSeconds(double);
            //DateTime y = x.AddTicks(long);
            //DateTime y = x.AddYears(int);
            //DateTime y = x.Subtract(timeSpan);
            //TimeSpan t = x.Subtract(dateTime);

            //________________________________________________________________________

            // TimeSpan Propriedades e Operações

            //TimeSpan t1 = TimeSpan.MaxValue;
            //TimeSpan t2 = TimeSpan.MinValue;
            //TimeSpan t3 = TimeSpan.Zero;

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);

            //TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            //Console.WriteLine(t);

            //Console.WriteLine("Days: " + t.Days);
            //Console.WriteLine("Hours: " + t.Hours);
            //Console.WriteLine("Minutes: " + t.Minutes);
            //Console.WriteLine("Milliseconds: " + t.Milliseconds);
            //Console.WriteLine("Seconds: " + t.Seconds);
            //Console.WriteLine("Ticks: " + t.Ticks);

            //Console.WriteLine("TotalDays: " + t.TotalDays);
            //Console.WriteLine("TotalHours: " + t.TotalHours);
            //Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            //Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            //Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            //TimeSpan t1 = new TimeSpan(1, 30, 10);
            //TimeSpan t2 = new TimeSpan(0, 10, 5);
            //TimeSpan sum = t1.Add(t2);
            //TimeSpan dif = t1.Subtract(t2);
            //TimeSpan mult = t2.Multiply(2.0);
            //TimeSpan div = t2.Divide(2.0);
            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(sum);
            //Console.WriteLine(dif);
            //Console.WriteLine(mult);
            //Console.WriteLine(div);

            //________________________________________________________________________

            // DateTimeKind e Padrão ISO 8601

            //DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

            //DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            //DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            //Console.WriteLine($"d1: {d1}");
            //Console.WriteLine($"d1 Kind: {d1.Kind}");
            //Console.WriteLine($"d1 to Local:{d1.ToLocalTime()}");
            //Console.WriteLine($"d1 to Utc: {d1.ToUniversalTime()}");
            //Console.WriteLine();
            //Console.WriteLine($"d2: {d2}");
            //Console.WriteLine($"d2 Kind: {d2.Kind}");
            //Console.WriteLine($"d2 to Local:{d2.ToLocalTime()}");
            //Console.WriteLine($"d2 to Utc: {d2.ToUniversalTime()}");
            //Console.WriteLine();
            //Console.WriteLine($"d3: {d3}");
            //Console.WriteLine($"d3 Kind: {d3.Kind}");
            //Console.WriteLine($"d3 to Local:{d3.ToLocalTime()}");
            //Console.WriteLine($"d3 to Utc: {d3.ToUniversalTime()}");

            //ISO 8601

            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z"); // CRIA LOCAL DATETIME

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));

            Console.ReadKey();

        }
    }
}
