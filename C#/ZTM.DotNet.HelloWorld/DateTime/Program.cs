DateTime dateOfBirth = new DateTime(1998, 1, 22);
Console.WriteLine(dateOfBirth.DayOfWeek);

//computed valued
DateTime today = DateTime.Today;
DateTime now = DateTime.Now;
DateTime utcNow = DateTime.UtcNow;

//DateTime parsing
DateTime localDate = DateTime.Parse("1/22/1998");

//DateTime Formatting
Console.WriteLine(dateOfBirth.ToString("MM.dd.yyyy"));