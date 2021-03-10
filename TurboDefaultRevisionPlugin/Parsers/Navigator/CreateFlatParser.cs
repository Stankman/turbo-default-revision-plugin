using Turbo.Core.Game.Navigator.Constants;
using Turbo.Core.Packets.Messages;
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
                    tradeSetting = RoomTradeSetting.TradingRoomOwnerAndRights;
                    break;
                case 2:
                    tradeSetting = RoomTradeSetting.TradingAllowed;
                    break;
                default:
                    tradeSetting = RoomTradeSetting.TradingNotAllowed;
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
