using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;
using TurboDefaultRevisionPlugin.Serializers.Inventory.Furni.Types;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    public class ObjectsDataUpdateSerializer : AbstractSerializer<ObjectsDataUpdateMessage>
    {
        public ObjectsDataUpdateSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, ObjectsDataUpdateMessage message)
        {
            packet.WriteInteger(message.Objects.Count);

            foreach (var floorObject in message.Objects)
            {
                packet.WriteInteger(floorObject.Id);

                StuffDataSerializer.SerializeStuffData(packet, floorObject);
            }
        }
    }
}
