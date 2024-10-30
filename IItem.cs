using System;

public interface IItem
{
    string Tipo { get; }
    string Nome { get; }
    int ModVidaMaxima { get; }
    int ModDefesa { get; }
    int ModDanoMaximo { get; }
    int ModDanoMinimo { get; }
    
    // Método abstrato para aplicar efeitos especiais em combate
    void AplicarEfeitoEspecial(Entidade atacante, Entidade alvo);
}
