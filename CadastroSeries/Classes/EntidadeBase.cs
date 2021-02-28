using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroSeries
{
    public abstract class EntidadeBase//não pode criar objeto, apenas as classes herdam dela
    {
        public int Id { get; protected set; }
    }
}
