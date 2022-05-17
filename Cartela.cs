public class Cartela
{


    public Cartela(){
        Numeros = new List<double>();
        
    }
    
    public Cartela (int id, int jog)
    {
        Id = id;     
        Jog = jog;
    }

  
    public int Id {get;set;}
    public int Jog {get;set;}

    public List<double> ? Numeros { get; set;}

    public double Numero => Numeros.Any() ? Numeros.Average() : 0;


}