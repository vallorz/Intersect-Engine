﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Local
// ReSharper disable UnusedAutoPropertyAccessor.Local

namespace Intersect.Server.Classes.Database.PlayerData.Characters
{
    public class Friend
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; private set; }
        public virtual Character Owner { get; private set; }
        public virtual Character Target { get; private set; }

        public Friend()
        {
            
        }

        public Friend(Character me, Character friend)
        {
            Owner = me;
            Target = friend;
        }
    }
}
