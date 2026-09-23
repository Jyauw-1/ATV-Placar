namespace Exercicios_praticos_JoaoVitor
{
    public class Vestibular
    {
        // Propriedades da classe
        public double Arrecadacao { get; set; }
        public int QuantidadeFiscais { get; set; }
        public double ValorAlimentacao { get; set; }

        // Método para calcular o valor recebido/lucro da universidade
        public double CalcularLucro()
        {
            // Fórmula: (ARRECADAÇÃO - (FISCAIS * 70) - ALIMENTAÇÃO)
            return Arrecadacao - (QuantidadeFiscais * 70) - ValorAlimentacao;
        }
    }
}