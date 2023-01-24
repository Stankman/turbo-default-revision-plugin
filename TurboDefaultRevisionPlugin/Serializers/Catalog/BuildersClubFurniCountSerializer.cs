using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Catalog;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Catalog
{
    public class BuildersClubFurniCountSerializer : AbstractSerializer<BuildersClubFurniCountMessage>
    {
        public BuildersClubFurniCountSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, BuildersClubFurniCountMessage message)
        {
            packet.WriteInteger(message.FurniCount);
        }
    }
}