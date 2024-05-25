namespace DesafioFundamentos.Models
{
 public class Estacionamento
 {
     private decimal precoInicial = 0;
     private decimal precoPorHora = 0;
     private List<string> veiculos = new List<string>();
 
     // Construtor da classe
     public Estacionamento(decimal precoInicial, decimal precoPorHora)
     {
         this.precoInicial = precoInicial;
         this.precoPorHora = precoPorHora;
     }
 
     // Método para adicionar um veículo ao estacionamento
     public void AdicionarVeiculo()
     {
         // ...
     }
 
     // Método para remover um veículo do estacionamento
     public void RemoverVeiculo()
     {
         // ...
     }
 
     // Método para listar os veículos estacionados
     public void ListarVeiculos()
     {
         // ...
     }
 }
}
public void AdicionarVeiculo()
{
 Console.WriteLine("Digite a placa do veículo para estacionar:");
 string placa = Console.ReadLine();
 
 if (veiculos.Any(v => v.Equals(placa.ToUpper())))
 {
     Console.WriteLine("Já existe um veículo com essa placa.");
 }
 else
 {
     veiculos.Add(placa);
     Console.WriteLine("Veículo estacionado com sucesso!");
 }
}
using DesafioFundamentos.Models;
 
// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;
 
// Declaração das variáveis
decimal precoInicial = 0;
decimal precoPorHora = 0;
 
// Obtém os preços do usuário
Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!\n" +
               "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());
 
Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());
 
// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);
 
// Loop do menu
string opcao = string.Empty;
bool exibirMenu = true;
 
while (exibirMenu)
{
 Console.Clear();
 Console.WriteLine("Digite a sua opção:");
 Console.WriteLine("1 - Cadastrar veículo");
 Console.WriteLine("2 - Remover veículo");
 Console.WriteLine("3 - Listar veículos");
 Console.WriteLine("4 - Encerrar");
 
 switch (Console.ReadLine())
 {
     case "1":
         es.AdicionarVeiculo();
         break;
 
     case "2":
         es.RemoverVeiculo();
         break;
 
     case "3":
         es.ListarVeiculos();
        
 
 break;
 
     case "4":
         exibirMenu = false;
         break;
 
     default:
         Console.WriteLine("Opção inválida");
         break;
 }
 
 Console.WriteLine("Pressione uma tecla para continuar");
 Console.ReadLine();
}
 
Console.WriteLine("O programa se encerrou");