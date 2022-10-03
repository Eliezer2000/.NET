// See https://aka.ms/new-console-template for more information
class Aula16
{
    static void Main(){
        int[,] n = new int[3,5];
        int[,] num = new int[2,2]{{10,20},{30,40}};
        /*
        05 10 15 20 25
        30 35 40 45 50
        55 60 65 70 75 
        */


        n[0,0] = 05; n[0,1] = 10; n[0,2] = 15; n[0,3] = 
        20; n[0,4] = 25;
        
        n[1,0] = 30; n[1,1] = 35; n[1,2] = 40; n[1,3] = 45; n[1,4] = 50;

        n[2,0] = 55; n[2,1] = 60; n[2,2] = 65; n[2,3] = 70; n[2,4] = 75;

        Console.WriteLine(n[1,4]);

    }
}
