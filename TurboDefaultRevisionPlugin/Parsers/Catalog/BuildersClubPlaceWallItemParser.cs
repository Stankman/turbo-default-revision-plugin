using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Catalog
{
    public class BuildersClubPlaceWallItemParser : AbstractParser<BuildersClubPlaceWallItemMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new BuildersClubPlaceWallItemMessage
        {
            PageId = packet.PopInt(),
            OfferId = packet.PopInt(),
            ExtraParam = packet.PopString(),
            Location = packet.PopString()
        };
    }
}