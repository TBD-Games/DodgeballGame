using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DodgeballGame.Roles;

namespace DodgeballGame
{
    public interface IDodgeballPlayer
    {
        IRole Role { get; }

        IPosition Position { get; set; }
        bool InOutStatus { get; set; }
    }

    public class DodgeballPlayer : IDodgeballPlayer
    {
        public IRole Role { get; protected internal set; }

        public IPosition Position { get; set; }
        public bool InOutStatus { get; set; }

        public DodgeballPlayer(IRole role)
        {
            Role = role;
        }
    }
}
