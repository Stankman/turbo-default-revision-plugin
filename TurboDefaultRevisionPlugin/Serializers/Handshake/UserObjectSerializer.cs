using System;
using Turbo.Core.Game.Rooms.Object.Constants;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Handshake
{
    public class UserObjectSerializer : AbstractSerializer<UserObjectMessage>
    {
        public UserObjectSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, UserObjectMessage message)
        {
            //TODO: finish this
            packet.WriteInteger(message.Player.Id);
            packet.WriteString(message.Player.Name);
            packet.WriteString(message.Player.PlayerDetails.Figure);
            packet.WriteString(Enum.GetName(typeof(AvatarGender), message.Player.PlayerDetails.Gender));
            packet.WriteString(message.Player.PlayerDetails.Motto);
            packet.WriteString("");//todo: real name here
            packet.WriteString("");//todo: email here
            packet.WriteInteger(0);// respect total
            packet.WriteInteger(0); // respect left
            packet.WriteInteger(0);// pet respect left
            packet.WriteBoolean(false);// stream publishing allowed
            packet.WriteString(message.Player.PlayerDetails.DateCreated.ToString());// todo: make this last acess date
            packet.WriteBoolean(false); // name change allowed
            packet.WriteBoolean(false); // account safetly locked
        }
    }
}
