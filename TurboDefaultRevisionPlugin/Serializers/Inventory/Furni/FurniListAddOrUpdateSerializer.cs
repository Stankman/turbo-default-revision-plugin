using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Inventory.Furni;
using Turbo.Packets.Serializers;
using TurboDefaultRevisionPlugin.Serializers.Inventory.Furni.Types;

namespace TurboDefaultRevisionPlugin.Serializers.Inventory.Furni
{
    public class FurniListAddOrUpdateSerializer : AbstractSerializer<FurniListAddOrUpdateMessage>
    {
        public FurniListAddOrUpdateSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, FurniListAddOrUpdateMessage message)
        {
            FurniDataSerializer.Serialize(packet, message.Furniture);
        }
    }
}
