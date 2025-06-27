using Feriados;

using JsonSerializer = System.Text.Json.JsonSerializer;
//creo un nuevo cliente HTTP
HttpClient client = new();
//obtengo la respuesta de la API
var url = "https://calendarific.com/api/v2/holidays?&api_key=NtA4vs3xl3KJz8KKwImGoO3tGz2eq2I6&country=AR&year=2025";
HttpResponseMessage response = await client.GetAsync(url);
//verifico que la respuesta sea exitosa
response.EnsureSuccessStatusCode();
//leo el contenido de la respuesta
if (response.IsSuccessStatusCode)
{
    string responseBody = await response.Content.ReadAsStringAsync();
    //deserializo la respuesta
    Root root = JsonSerializer.Deserialize<Root>(responseBody)!;
    List<Holiday> holidays = root.response.holidays.ToList();
    //muestro los datos de los usuarios
    Console.WriteLine("\n\tFeriados:\n");
    holidays.ForEach(feriado =>
    {
        Console.WriteLine($"Fecha: {feriado.date.datetime.year:00}-{feriado.date.datetime.month:00}-{feriado.date.datetime.day:00}, Nombre: {feriado.name}, Tipo: {string.Join(", ", feriado.type)}, Descripcion: {feriado.description}");
    });
}
else
{
    Console.WriteLine($"Error: {response.StatusCode}");
}