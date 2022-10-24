// See https://aka.ms/new-console-template for more information

namespace Calc1
{
    class Area
    {
        public static float quad(float bas, float alt)
        {
            if (bas == 0 || alt == 0)
            {
                throw new Exception("Base ou altura não podem ser igual a 0");
            }
            return bas * alt;
        }
    }
}
namespace Calc2
{
    class Area
    {
        public static float quad(float bas, float alt)
        {
            if (bas == 0 || alt == 0)
            {
                throw new Exception("Base ou altura não podem ser igual a 0");
            }
            return bas * alt;
        }
    }
}


class Aula51
{
    static void Main()
    {

        float area = 0;


        try
        {
            area = Calc1.Area.quad(0, 5f);
            Console.WriteLine($"Area do quadrado {area}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"ERRO: {e.Message}");

        }
        finally
        {
            Console.WriteLine("Fim do processo");
        }



    }
}
