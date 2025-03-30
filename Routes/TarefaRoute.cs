namespace EstudoApiTarefas.Routes;

public static class TarefaRoute
{
    public static void TarefaRoutes(this WebApplication app)
    {
        app.MapGet("tarefa", () => "Olá pessoa!");
    }
}