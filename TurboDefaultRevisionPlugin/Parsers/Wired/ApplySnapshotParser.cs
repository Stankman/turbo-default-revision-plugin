using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Wired;
using Turbo.Packets.Parsers;

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