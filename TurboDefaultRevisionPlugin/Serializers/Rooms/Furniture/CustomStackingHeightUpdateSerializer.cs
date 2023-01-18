using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Furniture;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Furniture
{
    public class CustomStackingHeightUpdateSerializer : AbstractSerializer<CustomStackingHeightUpdateMessage>
    {
        public CustomStackingHeightUpdateSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, CustomStackingHeightUpdateMessage message)
        {
            packet.WriteInteger(message.ItemId);
            packet.WriteInteger(message.Height);
        }
    }
}