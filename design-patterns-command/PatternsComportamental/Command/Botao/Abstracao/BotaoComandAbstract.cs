﻿using DesignPatters.PatternsComportamental.Command.Botao.Receptor;

namespace DesignPatters.PatternsComportamental.Command.Botao.Abstracao
{
    public abstract class BotaoComandAbstract
    {
        protected EditorCommand _receptor;
        public BotaoComandAbstract(EditorCommand receptor)
        {
            _receptor = receptor;
        }
         
        public abstract void Executar();
        public abstract void Desfazer();
    }
}
