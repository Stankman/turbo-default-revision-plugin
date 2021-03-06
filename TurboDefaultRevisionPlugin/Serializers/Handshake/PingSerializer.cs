using Turbo.Packets.Headers;
using Turbo.Packets.Outgoing;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Serializers;
using TurboDefaultRevisionPlugin.Headers;

namespace TurboDefaultRevisionPlugin.Serializers.Handshake
{
    public class PingSerializer : AbstractSerializer<PingMessage>
    {
        public PingSerializer() : base(Outgoing.Ping)
        {

        }

        protected override void Serialize(IServerPacket packet, PingMessage message)
        {
            
        }
    }
}
