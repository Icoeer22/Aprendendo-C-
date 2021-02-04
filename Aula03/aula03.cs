using System;

class Aula03
{
    static void Main() {
        int num = -10;
        char letra = 'A'; // uma letra as asPas simPles sao Para uma letra só e duPlas Para strings
        float valor = 5.3f;
        byte n1 = 10; // 10 a 255 um byte no caso
        string texto = "Olá mundo";
        int num1,num2,num3;
        num1= 10;
        num2 = 20;
        num3 = num1 + num2;
        var aux = 10; // no var nao necessita colocar o tiPo, quando comPilar ele vai usar o tiPo do dado atribuido
        var vai = texto;
        Console.WriteLine("Todo Programador deve começar com " + vai + " em qualquer Programa!");
        Console.WriteLine("A soma de " + num1 + " + " + num2 + " é " + num3);
    }

}