using System.Linq;
using Turbo.Core.Game.Catalog;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Catalog;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Catalog
{
    public class CatalogIndexerializer : AbstractSerializer<CatalogIndexMessage>
    {
        public CatalogIndexerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, CatalogIndexMessage message)
        {
            SerializePage(packet, message.Root);

            packet.WriteBoolean(message.NewAdditionsAvailable);
            packet.WriteString(message.CatalogType);
        }

        public virtual void SerializePage(IServerPacket packet, ICatalogPage catalogPage)
        {
            packet.WriteBoolean(catalogPage.Visible);
            packet.WriteInteger(catalogPage.Icon);
            packet.WriteInteger(catalogPage.Id);
            packet.WriteString(catalogPage.Name);
            packet.WriteString(catalogPage.Localization);

            packet.WriteInteger(catalogPage.OfferIds.Count);

            foreach (var offerId in catalogPage.OfferIds) packet.WriteInteger(offerId);

            packet.WriteInteger(catalogPage.Children.Count);

            foreach (var child in catalogPage.Children.Values) SerializePage(packet, child);
        }
    }
}