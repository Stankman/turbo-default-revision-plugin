using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turbo.Core.Game.Catalog.Constants;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Catalog;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Catalog
{
    public class PurchaseOkSerializer : AbstractSerializer<PurchaseOkMessage>
    {
        public PurchaseOkSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, PurchaseOkMessage message)
        {
            var offer = message.Offer;

            packet.WriteInteger(offer.Id);
            packet.WriteString(offer.LocalizationId);
            packet.WriteBoolean(false); //rent
            packet.WriteInteger(offer.CostCredits);
            packet.WriteInteger(offer.CostCurrency);
            packet.WriteInteger(offer.CurrencyType ?? -1);
            packet.WriteBoolean(offer.CanGift);
            packet.WriteInteger(offer.Products.Count);

            foreach (var product in offer.Products)
            {
                packet.WriteString(product.ProductType);

                if (product.ProductType.Equals(ProductTypeEnum.Badge))
                {
                    packet.WriteString(product.ExtraParam);
                }
                else
                {
                    packet.WriteInteger(product.SpriteId);
                    packet.WriteString(product.ExtraParam);
                    packet.WriteInteger(product.Quantity);

                    var isUnique = product.UniqueSize > 0;

                    packet.WriteBoolean(isUnique);

                    if (isUnique)
                    {
                        packet.WriteInteger(product.UniqueSize);
                        packet.WriteInteger(product.UniqueRemaining);
                    }
                }
            }

            packet.WriteInteger(offer.ClubLevel);
            packet.WriteBoolean(offer.CanBundle);
        }
    }
}