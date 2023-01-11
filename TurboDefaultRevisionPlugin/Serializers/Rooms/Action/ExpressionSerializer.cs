using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Action;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Action
{
    public class ExpressionSerializer : AbstractSerializer<ExpressionMessage>
    {
        public ExpressionSerializer(int header) : base(header) { }
        protected override void Serialize(IServerPacket packet, ExpressionMessage message)
        {
            packet.WriteInteger(message.ObjectId);
            packet.WriteInteger(message.ExpressionType);
        }
    }
}
