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
            foreach (var roomObject in message.RoomObjects)
            {
                packet.WriteInteger(roomObject.RoomObjectHolder.Id);
                packet.WriteString(roomObject.RoomObjectHolder.Name);
                packet.WriteString(roomObject.RoomObjectHolder.Motto);
                packet.WriteString(roomObject.RoomObjectHolder.Figure);

                packet.WriteInteger(roomObject.Id);
                packet.WriteInteger(roomObject.Location.X);
                packet.WriteInteger(roomObject.Location.Y);
                packet.WriteString(roomObject.Location.Z.ToString());
                packet.WriteInteger((int)roomObject.Location.Rotation);

                if (roomObject.Logic is RentableBotLogic)
                {
                    packet.WriteInteger(4);
                    // do the composer for type 4
                }
                else if (roomObject.Logic is BotLogic)
                {
                    packet.WriteInteger(3);
                    // do the composer for type 3
                }
                else if (roomObject.Logic is PetLogic)
                {
                    packet.WriteInteger(2);
                    packet.WriteInteger(0); // todo : subtype
                    // do the composer for type 2
                }
                else if (roomObject.Logic is AvatarLogic)
                {
                    packet.WriteInteger(1);
                    packet.WriteString(roomObject.RoomObjectHolder.Gender);
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
