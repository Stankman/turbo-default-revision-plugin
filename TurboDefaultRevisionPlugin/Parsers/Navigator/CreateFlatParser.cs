using Turbo.Core.Navigator.Enums;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Navigator
{
    public class CreateFlatParser : AbstractParser<CreateFlatMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet)
        {
            var flatName = packet.PopString();
            var flatDescription = packet.PopString();
            var flatModelName = packet.PopString();
            var categoryID = packet.PopInt();
            var maxPlayers = packet.PopInt();
            var tradeType = packet.PopInt();

            RoomTradeSetting tradeSetting;
            switch (tradeType)
            {
                case 1:
                    tradeSetting = RoomTradeSetting.TRADING_ROOM_OWNER_AND_RIGHTS;
                    break;
                case 2:
                    tradeSetting = RoomTradeSetting.TRADING_ALLOWED;
                    break;
                default:
                    tradeSetting = RoomTradeSetting.TRADING_NOT_ALLOWED;
                    break;
            }

            return new CreateFlatMessage
            {
                FlatName = flatName,
                FlatDescription = flatDescription,
                FlatModelName = flatModelName,
                CategoryID = categoryID,
                MaxPlayers = maxPlayers,
                TradeSetting = tradeSetting
            };
        }
    }
}
