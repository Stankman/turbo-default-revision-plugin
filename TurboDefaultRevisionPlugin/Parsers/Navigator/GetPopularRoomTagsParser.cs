using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Navigator
{
    public class GetPopularRoomTagsParser : AbstractParser<GetPopularRoomTagsMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new GetPopularRoomTagsMessage();
    }
}
