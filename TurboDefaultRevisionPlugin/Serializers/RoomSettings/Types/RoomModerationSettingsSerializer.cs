using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turbo.Core.Game.Rooms;
using Turbo.Core.Packets.Messages;

namespace TurboDefaultRevisionPlugin.Serializers.RoomSettings.Types
{
    public static class RoomModerationSettingsSerializer
    {
        public static void Serialize(IServerPacket packet, IRoomDetails roomDetails)
        {
            packet.WriteInteger((int)roomDetails.MuteType);
            packet.WriteInteger((int)roomDetails.KickType);
            packet.WriteInteger((int)roomDetails.BanType);
        }
    }
}