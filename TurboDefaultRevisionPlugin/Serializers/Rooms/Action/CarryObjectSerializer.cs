using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Action;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Action
{
    public class CarryObjectSerializer : AbstractSerializer<CarryObjectMessage>
    {
        public CarryObjectSerializer(int header) : base(header) { }
        protected override void Serialize(IServerPacket packet, CarryObjectMessage message)
        {
            packet.WriteInteger(message.UserId);
            packet.WriteInteger(message.ItemType);
        }
    }
}
