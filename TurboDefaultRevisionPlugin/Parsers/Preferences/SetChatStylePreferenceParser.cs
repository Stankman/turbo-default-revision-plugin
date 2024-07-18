using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Preferences;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Preferences;

public class SetChatStylePreferenceParser : AbstractParser<ChatStylePreferenceMessage>
{
    public override IMessageEvent Parse(IClientPacket packet)
    {
        int styleId = packet.PopInt();
        return new ChatStylePreferenceMessage { StyleId = styleId };
    }
}