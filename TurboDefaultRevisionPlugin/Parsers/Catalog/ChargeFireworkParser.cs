using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Catalog
{
    public class ChargeFireworkParser : AbstractParser<ChargeFireworkMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new ChargeFireworkMessage
        {
            SpriteId = packet.PopInt(),
            Type = packet.PopInt()
        };
    }
}