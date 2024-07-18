using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Chat;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Chat
{
    public class ShoutParser : AbstractParser<ShoutMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet)
        {
            string text = packet.PopString();
            int styleId = packet.PopInt();

            return new ShoutMessage()
            {
                Text = text,
                StyleId = styleId
            };
        }
    }
}