namespace Exercicios_praticos_JoaoVitor
{
    public class Placar
    {
        public string Verificar(int golsTime1, int golsTime2, string nomeTime1, string nomeTime2)
        {
            if (golsTime1 > golsTime2)
            {
                return "Vitória do " + nomeTime1;
            }
            else if (golsTime2 > golsTime1)
            {
                return "Vitória do " + nomeTime2;
            }
            else
            {
                return "Empate";
            }
        }
    }
}