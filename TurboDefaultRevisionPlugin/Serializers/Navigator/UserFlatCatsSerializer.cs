using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Navigator
{
    public class UserFlatCatsSerializer : AbstractSerializer<UserFlatCatsMessage>
    {
        public UserFlatCatsSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, UserFlatCatsMessage message)
        {
            if (message.Categories.Count == 0)
            {
                packet.WriteInteger(0);
            }
            else
            {
                packet.WriteInteger(message.Categories.Count);

                foreach (var category in message.Categories)
                {
                    packet.WriteInteger(category.Id);
                    packet.WriteString(category.Name);
                    packet.WriteBoolean(category.Visible);
                    packet.WriteBoolean(category.Automatic);
                    packet.WriteString(category.AutomaticCategoryKey);
                    packet.WriteString(category.GlobalCategoryKey);
                    packet.WriteBoolean(category.StaffOnly);
                }
            }
        }
    }
}
