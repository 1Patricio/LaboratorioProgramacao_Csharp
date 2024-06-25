public class Carro:Veiculo
{
    public override void Acelerar()
    {
        Velocidade += 10;
    }

    public override void Frear()
    {
        Velocidade -= 5;
    }
}