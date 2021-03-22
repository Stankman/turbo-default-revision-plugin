using System.Collections.Generic;
using Turbo.Core.Game.Rooms;
using Turbo.Core.Game.Rooms.Constants;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Navigator
{
    public class GetGuestRoomResultSerializer : AbstractSerializer<GetGuestRoomResultMessage>
    {
        public GetGuestRoomResultSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, GetGuestRoomResultMessage message)
        {
            IRoomDetails roomDetails = message.Room.RoomDetails;

            packet.WriteBoolean(message.EnterRoom);

            SerializeRoomData(packet, roomDetails);

            packet.WriteBoolean(message.IsRoomForward);
            packet.WriteBoolean(message.IsStaffPick);
            packet.WriteBoolean(message.IsGroupMember);
            packet.WriteBoolean(message.AllInRoomMuted);

            SerializeModerationSettings(packet, roomDetails);

            packet.WriteBoolean(message.CanMute);

            SerializeChatSettings(packet, roomDetails);
        }

        private void SerializeRoomData(IServerPacket packet, IRoomDetails roomDetails)
        {
            packet.WriteInteger(roomDetails.Id);
            packet.WriteString(roomDetails.Name);
            packet.WriteInteger(roomDetails.PlayerId);
            packet.WriteString("test");// room owner name
            packet.WriteInteger((int)roomDetails.State);
            packet.WriteInteger(roomDetails.UsersNow);
            packet.WriteInteger(roomDetails.UsersMax);
            packet.WriteString(roomDetails.Description);
            packet.WriteInteger((int)roomDetails.TradeType);
            packet.WriteInteger(0);// room score
            packet.WriteInteger(0);// room ranking
            packet.WriteInteger(0); // category id
            packet.WriteInteger(0); //tag count, iterate string

            SerializeBitmask(packet, roomDetails);
        }

        private void SerializeModerationSettings(IServerPacket packet, IRoomDetails roomDetails)
        {
            packet.WriteInteger((int)roomDetails.MuteType);
            packet.WriteInteger((int)roomDetails.KickType);
            packet.WriteInteger((int)roomDetails.BanType);
        }

        private void SerializeChatSettings(IServerPacket packet, IRoomDetails roomDetails)
        {
            packet.WriteInteger((int)roomDetails.ChatModeType);
            packet.WriteInteger((int)roomDetails.ChatWeightType);
            packet.WriteInteger((int)roomDetails.ChatSpeedType);
            packet.WriteInteger(roomDetails.ChatDistance);
            packet.WriteInteger((int)roomDetails.ChatProtectionType);
        }

        private void SerializeBitmask(IServerPacket packet, IRoomDetails roomDetails)
        {
            int bitmask = 0;

            bitmask += (int)RoomBitmaskType.ShowOwner; // if public room, no

            if(roomDetails.AllowPets) bitmask += (int)RoomBitmaskType.AllowPets;

            // bitmask += (int)RoomBitmaskType.Thumbnail;
            // bitmask += (int)RoomBitmaskType.GroupData;
            // bitmask += (int)RoomBitmaskType.RoomAd;
            // bitmask += (int)RoomBitmaskType.DisplayRoomAd;

            packet.WriteInteger(bitmask);

            if((bitmask & (int)RoomBitmaskType.Thumbnail) > 0)
            {
                packet.WriteString("");
            }

            if ((bitmask & (int)RoomBitmaskType.GroupData) > 0)
            {
                packet.WriteInteger(0); // group id
                packet.WriteString(""); // group name
                packet.WriteString(""); // group badge
            }

            if ((bitmask & (int)RoomBitmaskType.RoomAd) > 0)
            {
                packet.WriteString(""); // ad name
                packet.WriteString(""); // ad description
                packet.WriteString(""); // ad expires in
            }
        }
    }
}
