using Turbo.Core.Packets.Messages;
using TurboWiredPlugin.Packets.Outgoing;

namespace TurboDefaultRevisionPlugin.Serializers.Wired
{
    public static class WiredDataSerializer
    {
        public static void Serialize(IServerPacket packet, WiredDataMessage message)
        {
            packet.WriteBoolean(message.WiredData.SelectionEnabled);
            packet.WriteInteger(message.WiredData.SelectionLimit);
            packet.WriteInteger(message.WiredData.SelectionIds.Count);

            foreach (var furniId in message.WiredData.SelectionIds) packet.WriteInteger(furniId);

            packet.WriteInteger(message.WiredData.SpriteId);
            packet.WriteInteger(message.WiredData.Id);
            packet.WriteString(message.WiredData.StringParameter);
            packet.WriteInteger(message.WiredData.IntParameters.Count);

            foreach (var parameter in message.WiredData.IntParameters) packet.WriteInteger(parameter);

            packet.WriteInteger(0); // selection code
            packet.WriteInteger(message.WiredData.WiredType);
        }
    }
}