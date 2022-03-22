public class Suggerimento
{
    public int SuggerimentoId { get; set; }
    public int Numero { get; set; }
    public string Descrizione { get; set; }
    
    public bool isHoriz { get; set; }

    public int? CruciverbaId { get; set; }
    public Cruciverba Cruciverba { get; set; }
}