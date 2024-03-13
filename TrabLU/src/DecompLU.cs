using System;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

public class DecompLU
{
    public static void DecomposicaoLU()
    {
        /*
            Utilizando o exemplo que foi dado em sala de aula:
                3x + 2y + 4z = 1
                1x +  y + 2z = 2
                4x + 3y - 2z = 3

                espera-se que o resultado seja uma matriz 3x1 com os resultados [-3, 5, 0].
        
            Inicializando a matriz dos coeficientes de tamanho 3x3 */
        var matrizA = Matrix<double>.Build.DenseOfArray(new double[,] {
            { 3, 2, 4 },
            { 1, 1, 2 },
            { 4, 3, -2 }
        });

        /* Inicializando a matriz b */
        var matrizB = Vector<double>.Build.Dense(new double[] { 1, 2, 3 });

        /**/ 
        var matrizX = matrizA.Solve(matrizB);

        Console.WriteLine(matrizX);
    }
}


