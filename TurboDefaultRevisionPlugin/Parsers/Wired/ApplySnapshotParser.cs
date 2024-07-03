using Turbo.Core.Packets.Messages;
using Turbo.Packets.Parsers;
using TurboWiredPlugin.Packets.Incoming.Wired;

namespace TurboDefaultRevisionPlugin.Parsers.Wired
{
    public class ApplySnapshotParser : AbstractParser<ApplySnapshotMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new ApplySnapshotMessage
        {
            ItemId = packet.PopInt()
        };
    }
}