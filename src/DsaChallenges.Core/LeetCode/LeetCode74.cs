namespace DsaChallenges.Core.LeetCode;

public static class LeetCode74
{
    public static bool SearchMatrix(int[][] matrix, int target)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        int top = 0; //aponta para o primeiro array
        int bot = rows - 1; //aponta para o último array
        int row = 0;
        //lógica de binary search para encontrar a linha onde o target pode estar
        while (top <= bot)
        {
            row = (top + bot) / 2; //pega a linha do meio da matriz
            if (target > matrix[row][cols - 1])
            //se o target for maior que último elemento do  array do meio
            {
                top = row + 1; //movemos o ponteiro superior para o meio +1
            }
            else if (target < matrix[row][0])
            //se o target for menor que o primeiro elemento do array do meio
            {
                bot = row - 1; //movemos o ponteiro inferior para o meio -1
            }
            else
            {
                break; //se o target estiver entre o primeiro e o último elemento do array do meio, saímos do loop
            }
        }
        if (!(top <= bot)) //se o ponteiro superior ultrapassar o inferior, o target não está na matriz
        {
            return false;
        }

        //binary search na linha encontrada
        int l = 0, r = cols - 1;
        while (l <= r)
        {
            int m = (l + r) / 2;
            if (target > matrix[row][m])
            {
                l = m + 1;
            }

            else if (target < matrix[row][m])
            {
                r = m - 1;
            }

            else
            {
                return true;
            }
        }
        return false;
    }
}
