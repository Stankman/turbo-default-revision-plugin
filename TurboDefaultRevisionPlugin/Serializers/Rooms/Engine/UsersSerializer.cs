using System;
using Turbo.Core.Game.Rooms.Object;
using Turbo.Core.Game.Rooms.Object.Constants;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;
using Turbo.Rooms.Object.Logic.Avatar;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    public class UsersSerializer : AbstractSerializer<UsersMessage>
    {
        public UsersSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, UsersMessage message)
        {
            packet.WriteInteger(message.RoomObjects.Count);

            foreach (var avatarObject in message.RoomObjects)
            {
                packet.WriteInteger(avatarObject.RoomObjectHolder.Id);
                packet.WriteString(avatarObject.RoomObjectHolder.Name);
                packet.WriteString(avatarObject.RoomObjectHolder.Motto);
                packet.WriteString(avatarObject.RoomObjectHolder.Figure);

                packet.WriteInteger(avatarObject.Id);
                packet.WriteInteger(avatarObject.Location.X);
                packet.WriteInteger(avatarObject.Location.Y);
                packet.WriteString(avatarObject.Location.Z.ToString());
                packet.WriteInteger((int)avatarObject.Location.Rotation);

                if (avatarObject.Logic is RentableBotLogic)
                {
                    packet.WriteInteger(4);
                    // do the composer for type 4
                }
                else if (avatarObject.Logic is BotLogic)
                {
                    packet.WriteInteger(3);
                    // do the composer for type 3
                }
                else if (avatarObject.Logic is PetLogic)
                {
                    packet.WriteInteger(2);
                    packet.WriteInteger(0); // todo : subtype
                    // do the composer for type 2
                }
                else if (avatarObject.Logic is AvatarLogic)
                {
                    packet.WriteInteger(1);
                    packet.WriteString(Enum.GetName(typeof(AvatarGender), avatarObject.RoomObjectHolder.Gender));
                    packet.WriteInteger(0);// todo: group id
                    packet.WriteInteger(0); // todo: group status
                    packet.WriteString("");// todo: group name
                    packet.WriteString(""); // swim figure
                    packet.WriteInteger(0);// todo : activity points
                    packet.WriteBoolean(false);// todo : is moderator
                }
            }
        }
    }
}
