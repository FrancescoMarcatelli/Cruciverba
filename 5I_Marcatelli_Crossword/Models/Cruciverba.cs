public class Cruciverba
{
    
    public int Id {get; set;}
    public string Solution {get; set;}
    public int Width {get; set;}
    public int Height {get; set;}

    public int? SuggerimentoId { get; set; }
    public Suggerimento Suggerimento { get; set; }
}