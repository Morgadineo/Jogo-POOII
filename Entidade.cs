using System;
using System.Collections.Generic;


public abstract class Entidade
{
    public int VidaMaxima;
    public string Nome;
    public string Tipo;
    public int Vida;
    public int DanoMaximo;
    public int DanoMinimo;
    public int Defesa;
    public Dictionary<Slot, IItem> Equipamentos;

    public Random r = new Random();

    public bool EstaMorto()
    {
        if (this.Vida < 0)
        {
            return true;
        }
        return false;
    }

    public void PrintarEntidade()
    {
        Console.Write($"\n*===== {this.Nome} - Um {this.Tipo} =====*\n");
        Console.Write($"| Vida: {this.VidaMaxima} --> {this.Vida} |\n");
        Console.Write($"| Dano: [{this.DanoMaximo} --> {this.DanoMinimo}] |\n\n");
    }

    public int CalcularDano() {
        return r.Next(this.DanoMinimo, this.DanoMaximo + 1); // + 1 pois Next(0, 4) gera um valor de 0 a 3
    }

    public void RealizarAtaque(Entidade atacado)
    {
        atacado.TomarDano(this, this.CalcularDano());
    }

    public void TomarDano(Entidade atacante, int danoRecebido)
    {
        danoRecebido -= this.Defesa;
        if (danoRecebido > 0)
        {
            Console.WriteLine($"\n{this.Nome} recebeu {danoRecebido} de dano.");
            this.Vida -= danoRecebido;
            // Verificar vida < 0
            if (EstaMorto())
            {
                Console.WriteLine($"\n{this.Nome} foi morto por {atacante.Nome}");
            }
        }
        else
        {
            Console.WriteLine($"{this.Nome} bloqueou o ataque!");
        }
    }

}