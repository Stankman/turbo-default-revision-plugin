using System.Linq;
using Turbo.Core.Game.Catalog;
using Turbo.Core.Game.Catalog.Constants;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Catalog;
using Turbo.Packets.Serializers;
using TurboDefaultRevisionPlugin.Serializers.Catalog.Types;

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

            foreach (var offer in message.Offers) OfferSerializer.Serialize(packet, offer, true);

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