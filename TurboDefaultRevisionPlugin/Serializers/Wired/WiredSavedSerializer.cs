using System.Collections.Generic;
using Turbo.Packets.Serializers;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Wired;

namespace TurboDefaultRevisionPlugin.Serializers.Wired
{
    public class WiredSavedSerializer : AbstractSerializer<WiredSavedMessage>
    {
        public WiredSavedSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, WiredSavedMessage message)
        {
        }
    }
}