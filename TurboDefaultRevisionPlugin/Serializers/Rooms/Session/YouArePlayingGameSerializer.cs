using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Session
{
    public class YouArePlayingGameSerializer : AbstractSerializer<YouArePlayingGameMessage>
    {
        public YouArePlayingGameSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, YouArePlayingGameMessage message)
        {
            packet.WriteBoolean(message.IsPlaying);
        }
    }
}
