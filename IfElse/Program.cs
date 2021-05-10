using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
           // condições e Declarações de if
           /* 
           Menos de: a < b
            Menos ou igual a: a <= b
            Maior que: a > b
            Maior ou igual a: a >= b
            Igual a == b
            Não igual a: a != b
           */
        

            // declaração do if

            // if(condição) { bloco de codigo executado se o if for true}
       
            if (20 > 18) {
                Console.WriteLine("20 é maior que 18");
            }

            int x = 20;
            int y = 18;
            if (x > y) {
                Console.WriteLine("X é maior que y");
            } //  No exemplo acima usamos duas variáveis, x e y,para testar se x é maior que y (usando o operador). Como x é 20, e y é 18, e sabemos que 20 é maior que 18, imprimimos para a tela que "x é maior que y".>


        }
    }
}
