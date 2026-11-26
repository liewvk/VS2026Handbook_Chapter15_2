using System;
using System.IO;
string[] report = { "Month,Sales", "Jan,1200", "Feb,1650", "Mar,1810" };
File.WriteAllLines("sales.csv", report);
foreach (string line in File.ReadAllLines("sales.csv"))
    Console.WriteLine(line);

