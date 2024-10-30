using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Criação dos personagens
        Personagem player1 = new Personagem("Player1");
        Personagem player2 = new Personagem("Player2");

        // Equipamento dos personagens com itens personalizados usando decorators
        Anel anelBase = new Anel();
        
        // Player 1 recebe um anel "Adornado" que aumenta atributos
        IItem anelAdornado = new Adornado(anelBase);
        player1.Equipamentos[Slot.Anel1] = anelAdornado;

        // Player 2 recebe um anel "Reflexivo" que reflete dano
        IItem anelReflexivo = new Reflexivo(anelBase);
        player2.Equipamentos[Slot.Anel1] = anelReflexivo;

        // Aplicar efeitos iniciais dos itens nos personagens
        AplicarEfeitosIniciais(player1);
        AplicarEfeitosIniciais(player2);

        // Início do combate entre os personagens
        Combate(player1, player2);
    }

    static void Combate(Entidade enti1, Entidade enti2)
    {
        Console.WriteLine($"\n*** Início do Combate: {enti1.Nome} VS {enti2.Nome} ***\n");
        
        do
        {
            enti1.RealizarAtaque(enti2);
            if (!enti2.EstaMorto())
                enti2.RealizarAtaque(enti1);
            else
                break;
        } while (!enti1.EstaMorto());

        Console.WriteLine("\n*** Fim do Combate ***");
        Console.WriteLine($"{enti1.Nome} {(enti1.EstaMorto() ? "foi derrotado" : "venceu")}!");
        Console.WriteLine($"{enti2.Nome} {(enti2.EstaMorto() ? "foi derrotado" : "venceu")}!");
    }

    static void AplicarEfeitosIniciais(Personagem personagem)
    {
        foreach (var equipamento in personagem.Equipamentos.Values)
        {
            // Cada item com decorators aplicará seus efeitos ao personagem
            personagem.VidaMaxima += equipamento.ModVidaMaxima;
            personagem.Defesa += equipamento.ModDefesa;
            personagem.DanoMaximo += equipamento.ModDanoMaximo;
            personagem.DanoMinimo += equipamento.ModDanoMinimo;
        }

        Console.WriteLine($"\n{personagem.Nome} equipado com itens:");
        foreach (var equipamento in personagem.Equipamentos.Values)
        {
            Console.WriteLine($"- {equipamento.Nome} ({equipamento.GetType().Name})");
        }
        personagem.PrintarEntidade();
    }
}
