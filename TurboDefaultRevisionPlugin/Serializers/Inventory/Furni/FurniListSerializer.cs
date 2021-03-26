using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Inventory.Furni;
using Turbo.Packets.Serializers;
using TurboDefaultRevisionPlugin.Serializers.Inventory.Furni.Types;

namespace TurboDefaultRevisionPlugin.Serializers.Inventory.Furni
{
    public class FurniListSerializer : AbstractSerializer<FurniListMessage>
    {
        public FurniListSerializer(int header) : base(header) { }
        protected override void Serialize(IServerPacket packet, FurniListMessage message)
        {
            packet.WriteInteger(message.TotalFragments);
            packet.WriteInteger(message.CurrentFragment);
            packet.WriteInteger(message.Furniture.Count);

            foreach(var furni in message.Furniture)
            {
                FurniDataSerializer.Serialize(packet, furni);
            }
        }
    }
}
