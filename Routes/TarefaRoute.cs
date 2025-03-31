using EstudoApiTarefas.Models;

namespace EstudoApiTarefas.Routes;

public static class TarefaRoute
{
    public static void TarefaRoutes(this WebApplication app)
    {
        app.MapGet("tarefa", () => new TarefaModel("Limpar a casa"));
    }
}