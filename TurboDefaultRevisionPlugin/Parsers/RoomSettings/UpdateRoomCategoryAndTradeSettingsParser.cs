using Turbo.Core.Game.Rooms.Constants;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.RoomSettings;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.RoomSettings
{
    public class UpdateRoomCategoryAndTradeSettingsParser : AbstractParser<UpdateRoomCategoryAndTradeSettingsMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new UpdateRoomCategoryAndTradeSettingsMessage
        {
            RoomId = packet.PopInt(),
            CategoryId = packet.PopInt(),
            TradeType = (RoomTradeType)packet.PopInt()
        };
    }
}