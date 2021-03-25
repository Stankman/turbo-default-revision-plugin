using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    public class SlideObjectBundleSerializer : AbstractSerializer<SlideObjectBundleMessage>
    {
        public SlideObjectBundleSerializer(int header) : base(header) { }
        protected override void Serialize(IServerPacket packet, SlideObjectBundleMessage message)
        {
            packet.WriteInteger(message.OldPos.X);
            packet.WriteInteger(message.OldPos.Y);
            packet.WriteInteger(message.NewPos.X);
            packet.WriteInteger(message.NewPos.Y);

            packet.WriteInteger(message.Objects.Count);
            foreach(var obj in message.Objects)
            {
                packet.WriteInteger(obj.Id);
                packet.WriteString(message.OldPos.Z.ToString());
                packet.WriteString(message.NewPos.Z.ToString());
            }
            packet.WriteInteger(message.RollerItemId);

            if(message.AvatarId.HasValue && message.MoveType.HasValue)
            {
                packet.WriteInteger((int)message.MoveType.Value);
                packet.WriteInteger(message.AvatarId.Value);
                packet.WriteString(message.OldPos.Z.ToString());
                packet.WriteString(message.NewPos.Z.ToString());
            }
        }
    }
}
