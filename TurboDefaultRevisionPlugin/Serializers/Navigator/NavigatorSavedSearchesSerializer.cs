using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Navigator
{
    public class NavigatorSavedSearchesSerializer : AbstractSerializer<NavigatorSavedSearchesMessage>
    {
        public NavigatorSavedSearchesSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, NavigatorSavedSearchesMessage message)
        {
            packet.WriteInteger(message.SavedSearches.Count);

            foreach (var savedSearch in message.SavedSearches)
            {
                packet.WriteInteger(savedSearch.Id);
                packet.WriteString(savedSearch.SearchCode ?? string.Empty);
                packet.WriteString(savedSearch.Filter ?? string.Empty);
                packet.WriteString(savedSearch.Localization ?? string.Empty);
            }
        }
    }
}
