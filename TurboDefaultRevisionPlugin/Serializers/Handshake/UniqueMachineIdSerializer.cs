using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Serializers;
using TurboDefaultRevisionPlugin.Headers;

namespace TurboDefaultRevisionPlugin.Serializers.Handshake
{
    public class UniqueMachineIdSerializer : AbstractSerializer<UniqueMachineIdMessage>
    {
        public UniqueMachineIdSerializer() : base(Outgoing.UniqueMachineID)
        {

        }

        protected override void Serialize(IServerPacket packet, UniqueMachineIdMessage message)
        {
            packet.WriteString(message.MachineID);
        }
    }
}
