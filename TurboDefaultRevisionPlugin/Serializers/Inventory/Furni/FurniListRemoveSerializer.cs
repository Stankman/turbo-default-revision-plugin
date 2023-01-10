using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Inventory.Furni;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Inventory.Furni
{
    public class FurniListRemoveSerializer : AbstractSerializer<FurniListRemoveMessage>
    {
        public FurniListRemoveSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, FurniListRemoveMessage message)
        {
            packet.WriteInteger(message.ItemId);
        }
    }
}
