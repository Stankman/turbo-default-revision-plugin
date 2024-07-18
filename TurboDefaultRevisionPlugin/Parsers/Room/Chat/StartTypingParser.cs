using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Chat;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Chat;

public class StartTypingParser : AbstractParser<StartTypingMessage>
{
    public override IMessageEvent Parse(IClientPacket packet)
    {
        return new StartTypingMessage();
    }
}