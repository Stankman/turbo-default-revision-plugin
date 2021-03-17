using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Chat;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Chat
{
    public class WhisperParser : AbstractParser<WhisperMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet)
        {
            string message = packet.PopString();
            string recipient = message.Split(" ")[0];
            string text = message[(recipient.Length + 1)..];
            return new WhisperMessage
            {
                Text = text,
                RecipientName = recipient,
                StyleId = packet.PopInt()
            };
        }
    }
}
