using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Chat;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Chat
{
    public class ChatSerializer : AbstractSerializer<ChatMessage>
    {
        public ChatSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, ChatMessage message)
        {
            packet.WriteInteger(message.ObjectId);
            packet.WriteString(message.Text);
            packet.WriteInteger(message.Gesture);
            packet.WriteInteger(message.StyleId);
            packet.WriteInteger(message.Links.Count);

            foreach (var link in message.Links)
            {
                packet.WriteString(link);
                packet.WriteString(""); // something
                packet.WriteBoolean(false); // something
            }

            packet.WriteInteger(message.AnimationLength);
        }
    }
}