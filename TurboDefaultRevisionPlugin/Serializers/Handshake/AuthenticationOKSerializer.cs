using Turbo.Packets.Outgoing;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Serializers;
using TurboDefaultRevisionPlugin.Headers;

namespace TurboDefaultRevisionPlugin.Serializers.Handshake
{
    public class AuthenticationOKSerializer : AbstractSerializer<AuthenticationOKMessage>
    {
        public AuthenticationOKSerializer() : base(Outgoing.AuthenticationOK)
        {
            
        }

        protected override void Serialize(IServerPacket packet, AuthenticationOKMessage message)
        {
            
        }
    }
}
