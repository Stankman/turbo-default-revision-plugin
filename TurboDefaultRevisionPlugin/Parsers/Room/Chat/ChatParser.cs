using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Chat;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Chat
{
    public class ChatParser : AbstractParser<ChatMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet)
        {
            string text = packet.PopString();
            int styleId = packet.PopInt();
            int chatTrackingId = 0;

            if (packet.RemainingLength() >= sizeof(int))
                chatTrackingId = packet.PopInt();

            return new ChatMessage
            {
                Text = text,
                StyleId = styleId,
                ChatTrackingId = chatTrackingId
            };
        }
    }
}