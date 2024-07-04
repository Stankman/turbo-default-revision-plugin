using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Navigator
{
    public class NavigatorEventCategoriesSerializer : AbstractSerializer<NavigatorEventCategoriesMessage>
    {
        public NavigatorEventCategoriesSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, NavigatorEventCategoriesMessage message)
        {
            packet.WriteInteger(message.EventCategories?.Count ?? 0);

            foreach (var category in message.EventCategories)
            {
                packet.WriteInteger(category.Id);
                packet.WriteString(category.Name ?? string.Empty);
                packet.WriteBoolean(category.Enabled);
            }
        }
    }
}
