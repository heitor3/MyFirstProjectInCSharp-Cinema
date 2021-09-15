using Cinema.RepositorioADO;
using Cinema.RepositorioEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Aplicacao
{
    public class CinemaAplicacaoConstrutor
    {
        public static FilmeAplicacao FilmeAplicacaoADO()
        {
            return new FilmeAplicacao(new FilmeRepositorioADO());
        }

        public static FilmeAplicacao FilmeAplicacaoEF()
        {
            return new FilmeAplicacao(new FilmeRepositorioEF());
        }

        public static ClienteAplicacao ClienteAplicacaoEF()
        {
            return new ClienteAplicacao(new ClienteRepositorioEF());
        }

        public static VerificaLogin LoginRepositorioEF()
        {
            return new VerificaLogin(new LoginRepositorioEF());
        }

        public static SessaoAplicacao SessaoRepositorioEF()
        {
            return new SessaoAplicacao(new SessaoRepositorioEF());
        }

        public static IngressoAplicacao IngressoRepositorioEF()
        {
            return new IngressoAplicacao(new IngressoRepositorioEF());
        }

    }
}
