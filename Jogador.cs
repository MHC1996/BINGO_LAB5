using System.Text.Json;
using System.Text.Json.Serialization;

namespace Prova;


public class Jogador
{
    
    public Jogador(){
        Cartelas = new List<double>();
        
    }
    
    private static int increment = 1;
    
    public Jogador(int id, String nome)
    {
        Id = id;
        Nome = nome;
       
    }

    public int Id { get; set; }

    public String Nome { get; set; }

     

    public List<double> ? Cartelas { get; set;}

    [JsonIgnore]
   public double Cartela => Cartelas.Any() ? Cartelas.Average() : 0;

}


