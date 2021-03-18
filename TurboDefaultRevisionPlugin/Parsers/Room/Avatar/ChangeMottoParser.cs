using System;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Avatar;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Avatar
{
    public class ChangeMottoParser : AbstractParser<ChangeMottoMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new ChangeMottoMessage { Motto = packet.PopString() };
    }
}
