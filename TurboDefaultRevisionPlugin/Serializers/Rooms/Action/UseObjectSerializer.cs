using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Action;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Action
{
    public class UseObjectSerializer : AbstractSerializer<UseObjectMessage>
    {
        public UseObjectSerializer(int header) : base(header) { }
        protected override void Serialize(IServerPacket packet, UseObjectMessage message)
        {
            packet.WriteInteger(message.ObjectId);
            packet.WriteInteger(message.ItemType);
        }
    }
}
