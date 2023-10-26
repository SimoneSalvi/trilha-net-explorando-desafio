using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa esposa = new Pessoa(nome: "Maria", sobrenome: "Antônia");
Pessoa esposo = new Pessoa(nome: "Pedro", sobrenome: "Henrique");
Pessoa filha = new Pessoa(nome: "Clarinha", sobrenome: "Antônia Henrique");
Pessoa filho = new Pessoa(nome: "Pedrinho", sobrenome: "Henrique Junior");

hospedes.Add(esposa);
hospedes.Add(esposo);
hospedes.Add(filha);
hospedes.Add(filho);

// Cria a suíte
Suite suiteDupla = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 30);
Suite suiteSimples = new Suite(tipoSuite: "Basic", capacidade: 2, valorDiaria: 15);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reservaFamilia = new Reserva(diasReservados: 10);
reservaFamilia.CadastrarSuite(suiteDupla);
reservaFamilia.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reservaFamilia.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reservaFamilia.CalcularValorDiaria(reservaFamilia)}");