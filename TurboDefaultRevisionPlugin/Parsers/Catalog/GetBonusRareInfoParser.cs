using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Catalog
{
    public class GetBonusRareInfoParser : AbstractParser<GetBonusRareInfoMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new GetBonusRareInfoMessage();
    }
}