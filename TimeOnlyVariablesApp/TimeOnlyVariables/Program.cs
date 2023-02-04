

TimeOnly opensAt = TimeOnly.Parse("8:00 AM");

// get time only from DateTime
TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);

Console.WriteLine(opensAt.ToString());
Console.WriteLine(rightNow.ToString());
