using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Catalog;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Catalog
{
    public class BonusRareInfoSerializer : AbstractSerializer<BonusRareInfoMessage>
    {
        public BonusRareInfoSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, BonusRareInfoMessage message)
        {
            packet.WriteString(message.ProductType);
            packet.WriteInteger(message.ProductClassId);
            packet.WriteInteger(message.TotalCoinsForBonus);
            packet.WriteInteger(message.CoinsStillRequiredToBuy);

        }
    }
}
