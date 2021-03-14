using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Handshake
{
    public class PingSerializer : AbstractSerializer<PingMessage>
    {
        public PingSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, PingMessage message)
        {

        }
    }
}
