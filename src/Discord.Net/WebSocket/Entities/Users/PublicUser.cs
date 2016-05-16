﻿using Model = Discord.API.User;

namespace Discord.WebSocket
{
    public class PublicUser : User
    {
        internal override DiscordClient Discord { get; }

        internal PublicUser(DiscordClient discord, Model model)
            : base(model)
        {
            Discord = discord;
        }
    }
}