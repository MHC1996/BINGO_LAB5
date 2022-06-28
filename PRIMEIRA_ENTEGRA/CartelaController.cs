using Microsoft.AspNetCore.Mvc;


namespace Prova.Controllers;

[ApiController]
[Route("[controller]")]
public class CartelaController : JogadorController {

    public static List<Cartela> ListCartelas = new List<Cartela>();
    
    private static int CountIdCar = 1;

    [HttpGet("car")]
    public List<Cartela> listacartelas()
    {
        return ListCartelas;
    }


    

    [HttpDelete("{id}")]
    public ActionResult<bool> DeleteApostador(int id)
    {
        Jogador aux = null;
        foreach(Jogador i in ListJogadores)
        {
            if( i.Id == id)
            {
                aux = i;
                break;
            }
        }

        if(aux != null)
        {

            verificaCartela(id);
            ListJogadores.Remove(aux);
            return true;
        }
        return NotFound("erro 404");

    }
    public   List<Cartela> verificaCartela(int id)
    {
        Cartela cartela = new Cartela();
        
        Jogador jogador = new Jogador();
        jogador = getJogadorId(id);


        for(int i = 1; i <= CountIdCar; i-- )
        {
            
            if(jogador.Id == cartela.Jog)
            {

            ListCartelas.Remove(cartela);
            
            }
                
        }
        return ListCartelas;
        
    }


    [HttpPost("{id}")]
    public List<Cartela> Addcartela(int id)
    {   
       
        ListCartelas.Add(initcartela(id));
        adicionaCar(id);
        return ListCartelas;      
       
    }

    public List<Jogador>  adicionaCar(int id)
    {
        Jogador aux = new Jogador();
        aux = getJogadorId(id);
        aux.Cartelas.Add(CountIdCar - 1);
       
        return ListJogadores;
           

    }
    

    public Cartela getCartelaId( int id)
    {
        foreach(Cartela i in ListCartelas)
        {
            if(i.Id == id)
            {
                return i;
            }
            
        }      

        return null; 
    }

    public Cartela initcartela(int id) 
    {   
        Cartela cartela = new Cartela();
        cartela.Id = CountIdCar++;
        cartela.Jog = id;
        Random randNum = new Random();  
        for(int i = 1; i <= 9; i++)
        {
        cartela.Numeros.Add(randNum.Next(100));
        } 
               
        return cartela;
        
    }









}

