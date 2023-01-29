using System.Collections.Generic;
using System.Threading;
using Turbo.Core.Game.Rooms.Constants;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.RoomSettings;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.RoomSettings
{
    public class SaveRoomSettingsParser : AbstractParser<SaveRoomSettingsMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet)
        {
            var roomId = packet.PopInt();
            var name = packet.PopString();
            var description = packet.PopString();
            var state = (RoomStateType)packet.PopInt();
            var password = packet.PopString();
            var usersMax = packet.PopInt();
            var categoryId = packet.PopInt();
            var tags = new List<string>();
            var totalTags = packet.PopInt();

            if (totalTags > 0) for (int i = 0; i < totalTags; i++) tags.Add(packet.PopString());

            var tradeMode = (RoomTradeType)packet.PopInt();
            var allowPets = packet.PopBoolean();
            var allowPetsEat = packet.PopBoolean();
            var blockingDisabled = packet.PopBoolean();
            var hideWalls = packet.PopBoolean();
            var wallThickness = (RoomThicknessType)packet.PopInt();
            var floorThickness = (RoomThicknessType)packet.PopInt();
            var whoCanMute = (RoomMuteType)packet.PopInt();
            var whoCanKick = (RoomKickType)packet.PopInt();
            var whoCanBan = (RoomBanType)packet.PopInt();
            var chatMode = (RoomChatModeType)packet.PopInt();
            var chatWeight = (RoomChatWeightType)packet.PopInt();
            var chatSpeed = (RoomChatSpeedType)packet.PopInt();
            var chatDistance = packet.PopInt();
            var chatProtection = (RoomChatProtectionType)packet.PopInt();
            var allowNavigatorDynamicCategories = false;

            if (packet.RemainingLength() > 0)
            {
                allowNavigatorDynamicCategories = packet.PopBoolean();
            }

            return new SaveRoomSettingsMessage
            {
                RoomId = roomId,
                Name = name,
                Description = description,
                State = state,
                Password = password,
                UsersMax = usersMax,
                CategoryId = categoryId,
                Tags = tags,
                TradeType = tradeMode,
                AllowPets = allowPets,
                AllowPetsEat = allowPetsEat,
                BlockingDisabled = blockingDisabled,
                HideWalls = hideWalls,
                WallThickness = wallThickness,
                FloorThickness = floorThickness,
                MuteType = whoCanMute,
                KickType = whoCanKick,
                BanType = whoCanBan,
                ChatModeType = chatMode,
                ChatWeightType = chatWeight,
                ChatSpeed = chatSpeed,
                ChatDistance = chatDistance,
                ChatProtectionType = chatProtection,
                AllowNavigatorDynamicCategories = allowNavigatorDynamicCategories
            };
        }
    }
}