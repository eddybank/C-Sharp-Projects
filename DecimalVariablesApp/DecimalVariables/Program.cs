
// 4.12, 32, 1.234
// 4.12, 32, 1.234

// Int32 - 00000000 00000000 00000000 00000001

decimal bankAccountBalance;

// If you simply use 2.34, bankAccountBalance = 2.34;, compiler will see this as a double. 
// Need to indicate its type using M
bankAccountBalance = 2.34M;

Console.WriteLine(bankAccountBalance);