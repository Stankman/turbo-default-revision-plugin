using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Permissions;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Permissions
{
    public class YouAreOwnerSerializer : AbstractSerializer<YouAreOwnerMessage>
    {
        public YouAreOwnerSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, YouAreOwnerMessage message)
        {
            
        }
    }
}
