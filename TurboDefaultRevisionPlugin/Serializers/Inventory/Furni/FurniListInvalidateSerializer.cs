using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Inventory.Furni;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Inventory.Furni
{
    public class FurniListInvalidateSerializer : AbstractSerializer<FurniListInvalidateMessage>
    {
        public FurniListInvalidateSerializer(int header) : base(header) { }
        protected override void Serialize(IServerPacket packet, FurniListInvalidateMessage message)
        {
            
        }
    }
}
