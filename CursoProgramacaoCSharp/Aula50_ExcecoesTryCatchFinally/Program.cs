// See https://aka.ms/new-console-template for more information

class Area{
    public static float quad(float bas, float alt){
        if(bas == 0 || alt == 0){
            throw new Exception("Base ou altura não podem ser igual a 0");
        }
        return bas * alt;
    }
}

class Aula50
{
    static void Main(){

        float area = 0;
        

        try{
            area = Area.quad(0, 5f);
            Console.WriteLine($"Area do quadrado {area}");
        }catch(Exception e){
            Console.WriteLine($"ERRO: {e.Message}");
            
        }finally{
            Console.WriteLine("Fim do processo");
        }
        

        
    }
}
