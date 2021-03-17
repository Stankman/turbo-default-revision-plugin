using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;
using TurboDefaultRevisionPlugin.Headers;

namespace TurboDefaultRevisionPlugin.Serializers.Navigator
{
    public class NavigatorMetaDataSerializer : AbstractSerializer<NavigatorMetaDataMessage>
    {
        public NavigatorMetaDataSerializer() : base(Outgoing.NavigatorMetaData)
        {

        }

        protected override void Serialize(IServerPacket packet, NavigatorMetaDataMessage message)
        {
            packet.WriteInteger(message.TopLevelContexts.Count);

            message.TopLevelContexts.ForEach(topLevelContext =>
            {
                packet.WriteString(topLevelContext.SearchCode);
                packet.WriteInteger(topLevelContext.SavedSearches?.Count ?? 0);

                topLevelContext.SavedSearches?.ForEach(savedSearch =>
                {
                    packet.WriteInteger(savedSearch.Id);
                    packet.WriteString(savedSearch.SearchCode);
                    packet.WriteString(savedSearch.Filter);
                    packet.WriteString(savedSearch.Localization);
                });
            });
        }
    }
}
