using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Catalog
{
    public class RedeemVoucherParser : AbstractParser<RedeemVoucherMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new RedeemVoucherMessage
        {
            Code = packet.PopString()
        };
    }
}