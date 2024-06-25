public class Moto:Veiculo
{
    public override void Acelerar()
    {
        Velocidade += 15;
    }

    public override void Frear()
    {
        Velocidade -= 10;
    }
}