//Herança

PessoaFisica pf = new PessoaFisica();
pf.Cpf = "123.456.789-10";
pf.Endereco = "Rua A";
pf.Situacao = true;
pf.Id = 1;
pf.LerEndereco(pf.Endereco);

PessoaJuridica pj = new PessoaJuridica();
pj.Cnpj = "12.345.678/0910-11";
pj.Endereco = "Rua B";
pj.Situacao = false;
pj.Id = 2;
pj.LerEndereco(pf.Endereco);