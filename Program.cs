string frasedigitada, frasealterada;
Console.WriteLine("Digite uma frase: ");

frasedigitada = Console.ReadLine()!;
frasealterada = frasedigitada
.Replace ("a", "AAAA")
.Replace ("e", "EEEE")
.Replace ("i", "IIII")
.Replace ("o", "OOOO")
.Replace ("u", "UUUU");

Console.WriteLine($"Em baleiês: {frasealterada}");