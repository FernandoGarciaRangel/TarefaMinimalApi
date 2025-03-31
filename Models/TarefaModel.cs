namespace EstudoApiTarefas.Models;

public class TarefaModel
{
    public TarefaModel(string name)
    {
        Name = name;
        Id = Guid.NewGuid();
    }
    
    public Guid Id { get; init; }  //init significa que só pode ser alterado uma vez
    public string Name { get; private set; } = string.Empty;
    
    
}