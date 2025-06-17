using Tareas;
using JsonSerializer = System.Text.Json.JsonSerializer;
HttpClient client = new();
HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos");
response.EnsureSuccessStatusCode();

if (response.IsSuccessStatusCode)
{
    string responseBody = await response.Content.ReadAsStringAsync();
    List<Tarea> listTarea = JsonSerializer.Deserialize<List<Tarea>>(responseBody)!;

    Console.WriteLine("\n\tTareas pendientes:\n");
    foreach (var tarea in listTarea)
    {
        if (!tarea.completed)
        {
            Console.WriteLine($"Title: {tarea.title}, Estado: pendiente");
        }
    }

    Console.WriteLine("\n\tTareas realizadas:\n");
    foreach (var tarea in listTarea)
    {
        if (tarea.completed)
        {
            Console.WriteLine($"\tTitle: {tarea.title}, Estado: realizada");
        }
    }
    string jsonString = JsonSerializer.Serialize(listTarea);
    Console.WriteLine($"\nPrimer elemento serializado: {jsonString}");
    FileInfo JsonTarea = new("C:/Users/maxi0/Documents/facultad/tercer_anio/taller1/practica/tl1-tp10-2025-DrMaxiPaz/Tareas/tareas.json");
    using (StreamWriter sw = File.CreateText(JsonTarea.FullName))
    {
        sw.Write(jsonString);
    }
}
else
{
    Console.WriteLine($"Error: {response.StatusCode}");
}



