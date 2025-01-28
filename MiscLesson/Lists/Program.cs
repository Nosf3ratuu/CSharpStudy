var words = new List<string>
{
    "one",
    "two",
};
foreach(var word in words)
{
    Console.WriteLine(word);
}

Console.WriteLine("Removing an element");
words.Remove("two");

foreach (var word in words)
{
    Console.WriteLine(word);
}

words.AddRange(new[] { "two", "three", "four", "five" });
foreach (var word in words)
{
    Console.WriteLine(word);
}

Console.WriteLine("Index of element four is:" + words.IndexOf("four"));
Console.WriteLine("Index of element seven is:" + words.IndexOf("seven"));
Console.WriteLine("Contains 'five'?: " + words.Contains("five"));
Console.WriteLine("Contains 'seven'?: " + words.Contains("seven"));


Console.ReadKey();