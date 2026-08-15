using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFinanceira {
    public interface ITransacao {
        double Valor { get; }
        string Descricao { get; }

        void ExibirDetalhe();

    }

}
