class DecompLU
{

    /* Funcao principal que servira para fazer a decomposicao LU*/
    public static void DecomposicaoLU(double[,] matrizA, out double[,] matrizL, out double[,] matrizU)
    {
        /* Este metodo esta explicado no Program.cs, basicamente esta pegando o numero que ira formar a nova matriz L(matrizLower) e U(Matriz Upper) */
        int tamanho = matrizA.GetLength(0);
        matrizL = new double[tamanho, tamanho];
        matrizU = new double[tamanho, tamanho];

        /* Loop para inicializar a matriz L com a sua diaggonal principal com os valores 1 */
        for (int i = 0; i < tamanho; i++){
           matrizL[i,i] = 1.0;
        }
    }

    /* Funcao que ira resolver os sistemas L . y = b e U . x = y */
    public void ResolverSistemas()
    {
       
    }

    /* Funcao que ira ser responsavel pela troca dos valores das novas linhas a partir do calculo pelo ML */
    private void NovaLinha()
    {
       
    }

    /* Funcao que ira ser responsavel por achar o novo pivo */
    private void ProcurarPivo()
    {
      
    }
}


