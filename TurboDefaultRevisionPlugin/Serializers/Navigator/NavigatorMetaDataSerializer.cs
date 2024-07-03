using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;
using TurboDefaultRevisionPlugin.Headers;

namespace TurboDefaultRevisionPlugin.Serializers.Navigator
{
    public class NavigatorMetaDataSerializer : AbstractSerializer<NavigatorMetaDataMessage>
    {
        public NavigatorMetaDataSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, NavigatorMetaDataMessage message)
        {
            if(message.TopLevelContexts.Count == 0)
            {
                packet.WriteInteger(0);
            }
            else
            {
                packet.WriteInteger(message.TopLevelContexts.Count);

                foreach (var topLevelContext in message.TopLevelContexts)
                {
                    packet.WriteString(topLevelContext.SearchCode);

                    if (topLevelContext.SavedSearches != null)
                    {
                        packet.WriteInteger(topLevelContext.SavedSearches.Count);

                        foreach (var savedSearch in topLevelContext.SavedSearches)
                        {
                            packet.WriteInteger(savedSearch.Id);
                            packet.WriteString(savedSearch.SearchCode);
                            packet.WriteString(savedSearch.Filter);
                            packet.WriteString(savedSearch.Localization);
                        }
                    }
                    else
                    {
                        packet.WriteInteger(0);
                    }
                }
            }
        }
    }
}
