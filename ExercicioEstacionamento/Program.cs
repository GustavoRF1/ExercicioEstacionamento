using ExercicioEstacionamento;

List<Veiculo> veiculos = new List<Veiculo>();
List<Pessoa> pessoas = new List<Pessoa>();
List<Veiculo> Alugados = new List<Veiculo>();

#region AdicionandoDados

Carro carro1 = new Carro();
carro1.SetModelo("Model S");
carro1.SetMarca("Tesla");
carro1.SetPlaca("ABC1234");
carro1.SetValorDiaria(500.0);
carro1.SetQuantidadePortas(4);
DateTime AluguelCarro1 = new DateTime(2025, 10, 1);
carro1.SetDataAluguel(AluguelCarro1);
carro1.SetLocador("Empresa XYZ");

Carro carro2 = new Carro();
carro2.SetModelo("Civic");
carro2.SetMarca("Honda");
carro2.SetPlaca("DEF5678");
carro2.SetValorDiaria(200.0);
carro2.SetQuantidadePortas(4);
DateTime AluguelCarro2 = new DateTime(2025, 10, 10);
carro2.SetDataAluguel(AluguelCarro2);
carro2.SetLocador("Empresa XYZ");


Caminhao caminhao1 = new Caminhao();
caminhao1.SetModelo("FH16");
caminhao1.SetMarca("Volvo");
caminhao1.SetPlaca("GHI9012");
caminhao1.SetValorDiaria(800.0);
caminhao1.SetCapacidadeCarga(20000);
caminhao1.SetNumeroEixos(4);

Moto moto1 = new Moto();
moto1.SetModelo("Ninja");
moto1.SetMarca("Kawasaki");
moto1.SetPlaca("JKL3456");
moto1.SetValorDiaria(150.0);
moto1.SetCilindradas(600);
DateTime AluguelMoto1 = new DateTime(2025, 10, 15);
moto1.SetDataAluguel(AluguelMoto1);
moto1.SetLocador("João Silva");


veiculos.Add(carro1);
veiculos.Add(carro2);
veiculos.Add(caminhao1);
veiculos.Add(moto1);

PessoaFisica pf1 = new PessoaFisica();
pf1.SetNome("João Silva");
pf1.SetTelefone("11999999999");
pf1.SetCpf("123.456.789-00");
pf1.SetVeiculosAlugados("JKL3456");

PessoaJuridica pj1 = new PessoaJuridica();
pj1.SetNome("Empresa XYZ");
pj1.SetTelefone("1133333333");
pj1.SetCnpj("12.345.678/0001-99");
pj1.SetVeiculosAlugados("ABC1234, DEF5678");

pessoas.Add(pf1);
pessoas.Add(pj1);


Alugados.Add(carro1);
Alugados.Add(carro2);
Alugados.Add(moto1);

#endregion

int opcao;

do
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Adicionar Veículo");
    Console.WriteLine("2. Adicionar Pessoa");
    Console.WriteLine("3. Listar Veículos e Clientes");
    Console.WriteLine("4. Alugar um veículo");
    Console.WriteLine("5. Verificar valores á receber");
    Console.WriteLine("6. Devolução de locação");
    Console.WriteLine("7. Remover Veículo");
    Console.WriteLine("0. Sair");
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine("Digite o tipo de veículo: ");
            Console.WriteLine("1. Carro");
            Console.WriteLine("2. Caminhão");
            Console.WriteLine("3. Moto");
            int tipoVeiculo = int.Parse(Console.ReadLine());
            if (tipoVeiculo == 1)
            {
                Carro carro = new Carro();
                Console.Write("Digite o modelo do carro: ");
                carro.SetModelo(Console.ReadLine());
                Console.Write("Digite a marca do carro: ");
                carro.SetMarca(Console.ReadLine());
                Console.Write("Digite o valor da diária do carro: ");
                carro.SetValorDiaria(double.Parse(Console.ReadLine()));
                Console.WriteLine("Digite a placa do carro: ");
                carro.SetPlaca(Console.ReadLine());
                Console.Write("Digite a quantidade de portas do carro: ");
                carro.SetQuantidadePortas(int.Parse(Console.ReadLine()));
                veiculos.Add(carro);
                break;
            }
            else if (tipoVeiculo == 2)
            {
                Caminhao caminhao = new Caminhao();
                Console.Write("Digite o modelo do caminhão: ");
                caminhao.SetModelo(Console.ReadLine());
                Console.Write("Digite a marca do caminhão: ");
                caminhao.SetMarca(Console.ReadLine());
                Console.Write("Digite o valor da diária do caminhão: ");
                caminhao.SetValorDiaria(double.Parse(Console.ReadLine()));
                Console.WriteLine("Digite a placa do caminhão: ");
                caminhao.SetPlaca(Console.ReadLine());
                Console.Write("Digite a capacidade de carga do caminhão: ");
                caminhao.SetCapacidadeCarga(double.Parse(Console.ReadLine()));
                Console.Write("Digite o número de eixos do caminhão: ");
                caminhao.SetNumeroEixos(int.Parse(Console.ReadLine()));
                veiculos.Add(caminhao);
                break;
            }
            else if (tipoVeiculo == 3)
            {
                Moto moto = new Moto();
                Console.Write("Digite o modelo da moto: ");
                moto.SetModelo(Console.ReadLine());
                Console.Write("Digite a marca da moto: ");
                moto.SetMarca(Console.ReadLine());
                Console.Write("Digite o valor da diária da moto: ");
                moto.SetValorDiaria(double.Parse(Console.ReadLine()));
                Console.WriteLine("Digite a placa da moto: ");
                moto.SetPlaca(Console.ReadLine());
                Console.Write("Digite a cilindrada da moto: ");
                moto.SetCilindradas(int.Parse(Console.ReadLine()));
                veiculos.Add(moto);
                break;
            }
            else
            {
                Console.WriteLine("Tipo de veículo inválido.");
                break;
            }

        case 2:
            Console.WriteLine("Digite o tipo de Pessoa: ");
            Console.WriteLine("1 - Pessoa Física");
            Console.WriteLine("2 - Pessoa Jurídica");
            int tipoPessoa = int.Parse(Console.ReadLine());
            if (tipoPessoa == 1)
            {
                PessoaFisica pf = new PessoaFisica();
                Console.Write("Digite o nome: ");
                pf.SetNome(Console.ReadLine());
                Console.Write("Digite o telefone: ");
                pf.SetTelefone(Console.ReadLine());
                Console.Write("Digite o CPF: ");
                pf.SetCpf(Console.ReadLine());
                pessoas.Add(pf);
                break;
            }
            else if (tipoPessoa == 2)
            {
                PessoaJuridica pj = new PessoaJuridica();
                Console.Write("Digite o nome: ");
                pj.SetNome(Console.ReadLine());
                Console.Write("Digite o telefone: ");
                pj.SetTelefone(Console.ReadLine());
                Console.Write("Digite o CNPJ: ");
                pj.SetCnpj(Console.ReadLine());
                pessoas.Add(pj);
                break;
            }
            else
            {
                Console.WriteLine("Tipo de pessoa inválido.");
                break;
            }
        case 3:

            Console.WriteLine("\nVeículos no inventário: ");
            veiculos.OrderBy(Veiculo => Veiculo.GetMarca());
            pessoas.OrderBy(Pessoa => Pessoa.GetNome());

            foreach (Veiculo veiculo in veiculos)
            {
                veiculo.ExibirInformacoes();
                Console.WriteLine("---------------------");
            }
            Console.WriteLine("\nClientes cadastrados: ");
            foreach (Pessoa pessoa in pessoas)
            {
                pessoa.ExibirInformacoes();
                Console.WriteLine("---------------------");
            }
            Console.WriteLine("\nVeiculos alugados: ");
            foreach (Veiculo veiculo in Alugados)
            {
                veiculo.SetAlugado(pessoas.Any(pessoas => pessoas.GetVeiculosAlugados() != null && pessoas.GetVeiculosAlugados().Split(", ").Contains(veiculo.GetPlaca())));
                if (veiculo.GetAlugado())
                {
                    Console.WriteLine(veiculo.ToString());
                    Console.WriteLine("---------------------");
                }
            }

            break;
        case 4:

            Console.WriteLine("\nVeiculos disponíveis: ");
            foreach (Veiculo veiculo in veiculos)
            {
                veiculo.SetAlugado(pessoas.Any(pessoas => pessoas.GetVeiculosAlugados() != null && pessoas.GetVeiculosAlugados().Split(", ").Contains(veiculo.GetPlaca())));
                if (!veiculo.GetAlugado())
                {
                    Console.WriteLine(veiculo.ToString());
                    Console.WriteLine("---------------------");

                }
            }
            Console.WriteLine("Deseja alugar algum desses veículos?(S ou N): ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 'S')
            {
                Console.WriteLine("Digite o nome do cliente: ");
                string nomeCliente = Console.ReadLine();

                Pessoa cliente = pessoas.Find(pessoa => pessoa.GetNome().Equals(nomeCliente, StringComparison.OrdinalIgnoreCase));

                if (cliente == null)
                {
                    Console.WriteLine("Não foi encontrado nenhum cliente");
                }
                else
                {
                    Console.WriteLine("Digite a placa do veículo que deseja alugar");
                    string placa = Console.ReadLine();
                    foreach (Veiculo veiculo in veiculos)
                    {
                        veiculos.Find(v => v.GetPlaca().Equals(placa, StringComparison.OrdinalIgnoreCase));
                        if (!veiculo.GetAlugado())
                        {
                            cliente.SetVeiculosAlugados(placa);
                            {
                                veiculo.SetAlugado(true);
                                veiculo.SetDataAluguel(DateTime.Today);
                                veiculo.SetLocador(cliente.GetNome());
                                Alugados.Add(veiculo);
                            }
                            Console.WriteLine("Veículo alugado");
                        }
                    }
                }
            }

            break;

        case 5:

            DateTime dataAtual = DateTime.Today;
            foreach (Veiculo veiculo in Alugados)
            {
                if (veiculo.GetLocador() != null)
                {
                    double totalReceber = 0.0;
                    if (veiculo.GetLocador() != null)
                    {
                        TimeSpan diferencaDias = dataAtual - veiculo.GetDataAluguel();
                        int diasAluguel = diferencaDias.Days;
                        double valorDevido = diasAluguel * veiculo.GetValorDiaria();
                        totalReceber += valorDevido;
                    }
                    Console.WriteLine($"{veiculo.GetLocador()}\nPlaca: {veiculo.GetPlaca()}\nValor Total: {totalReceber} ");
                }
            }
            break;
        case 6:

            Console.WriteLine("Deseja remover o veículo da lista de alugados: ");
            char respostaRemover = char.Parse(Console.ReadLine());

            if (respostaRemover == 'S')
            {
                Console.WriteLine("Digite a placa do veículo que deseja remover: ");
                string placaRemover = Console.ReadLine();
                Veiculo veiculoRemover = Alugados.Find(v => v.GetPlaca().Equals(placaRemover, StringComparison.OrdinalIgnoreCase));
                if (veiculoRemover != null)
                {
                    veiculoRemover.SetAlugado(false);
                    veiculoRemover.SetLocador(null);
                    veiculoRemover.SetDataAluguel(DateTime.MinValue);
                    Alugados.Remove(veiculoRemover);
                    Console.WriteLine("Veículo removido da lista de alugados");
                }
                else
                {
                    Console.WriteLine("Veículo não encontrado na lista de alugados");
                }
            }

            break;

        case 7:

            Console.WriteLine("Digite a placa do veículo que deseja remover: ");
            string placaRemoverFrota = Console.ReadLine();

            Veiculo veiculoRemoverFrota = veiculos.Find(v => v.GetPlaca().Equals(placaRemoverFrota, StringComparison.OrdinalIgnoreCase));
            if (veiculoRemoverFrota != null)
            {
                veiculos.Remove(veiculoRemoverFrota);
                Console.WriteLine("Veículo removido da frota");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado na frota");
            }

            break;
        case 0:
            Console.WriteLine("- - - Saindo - - -");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
} while (opcao != 0);

