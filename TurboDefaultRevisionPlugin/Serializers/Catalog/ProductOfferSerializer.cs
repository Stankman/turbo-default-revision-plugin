using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Catalog;
using Turbo.Packets.Serializers;
using TurboDefaultRevisionPlugin.Serializers.Catalog.Types;

namespace TurboDefaultRevisionPlugin.Serializers.Catalog
{
    public class ProductOfferSerializer : AbstractSerializer<ProductOfferMessage>
    {
        public ProductOfferSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, ProductOfferMessage message)
        {
            OfferSerializer.Serialize(packet, message.Offer, true);
        }
    }
}