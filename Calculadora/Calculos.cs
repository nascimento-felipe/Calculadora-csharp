using System;

namespace Calculadora
{
    class Calculos
    {
        // atributos
        private float a;
        private float b;

        // começo do encapsulamento
        public void setA(float a)
        {
            this.a = a;
        }

        public void setB(float b)
        {
            this.b = b;
        }

        public float getA()
        {
            return a;
        }

        public float getB()
        {
            return b;
        }
        // fim do encapsulamento

        // começo dos métodos
        public float Soma()
        {
            return a + b;
        }

        public float Diferenca()
        {
            return a - b;
        }

        public float Multiplicacao()
        {
            return a * b;
        }

        public float Divisao()
        {
            return a / b;
        }
        //fim dos métodos
    }
}
