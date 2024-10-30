using System;
using System.Collections.Generic;

public abstract class ItemDecorator : IItem
{
    public List<string> TiposAplicaveis { get; set; } = new List<string>();
    public string Caracteristica;
    public int Raridade;
    protected IItem _item;

    // Propriedades do IItem
    public string Tipo { get; set; }
    public string Nome { get; set; }
    public int ModVidaMaxima { get; set; }
    public int ModDefesa { get; set; }
    public int ModDanoMaximo { get; set; }
    public int ModDanoMinimo { get; set; }

    public ItemDecorator(IItem item)
    {
        this._item = item;
        this.Tipo = item.Tipo;
        this.Nome = item.Nome;
        this.ModVidaMaxima = item.ModVidaMaxima;
        this.ModDefesa = item.ModDefesa;
        this.ModDanoMaximo = item.ModDanoMaximo;
        this.ModDanoMinimo = item.ModDanoMinimo;


    }

    public bool VerificarTipoAplicavel(string tipo)
    {
        return TiposAplicaveis.Contains(tipo);
    }

    public abstract int Efeito(int mod);

    // Implementação padrão de AplicarEfeitoEspecial
    public virtual void AplicarEfeitoEspecial(Entidade atacante, Entidade atacado)
    {
        _item?.AplicarEfeitoEspecial(atacante, atacado);
    }
}
