using System.Collections.Generic;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Navigator
{
    public class GetGuestRoomResultSerializer : AbstractSerializer<GetGuestRoomResultMessage>
    {
        private const int THUMBNAIL_BITMASK = 1;
        private const int GROUPDATA_BITMASK = 2;
        private const int ROOMAD_BITMASK = 4;
        private const int SHOWOWNER_BITMASK = 8;
        private const int ALLOWPETS_BITMASK = 16;
        private const int DISPLAYROOMENTRYAD_BITMASK = 32;

        public GetGuestRoomResultSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, GetGuestRoomResultMessage message)
        {
            packet.WriteBoolean(message.EnterRoom);
            SerializeRoomData(packet, message);
            packet.WriteBoolean(message.IsRoomForward);
            packet.WriteBoolean(message.IsStaffPick);
            packet.WriteBoolean(message.IsGroupMember);
            packet.WriteBoolean(message.AllInRoomMuted);
            SerializeModerationSettings(packet, message);
            packet.WriteBoolean(message.CanMute);
            SerializeChatSettings(packet, message);
        }

        private void SerializeRoomData(IServerPacket packet, GetGuestRoomResultMessage message)
        {
            packet.WriteInteger(message.Room.Id);
            packet.WriteString(message.Room.RoomDetails.Name);
            packet.WriteInteger(1);// room owner id
            packet.WriteString("test");// room owner name
            packet.WriteInteger(0); // door mode
            packet.WriteInteger(0); // user count
            packet.WriteInteger(10); // max user count
            packet.WriteString(""); // room description
            packet.WriteInteger(0);// room trade mode
            packet.WriteInteger(0);// room score
            packet.WriteInteger(0);// room ranking
            packet.WriteInteger(0); // category id

            var tags = new List<string>();
            packet.WriteInteger(tags.Count);
            foreach(var tag in tags)
            {
                packet.WriteString(tag);
            }

            int bitmask = 8;
            packet.WriteInteger(bitmask);
            /*
            if ((_local_4 & this.THUMBNAIL_BITMASK) > 0)
            {
                this._officialRoomPicRef = k.readString();
            }
            if ((_local_4 & this.GROUPDATA_BITMASK) > 0)
            {
                this._habboGroupId = k.readInteger();
                this._groupName = k.readString();
                this._groupBadgeCode = k.readString();
            }
            if ((_local_4 & this.ROOMAD_BITMASK) > 0)
            {
                this._roomAdName = k.readString();
                this._roomAdDescription = k.readString();
                this._roomAdExpiresInMin = k.readInteger();
            }
            */
        }

        private void SerializeModerationSettings(IServerPacket packet, GetGuestRoomResultMessage message)
        {
            packet.WriteInteger(0);//mute state
            packet.WriteInteger(0);//kick state
            packet.WriteInteger(0);//ban state
        }

        private void SerializeChatSettings(IServerPacket packet, GetGuestRoomResultMessage message)
        {
            packet.WriteInteger(0); // bubble mode
            packet.WriteInteger(0);//bubble type
            packet.WriteInteger(0);// bubble 
            packet.WriteInteger(0); // chat distance
            packet.WriteInteger(0);// anti flood settings
        }
    }
}
