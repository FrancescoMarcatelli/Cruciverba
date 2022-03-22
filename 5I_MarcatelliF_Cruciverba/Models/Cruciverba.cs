public class Cruciverba
{
    
    public int CruciverbaId {get; set;}
    public string Solution {get; set;}
    public int Width {get; set;}
    public int Height {get; set;}

    public ICollection<Suggerimento> suggerimentos {get; set;}
    
}