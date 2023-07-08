using Projecting;

Random random = new Random();

List<int> numbers = Enumerable.Range(0, 101)
    .Select(_ => random.Next(0, 101))
    .ToList();

List<NumberMetaData> metadataList = numbers
    .Select(num => new NumberMetaData
    {
        IsEven = num % 2 == 0,
        NumberOfCharacters = num.ToString().Length
    })
    .ToList();

foreach (NumberMetaData metadata in metadataList)
{
    Console.WriteLine("pari: " + metadata.IsEven + ", numero dei caratteri: " + metadata.NumberOfCharacters);
}
