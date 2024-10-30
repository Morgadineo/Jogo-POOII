using System;

public class Reflexivo : ItemDecorator
{
    public Reflexivo(IItem item) : base(item)
    {
        TiposAplicaveis.Add("Anel"); // Suponha que "Reflexivo" seja aplicável a anéis
        Caracteristica = "Reflexivo";
        Raridade = 3;
    }

    public override int Efeito(int mod)
    {
        return mod; // Não altera os modificadores diretamente
    }

    public override void AplicarEfeitoEspecial(Entidade atacante, Entidade atacado)
    {
        int danoRefletido = 2; // Por exemplo, refletindo 2 de dano fixo
        Console.WriteLine($"{atacado.Nome} reflete {danoRefletido} de dano de volta para {atacante.Nome}!");
        atacante.Vida -= danoRefletido;
    }
}
