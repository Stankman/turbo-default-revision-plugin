using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turbo.Core.Game.Catalog.Constants;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Catalog;
using Turbo.Packets.Serializers;
using TurboDefaultRevisionPlugin.Serializers.Catalog.Types;

namespace TurboDefaultRevisionPlugin.Serializers.Catalog
{
    public class PurchaseOkSerializer : AbstractSerializer<PurchaseOkMessage>
    {
        public PurchaseOkSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, PurchaseOkMessage message)
        {
            OfferSerializer.Serialize(packet, message.Offer, false);
        }
    }
}