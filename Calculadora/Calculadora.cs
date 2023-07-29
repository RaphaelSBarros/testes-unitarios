namespace Programa
{
    public class Calculadora
    {
        public double Somar(double a, double b) 
        {
            return a + b;
        }
        public double Subtrair(double a, double b)
        {
            return a - b;
        }
        public double Multiplicar(double a, double b)
        {
            return a * b;
        }
        public double Divisao(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Mão é possível dividir por zero");
                return double.NaN;
            }
            return a / b;
        }
    }
}