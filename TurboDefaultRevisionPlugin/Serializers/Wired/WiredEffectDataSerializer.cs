using System.Collections.Generic;
using Turbo.Packets.Serializers;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Wired;
using Turbo.Core.Game.Wired.Data;

namespace TurboDefaultRevisionPlugin.Serializers.Wired
{
    public class WiredEffectDataSerializer : AbstractSerializer<WiredEffectDataMessage>
    {
        public WiredEffectDataSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, WiredEffectDataMessage message)
        {
            WiredDataSerializer.Serialize(packet, message);

            int delay = 0;
            List<int> conflicts = new();

            if (message.WiredData is IWiredActionData actionData)
            {
                delay = actionData.Delay;

                foreach (var conflict in actionData.Conflicts) conflicts.Add(conflict);
            }

            packet.WriteInteger(delay);
            packet.WriteInteger(conflicts.Count);

            foreach (var conflict in conflicts) packet.WriteInteger(conflict);
        }
    }
}