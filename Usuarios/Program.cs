using Usuarios;

using JsonSerializer = System.Text.Json.JsonSerializer;
//creo un nuevo cliente HTTP
HttpClient client = new();
//obtengo la respuesta de la API
HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/users");
//verifico que la respuesta sea exitosa
response.EnsureSuccessStatusCode();
//leo el contenido de la respuesta
if (response.IsSuccessStatusCode)
{
    string responseBody = await response.Content.ReadAsStringAsync();
    List<Usuario> listUsuarios = JsonSerializer.Deserialize<List<Usuario>>(responseBody)!;
    //muestro los datos de los usuarios
    Console.WriteLine("\n\tUsuarios:\n");
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Nombre: {listUsuarios[i].name}, correo electronico: {listUsuarios[i].email}, Domicilio: {listUsuarios[i].address.street}, {listUsuarios[i].address.suite}, {listUsuarios[i].address.city}, {listUsuarios[i].address.zipcode}");
    }
}
else
{
    Console.WriteLine($"Error: {response.StatusCode}");
}