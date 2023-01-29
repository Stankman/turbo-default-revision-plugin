using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.RoomSettings;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.RoomSettings
{
    public class FlatControllerRemovedSerializer : AbstractSerializer<FlatControllerRemovedMessage>
    {
        public FlatControllerRemovedSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, FlatControllerRemovedMessage message)
        {
            packet.WriteInteger(message.RoomId);
            packet.WriteInteger(message.PlayerId);
        }
    }
}