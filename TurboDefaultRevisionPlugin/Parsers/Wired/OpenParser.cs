using Turbo.Core.Packets.Messages;
using Turbo.Packets.Parsers;
using TurboWiredPlugin.Packets.Incoming.Wired;

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