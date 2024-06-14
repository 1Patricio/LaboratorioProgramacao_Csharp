//Herança
public class Pessoa{
    public int Id;
    public string Endereco;
    public bool Situacao;

    public void LerEndereco(string endereco){
        this.Endereco = endereco;
    
    }

}

public class PessoaFisica:Pessoa{
    public string Cpf;
}

public class PessoaJuridica:Pessoa{
    public string Cnpj;
}