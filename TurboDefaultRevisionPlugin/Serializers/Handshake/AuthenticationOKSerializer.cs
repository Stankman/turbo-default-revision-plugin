using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Handshake
{
    public class AuthenticationOKSerializer : AbstractSerializer<AuthenticationOKMessage>
    {
        public AuthenticationOKSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, AuthenticationOKMessage message)
        {

        }
    }
}
