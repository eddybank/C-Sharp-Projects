

using System.Globalization;

DateTime today = DateTime.Now;

//DateTime birthday = DateTime.Parse("6/15/1998");

//DateTime birthday = DateTime.ParseExact("6/11/1998", "d/M/yyyy", CultureInfo.InvariantCulture);
//Console.WriteLine(birthday.ToString());

Console.WriteLine(today.ToString("t"));

Console.WriteLine("Japan date: {0}", today.ToString("D", new CultureInfo("ja-JP")));

Console.WriteLine(today.ToString("MMMM dd, yyyy hh:mm tt zzz"));

// 'day' the 'day #' of 'month' 'year'
Console.WriteLine(today.ToString("dddd") + " the " + today.ToString("dd") + " of " + today.ToString("MMMM yyyy"));
