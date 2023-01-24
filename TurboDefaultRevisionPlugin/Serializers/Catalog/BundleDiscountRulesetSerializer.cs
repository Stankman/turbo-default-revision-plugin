using System.Linq;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Catalog;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Catalog
{
    public class BundleDiscountRulesetSerializer : AbstractSerializer<BundleDiscountRulesetMessage>
    {
        public BundleDiscountRulesetSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, BundleDiscountRulesetMessage message)
        {
            packet.WriteInteger(message.MaxPurchaseSize);
            packet.WriteInteger(message.BundleSize);
            packet.WriteInteger(message.BundleDiscountSize);
            packet.WriteInteger(message.BonusThreshold);

            packet.WriteInteger(message.AdditionalBonusDiscountThresholdQuantities.Length);

            foreach (var quantity in message.AdditionalBonusDiscountThresholdQuantities) packet.WriteInteger(quantity);
        }
    }
}
