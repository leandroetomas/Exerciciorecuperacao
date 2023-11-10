using System;

class Program 
{
  public static void Main (string[] args)
  {  

      Console.WriteLine("Digite o numero de NPCS:");
      int numNPCS= Convert.ToInt32(Console.ReadLine());

    Categorias[] deNPCS =  new Categorias[numNPCS];
     Classes[] deClasses = new Classes[numNPCS];
    Efeitos[] deEfeitos = new Efeitos[numNPCS];

      for(int i  = 0; i < numNPCS; i++){
       Console.WriteLine("NPC"+ (i+1));
       
     string input;
        Console.WriteLine("Escolhe uma Categoria");
         deNPCS[i]  =(Categorias) Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Escolhe uma Classes");
        deClasses[i] =(Classes) Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escolhe um Efeito");
        deEfeitos[i] =(Efeitos) Convert.ToInt32(Console.ReadLine());
        
    }
    for(int i  = 0; i < numNPCS; i++){
      Console.WriteLine($"Categoria de NPC {i}={deNPCS[i]}");
      Console.WriteLine($"Classes de NPC{i}={deClasses[i]}");
      Console.WriteLine($"Efeitos de NPC{i}={deEfeitos[i]}");
      
      

      }
    
 


  
      

    }
    




    }