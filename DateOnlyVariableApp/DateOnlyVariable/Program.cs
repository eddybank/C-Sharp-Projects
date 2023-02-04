

DateTime today = DateTime.Now;

DateOnly birthday = DateOnly.Parse("6/11/1998");

Console.WriteLine(birthday.ToString("MMMM dd yyyy"));

Console.WriteLine($"Today full format: {today}");

// DateTime.Date will produce date with time set to 12:00:00 (00:00:00) so formatting is necessary in situations that dont expect any time
Console.WriteLine($"Today just date: {today.Date.ToString("MM/d/yyyy")}");

Console.WriteLine($"Birthday full format: {birthday}");
