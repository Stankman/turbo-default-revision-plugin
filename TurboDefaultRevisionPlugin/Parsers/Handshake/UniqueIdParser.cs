using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Handshake;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Handshake
{
    public class UniqueIdParser : AbstractParser<UniqueIdMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet)
        {
            return new UniqueIdMessage
            {
                MachineID = packet.PopString(),
                Fingerprint = packet.PopString(),
                FlashVersion = packet.PopString()
            };
        }
    }
}
