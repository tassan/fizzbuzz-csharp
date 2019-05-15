using System;

namespace fizzbuzz
{
    /*
    
    Regras do Fizzbuzz

    1. Se a posição for multipla de 3: fizz
    2. Se a posiçao for múltipla de 5: buzz
    3. Se a posição for múltipla de 3 e 5: fizzbuzz
    4. Para qualquer outra posição fale o próprio nº.
    
     */


    public class Robot
    {
        public string Fizzbuzz(int numero) => (MultiploDe3(numero) && MultiploDe5(numero)) ? "fizzbuzz" 
            : MultiploDe3(numero) ? "fizz" 
            : MultiploDe5(numero) ? "buzz" 
            : numero.ToString();

        public bool MultiploDe3(int numero) => numero % 3 == 0;

        public bool MultiploDe5(int numero) => numero % 5 == 0;
    }
}
