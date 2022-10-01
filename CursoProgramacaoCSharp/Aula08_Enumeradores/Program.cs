// See https://aka.ms/new-console-template for more information
class Aula08
{
    enum DiaSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};
    static void Main(){
        DiaSemana ds = DiaSemana.Domingo;
        DiaSemana sm = (DiaSemana)3;

        Console.WriteLine(ds);
        Console.WriteLine(sm);

        int days = (int)DiaSemana.Sexta;
        Console.WriteLine(days);
    }
}
