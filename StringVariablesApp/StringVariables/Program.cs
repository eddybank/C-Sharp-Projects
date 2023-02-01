

string firstName = string.Empty;
string lastName = string.Empty;
string filePath = string.Empty;

firstName = "Eddy";
lastName = "Bank";
//filePath = "C:\\Temp\\Demo";

//use the @ to take the string literally (String Literal)
filePath = @"C:\Temp\Demo";

//firstName = "123";

//Console.WriteLine(firstName + " " + lastName);
//Console.WriteLine("{0} {1}", firstName, lastName);

// String interpolation and String literal together
string testString = $@"The file for {firstName} is at C:\SampleFiles";

// String interpolation
Console.WriteLine($"{firstName} {lastName}");
Console.WriteLine(filePath);
Console.WriteLine(testString);

