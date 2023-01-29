using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turbo.Core.Game.Rooms;
using Turbo.Core.Packets.Messages;

namespace TurboDefaultRevisionPlugin.Serializers.RoomSettings.Types
{
    public static class RoomChatSettingsSerializer
    {
        public static void Serialize(IServerPacket packet, IRoomDetails roomDetails)
        {
            packet.WriteInteger((int)roomDetails.ChatModeType);
            packet.WriteInteger((int)roomDetails.ChatWeightType);
            packet.WriteInteger((int)roomDetails.ChatSpeedType);
            packet.WriteInteger(roomDetails.ChatDistance);
            packet.WriteInteger((int)roomDetails.ChatProtectionType);
        }
    }
}