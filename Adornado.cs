public class Adornado : ItemDecorator
{
    public Adornado(IItem item) : base(item)
    {
        TiposAplicaveis.Add("Anel"); // Definindo que "Anel" é um tipo compatível
        Caracteristica = "Adornado";
        Raridade = 2;
        ModVidaMaxima += 1;
        ModDefesa += 1;
        ModDanoMaximo += 1;
        ModDanoMinimo += 1;
    }

    public override int Efeito(int mod)
    {
        // Aumenta o modificador passado por exemplo
        return mod + 1;
    }
}
