using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Avatar;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Avatar
{
    public class ChangePostureParser : AbstractParser<ChangePostureMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new ChangePostureMessage { Posture = packet.PopInt() };
    }
}
