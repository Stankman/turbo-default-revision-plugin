using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Catalog;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Catalog
{
    public class BuildersClubSubscriptionStatusSerializer : AbstractSerializer<BuildersClubSubscriptionStatusMessage>
    {
        public BuildersClubSubscriptionStatusSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, BuildersClubSubscriptionStatusMessage message)
        {
            packet.WriteInteger(message.SecondsLeft);
            packet.WriteInteger(message.FurniLimit);
            packet.WriteInteger(message.MaxFurniLimit);

            if (message.SecondsLeftWithGrace != null) packet.WriteInteger(message.SecondsLeftWithGrace ?? 0);
        }
    }
}