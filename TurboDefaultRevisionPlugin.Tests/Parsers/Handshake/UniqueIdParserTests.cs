using AutoFixture;
using DotNetty.Buffers;
using System.Text;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Handshake;
using Turbo.Packets.Parsers;
using TurboDefaultRevisionPlugin.Parsers.Handshake;
using Xunit;

namespace Turbo.Packets.Tests.Parsers.Handshake
{
    public class UniqueIdParserTests
    {
        private readonly IFixture _fixture;
        private readonly IParser _sut;

        public UniqueIdParserTests()
        {
            _fixture = new Fixture();
            _sut = new UniqueIdParser();
        }

        [Fact]
        private void Parse_WithClientPacket_ReturnsUniqueIdMessage()
        {
            // Arrange
            var packetHeader = _fixture.Create<int>();
            var machineId = _fixture.Create<string>();
            var fingerprint = _fixture.Create<string>();
            var flashVersion = _fixture.Create<string>();

            IByteBuffer buffer = Unpooled.Buffer();
            var encoding = Encoding.UTF8;

            buffer.WriteShort(encoding.GetByteCount(machineId));
            buffer.WriteString(machineId, encoding);
            buffer.WriteShort(encoding.GetByteCount(fingerprint));
            buffer.WriteString(fingerprint, encoding);
            buffer.WriteShort(encoding.GetByteCount(flashVersion));
            buffer.WriteString(flashVersion, encoding);

            var packet = new ClientPacket(packetHeader, buffer);

            // Act
            var result = (UniqueIdMessage)_sut.Parse(packet);

            // Assert
            Assert.Equal(machineId, result.MachineID);
            Assert.Equal(fingerprint, result.Fingerprint);
            Assert.Equal(flashVersion, result.FlashVersion);
        }
    }
}
