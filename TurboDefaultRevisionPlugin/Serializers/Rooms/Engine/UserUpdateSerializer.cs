using System;
using System.Text;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;
using Turbo.Rooms.Object.Logic.Avatar;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    public class UserUpdateSerializer : AbstractSerializer<UserUpdateMessage>
    {
        public UserUpdateSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, UserUpdateMessage message)
        {
            packet.WriteInteger(message.RoomObjects.Count);
            foreach (var roomObject in message.RoomObjects)
            {
                packet.WriteInteger(roomObject.Id);

                packet.WriteInteger(roomObject.Location.X);
                packet.WriteInteger(roomObject.Location.Y);
                packet.WriteString(roomObject.Location.Z.ToString());

                packet.WriteInteger((int)roomObject.Location.HeadRotation);// head rotation
                packet.WriteInteger((int)roomObject.Location.Rotation); // body rotation

                MovingAvatarLogic avatarLogic = (MovingAvatarLogic)roomObject.Logic;

                StringBuilder statusString = new StringBuilder("/");
                foreach (var status in avatarLogic.Statuses)
                {
                    statusString
                            .Append(status.Key)
                            .Append(' ')
                            .Append(status.Value)
                            .Append('/');
                }

                packet.WriteString(statusString.ToString());
            }
        }
    }
}
