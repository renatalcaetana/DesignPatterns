namespace DesignPatters.PatternsComportamental.Command.Robo.Receptor
{
    //Robo - Representa o Receptor onde iremos definir as funcionalidades dos comandos;
    public class RoboReceptor
    {
        public void Mover(int ParaFrente)
        {
            if (ParaFrente > 0)
                Console.WriteLine("O Robo foi movimentado para frente {0}mm.", ParaFrente);
            else
                Console.WriteLine("O Robo foi movimentado para trás {0}mm.", -ParaFrente);
        }

        public void RotacionarParaEsquerda(double rotacionarParaEsquerda)
        {
            if (rotacionarParaEsquerda > 0)
                Console.WriteLine("O Robo foi rotacionaod para esquerda {0} degrees.", rotacionarParaEsquerda);
            else
                Console.WriteLine("O Robo foi rotacionado para direita {0} degrees.", -rotacionarParaEsquerda);
        }

        public void Escavar(bool paraCima)
        {
            if (paraCima)
                Console.WriteLine("O Robo colheu material do solo.");
            else
                Console.WriteLine("O Robo despejou o material colhido.");
        }
    }
}