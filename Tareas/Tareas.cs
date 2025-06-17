namespace Tareas
{
    public class Tarea
    {
        public int userId { get; set; }
        public int Id { get; set; }
        public string? title { get; set; }
        public bool completed { get; set; }
        public Tarea(int userId, int id, string? title, bool completed)
        {
            this.userId = userId;
            this.Id = id;
            this.title = title;
            this.completed = completed;
        }
    }
}