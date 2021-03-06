﻿namespace UB3RB0T
{
    using System;
    using Discord.WebSocket;

    [AttributeUsage(AttributeTargets.Class)]
    public class SpecialUserOnlyAttribute : PermissionsAttribute
    {
        public SpecialUserOnlyAttribute(string failureMessage = null)
        {
            this.FailureMessage = failureMessage;
        }

        public override bool CheckPermissions(IDiscordBotContext context) =>
            BotConfig.Instance.Discord.SpecialUsers.Contains((context.Message.Author as SocketGuildUser)?.Id ?? 0);
    }
}
