using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turbo.Core.Game.Catalog;
using Turbo.Core.Game.Catalog.Constants;
using Turbo.Core.Packets.Messages;

namespace TurboDefaultRevisionPlugin.Serializers.Catalog.Types
{
    public class OfferSerializer
    {
        public static void Serialize(IServerPacket packet, ICatalogOffer offer, bool doExtra)
        {
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

            if (doExtra)
            {
                packet.WriteBoolean(offer.IsPet);
                packet.WriteString(offer.PreviewImage);
            }
        }
    }
}