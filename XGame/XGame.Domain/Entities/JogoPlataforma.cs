using System;

namespace XGame.Domain.Entities
{
    class JogoPlataforma
    {
        public Guid Id { get; set; }

        public Jogo Jogo { get; set; }

        public Plataforma Plataforma { get; set; }

        public DateTime DataaLancamento { get; set; }
    }
}
