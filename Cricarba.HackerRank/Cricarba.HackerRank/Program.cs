namespace Cricarba.HackerRank
{
    class Program
    {
        /// <summary>
        /// Dados dos valores M=[hombres] y W=[Mujeres] qué representan la cantidad de hombres y mujeres
        /// en cada grupo, demuestre cual es la cantidad de combinaciones posible de a 3 persona por grupo,
        /// teniedo en cuenta que por lo menos debe existir un hombre y una mujer por grupo.
        /// Ejemplo
        /// W=2
        /// M=2
        /// 
        /// Donde M = [M1] y W = [W1, W2, W3]
        /// Tenemos las posibles combinaciones de a 3 personas por grupo          
        /// [W1, W2, M1] - [W1, W3, M1] - [W2, W3, M1]
        /// [W1, W2, M3] No puede ser un grupo porque no tiene Hombres
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int result = DiverseDeputation(1, 3);
        }
        static int DiverseDeputation(int m, int w)
        {
            if (m == 0 || w == 0 || (m + w) <= 3)
                return 0;

            int r = 3;
            int n = m + w;
            int permutacionTotal = Permutation(n, r);

            int permutacionM = m > 3 ? Permutation(m, r) : m == 3 ? 1 : 0;
            int permutacionW = w > 3 ? Permutation(w, r) : w == 3 ? 1 : 0;

            return permutacionTotal - permutacionM - permutacionW;


        }
        static int Permutation(int n, int r)
        {

            int numerador = Factorial(n);
            int resta = Factorial(n - r);
            int divisor = Factorial(r);

            divisor = resta * divisor;
            int resultado = numerador / divisor;
            return resultado;
        }
        static int Factorial(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * Factorial(number - 1);
        }
    }
}
