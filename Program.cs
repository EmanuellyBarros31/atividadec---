using System.ComponentModel;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
namespace MeuProjeto{

    internal class Program{

  static void Main(string[] args)
    {

      Conta conta = new Conta();
      conta.Titular = "Carlos";
      conta.Depositar(500.0);
      System.Console.WriteLine($"Titular: {conta.Titular}");
        System.Console.WriteLine($"Saldo atual: R$ {conta.consultarSaldo()}");
      
        }
        
        class Conta
    {
      public string Titular {get; set;}

      private double Saldo;

      public void Depositar (double valor){
        if(valor > 0)
        {
          Saldo += valor;
        }
      }
       public double consultarSaldo()
      {
        return Saldo;
      }
      
    }
        
        }

 
}
