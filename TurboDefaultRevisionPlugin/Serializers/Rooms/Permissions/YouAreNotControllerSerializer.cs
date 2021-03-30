using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Permissions;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Permissions
{
    public class YouAreNotControllerSerializer : AbstractSerializer<YouAreNotControllerMessage>
    {
        public YouAreNotControllerSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, YouAreNotControllerMessage message)
        {
            
        }
    }
}
