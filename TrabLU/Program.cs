namespace App;

public class App
{
    static void Main(string[] args)
    {
        /*
            Utilizando o exemplo que foi dado em sala de aula:
                3x + 2y + 4z = 1
                1x +  y + 2z = 2
                4x + 3y - 2z = 3
        
            Inicializando a matriz dos coeficientes de tamanho 3x3 */
        double[,] matrizA = new double[3,3]
        {
            {3.0, 2.0, 4.0},
            {1.0, 1.0, 2.0},
            {4.0, 3.0, -2.0}
        };

        /* Inicializando a matriz b */
        double[] matrizB = new double[] {1.0, 2.0, 3.0};
        
        /* Criando a matriz x que sera a resposta do sistema, nesse caso, estamos pegando o tamanho(3) que em multiplicacao de matrizes é o numero que vai ficar como resultado da 
            nova matriz  Console.WriteLine(matrizA.GetLength(0)); para verificar.    Em uma multiplicacao de matrizM(3x3) e matrizN(3X1), o ultimo numero da matrizM e o primeiro da 
            MatrizN é que vão decidir de essa multiplicacao sera valida, ja o primeiro numero da matrizM e o segundo da matrizN vai ser o que vai dar a forma da nova matriz, nesse 
            caso, ira ser uma matriz(3X1) */
        double[] matrizX = new double[matrizA.GetLength(0)];

        double[,] matrizL, matrizU;

        DecompLU.DecomposicaoLU(matrizA, out matrizL, out matrizU);
    }
}