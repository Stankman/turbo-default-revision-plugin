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
    public class NewNavigatorPreferencesSerializer : AbstractSerializer<NewNavigatorPreferencesMessage>
    {
        public NewNavigatorPreferencesSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, NewNavigatorPreferencesMessage message)
        {
            packet.WriteInteger(message.WindowX);
            packet.WriteInteger(message.WindowY);
            packet.WriteInteger(message.WindowWidth);
            packet.WriteInteger(message.WindowHeight);
            packet.WriteBoolean(message.LeftPaneHidden);
            packet.WriteInteger(message.ResultMode);
        }
    }
}
