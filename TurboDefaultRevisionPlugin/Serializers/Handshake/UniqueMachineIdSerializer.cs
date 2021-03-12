using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Handshake
{
    class UniqueMachineIdSerializer : AbstractSerializer<UniqueMachineIdMessage>
    {
        public UniqueMachineIdSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, UniqueMachineIdMessage message)
        {
            packet.WriteString(message.MachineID);
        }
    }
}
