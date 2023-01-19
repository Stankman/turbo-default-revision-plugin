using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Wired;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Wired
{
    public class OpenParser : AbstractParser<OpenWiredMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new OpenWiredMessage
        {
            ItemId = packet.PopInt()
        };
    }
}