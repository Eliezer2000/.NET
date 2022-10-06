// See https://aka.ms/new-console-template for more information
class Aula24
{
    static void Main(){
        int divid, divis,quoc,rest;
        divid = 10;
        divis = 5;
        quoc = divide(divid,divis,out rest);

        Console.WriteLine($"{divid} / {divis}: quociente = {quoc} e resto = {rest}");
    }
    static int divide(int dividendo, int divisor, out int resto){
        int quociente;
        quociente = dividendo/divisor;
        resto = dividendo % divisor;
        return quociente;
    }
        

}