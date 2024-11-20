using System.Runtime.InteropServices;
using System.Text.Json;

Console.WriteLine("***** Testes com .NET 9 | GUIDs UUID Version 7 *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");

List<Guid> guidsV4 = new();
for (int i = 1; i <= 5; i++)
{
    var guid = Guid.NewGuid();
    guidsV4.Add(guid);
    Console.WriteLine($"{guid} - versao {guid.Version}");
    Thread.Sleep(1000);
}
Console.WriteLine();

Console.WriteLine($"Guids V4: {JsonSerializer.Serialize(guidsV4)}");
Console.WriteLine();

Console.WriteLine($"Guids V4 - Order(): {JsonSerializer.Serialize(guidsV4.Order())}");
Console.WriteLine();


List<Guid> guidsV7 = new();
for (int i = 1; i <= 5; i++)
{
    var guid = Guid.CreateVersion7();
    guidsV7.Add(guid);
    Console.WriteLine($"{guid} - versao {guid.Version}");
    Thread.Sleep(1000);
}
Console.WriteLine();

Console.WriteLine($"Guids V7: {JsonSerializer.Serialize(guidsV7)}");
Console.WriteLine();

Console.WriteLine($"Guids V7 - Order(): {JsonSerializer.Serialize(guidsV7.Order())}");
Console.WriteLine();


List<Guid> guidsV7Utc = new();
for (int i = 1; i <= 5; i++)
{
    var guid = Guid.CreateVersion7(DateTimeOffset.UtcNow);
    guidsV7Utc.Add(guid);
    Console.WriteLine($"{guid} - versao {guid.Version}");
    Thread.Sleep(1000);
}
Console.WriteLine();

Console.WriteLine($"Guids V7 UTC: {JsonSerializer.Serialize(guidsV7Utc)}");
Console.WriteLine();

Console.WriteLine($"Guids V7 UTC - Order(): {JsonSerializer.Serialize(guidsV7Utc.Order())}");
Console.WriteLine();