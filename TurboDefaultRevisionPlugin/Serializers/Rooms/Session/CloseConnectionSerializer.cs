using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Session
{
    public class CloseConnectionSerializer : AbstractSerializer<CloseConnectionMessage>
    {
        public CloseConnectionSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, CloseConnectionMessage message)
        {
            
        }
    }
}
