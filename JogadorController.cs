using Microsoft.AspNetCore.Mvc;

namespace Prova.Controllers;

[ApiController]
[Route("[controller]")]
public class JogadorController : ControllerBase 
{
    public static List<Jogador> ListJogadores = new List<Jogador>();
    
    private static int CountIdJog = 1;

    

    
    
    [HttpGet("JOGA")]
    public  ActionResult<List<Jogador>> GetMostraJog() 
    {        

        if( ListJogadores == null || !ListJogadores.Any())
        {
            return StatusCode(200, "Não existem filmes cadastrados");
        } 
        return Ok(ListJogadores);
    
    }

   [HttpPost]
    public bool AddJog(Jogador jogador)
    {
        ListJogadores.Add(CreateJogador(jogador));
        return true;
    }
    
     
    
    public  Jogador CreateJogador (Jogador jogador)
    {
        Jogador aux = new Jogador();  
        aux.Id = CountIdJog++;
        aux.Nome = jogador.Nome;
        return aux;
    }

    

    
    
    public Jogador getJogadorId( int id)
    {
        foreach(Jogador i in ListJogadores)
        {
            if(i.Id == id)
            {
                return i;
            }
            
        }      

        return null; 
    }
}