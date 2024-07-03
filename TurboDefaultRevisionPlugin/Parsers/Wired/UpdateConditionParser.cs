using System.Collections.Generic;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Parsers;
using TurboWiredPlugin.Packets.Incoming.Wired;

namespace TurboDefaultRevisionPlugin.Parsers.Wired
{
    public class UpdateConditionParser : AbstractParser<UpdateConditionMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet)
        {
            var itemId = packet.PopInt();

            var totalInts = packet.PopInt();
            List<int> integerParams = new();

            for (int i = 0; i < totalInts; i++) integerParams.Add(packet.PopInt());

            var stringParam = packet.PopString();

            var totalIds = packet.PopInt();
            List<int> selectedIds = new();

            for (int i = 0; i < totalIds; i++) selectedIds.Add(packet.PopInt());

            var selectionCode = packet.PopInt();

            return new UpdateConditionMessage
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