namespace GerenciamentoDeLojaMVC.Models;

public class Erro
{
    public string? IdSolicitada { get; set; }

    public bool MostrarIdSolicitada => !string.IsNullOrEmpty(IdSolicitada);
}
