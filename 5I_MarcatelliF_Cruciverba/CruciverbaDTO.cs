class CruciverbaDTO
{
    public string Solution {get; set;}
    public int Width {get; set;}
    public int Height {get; set;}
    public List<SuggerimentoDTO> SuggerimentiOriz { get; set; }
    public List<SuggerimentoDTO> SuggerimentiVert { get; set; }
}