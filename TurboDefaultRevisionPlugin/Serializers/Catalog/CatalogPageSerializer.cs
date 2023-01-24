using System.Linq;
using Turbo.Core.Game.Catalog;
using Turbo.Core.Game.Catalog.Constants;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Catalog;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Catalog
{
    public class CatalogPageSerializer : AbstractSerializer<CatalogPageMessage>
    {
        public CatalogPageSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, CatalogPageMessage message)
        {
            packet.WriteInteger(message.PageId);
            packet.WriteString(message.CatalogType);
            packet.WriteString(message.LayoutCode);
            packet.WriteInteger(message.ImageDatas.Count);

            foreach (var imageData in message.ImageDatas) packet.WriteString(imageData);

            packet.WriteInteger(message.TextDatas.Count);

            foreach (var textData in message.TextDatas) packet.WriteString(textData);

            packet.WriteInteger(message.Offers.Count);

            foreach (var offer in message.Offers)
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
                packet.WriteBoolean(offer.IsPet);
                packet.WriteString(offer.PreviewImage);
            }

            packet.WriteInteger(message.OfferId);
            packet.WriteBoolean(message.AcceptSeasonCurrencyAsCredits);
            packet.WriteInteger(message.FrontPageItems.Count);

            foreach (var item in message.FrontPageItems)
            {
                packet.WriteInteger(item.Position);
                packet.WriteString(item.Name);
                packet.WriteString(item.PromoImage);
                packet.WriteInteger((int)item.Type);

                switch (item.Type)
                {
                    case FrontPageItemType.CatalogPage:
                        packet.WriteString(""); // page location
                        break;
                    case FrontPageItemType.Iap:
                        packet.WriteString(""); // product code
                        break;
                    case FrontPageItemType.ProductOffer:
                        packet.WriteInteger(-1); // offer id
                        break;
                }

                packet.WriteInteger(item.Expiration.Second);
            }
        }
    }
}