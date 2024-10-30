using System;

public class Anel : IItem
{
    // Propriedades requeridas pela interface IItem
    public string Tipo { get; set; }
    public string Nome { get; set; }
    public int ModVidaMaxima { get; set; }
    public int ModDefesa { get; set; }
    public int ModDanoMaximo { get; set; }
    public int ModDanoMinimo { get; set; }

    public Anel()
    {
        this.Tipo = "Anel";
        this.Nome = "Anel Básico";
        this.ModVidaMaxima = 0;
        this.ModDefesa = 0;
        this.ModDanoMaximo = 0;
        this.ModDanoMinimo = 0;
    }

    // Implementação do método abstrato Descricao
    public string Descricao()
    {
        return $"{Nome} - Um anel simples sem efeitos especiais.";
    }

    // Implementação do método abstrato Efeito
    public void Efeito()
    {
        Console.WriteLine($"{Nome} não possui efeitos adicionais.");
    }

    public void AplicarEfeitoEspecial(Entidade ent1, Entidade ent2)
    {
        Console.WriteLine($"{Nome} não possui efeitos especial.");
    }
}
