using System.Collections.Generic;
using Turbo.Packets.Serializers;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Wired;
using Turbo.Core.Game.Wired.Data;

namespace TurboDefaultRevisionPlugin.Serializers.Wired
{
    public class WiredTriggerDataSerializer : AbstractSerializer<WiredTriggerDataMessage>
    {
        public WiredTriggerDataSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, WiredTriggerDataMessage message)
        {
            WiredDataSerializer.Serialize(packet, message);

            List<int> conflicts = new();

            if (message.WiredData is IWiredTriggerData actionData)
            {
                foreach (var conflict in actionData.Conflicts) conflicts.Add(conflict);
            }

            packet.WriteInteger(conflicts.Count);

            foreach (var conflict in conflicts) packet.WriteInteger(conflict);
        }
    }
}