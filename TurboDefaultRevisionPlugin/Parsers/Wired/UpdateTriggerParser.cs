using System.Collections.Generic;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Wired;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Wired
{
    public class UpdateTriggerParser : AbstractParser<UpdateTriggerMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet)
        {
            var itemId = packet.PopInt();

            List<int> integerParams = new();

            for (int i = 0; i < packet.PopInt(); i++) integerParams.Add(packet.PopInt());

            var stringParam = packet.PopString();

            List<int> selectedIds = new();

            for (int i = 0; i < packet.PopInt(); i++) selectedIds.Add(packet.PopInt());

            var selectionCode = packet.PopInt();

            return new UpdateTriggerMessage
            {
                ItemId = itemId,
                IntegerParams = integerParams,
                StringParam = stringParam,
                SelectedItemIds = selectedIds,
                SelectionCode = selectionCode
            };
        }
    }
}