using System.Collections.Generic;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Action;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Action
{
    public class RemoveRightsParser : AbstractParser<RemoveRightsMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet)
        {
            List<int> playerIds = new();

            var totalPlayerIds = packet.PopInt();

            if (totalPlayerIds > 0) for (int i = 0; i < totalPlayerIds; i++) playerIds.Add(packet.PopInt());

            return new RemoveRightsMessage
            {
                PlayerIds = playerIds
            };
        }
    }
}