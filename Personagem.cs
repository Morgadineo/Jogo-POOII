using System.Collections.Generic;

public class Personagem : Entidade
{
    public Personagem()
    {
        this.VidaMaxima = 10;
        this.Vida = 10;
        this.Defesa = 0;
        this.Nome = "Desconhecido";
        this.Tipo = "Player";
        this.DanoMaximo = 3;
        this.DanoMinimo = 1;
        this.Equipamentos = new Dictionary<Slot, IItem>();
    }

    public Personagem(string nome)
    {
        this.VidaMaxima = 10;
        this.Vida = 10;
        this.Defesa = 0;
        this.Nome = nome;
        this.Tipo = "Player";
        this.DanoMaximo = 3;
        this.DanoMinimo = 1;
        this.Equipamentos = new Dictionary<Slot, IItem>();
    }

}