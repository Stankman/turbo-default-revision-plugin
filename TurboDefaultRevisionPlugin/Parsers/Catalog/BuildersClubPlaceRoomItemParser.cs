using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Catalog
{
    public class BuildersClubPlaceRoomItemParser : AbstractParser<BuildersClubPlaceRoomItemMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new BuildersClubPlaceRoomItemMessage
        {
            PageId = packet.PopInt(),
            OfferId = packet.PopInt(),
            ExtraParam = packet.PopString(),
            X = packet.PopInt(),
            Y = packet.PopInt(),
            Direction = packet.PopInt()
        };
    }
}