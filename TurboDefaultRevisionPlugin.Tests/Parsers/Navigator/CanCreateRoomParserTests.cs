using AutoFixture;
using DotNetty.Buffers;
using System.Text;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;
using TurboDefaultRevisionPlugin.Parsers.Navigator;
using Xunit;

namespace Turbo.Packets.Tests.Parsers.Handshake
{
    public class CanCreateRoomParserTests
    {
        private readonly IFixture _fixture;
        private readonly IByteBuffer _buffer;
        private readonly Encoding _encoding = Encoding.UTF8;
        private readonly IParser _sut;

        public CanCreateRoomParserTests()
        {
            _fixture = new Fixture();
            _buffer = Unpooled.Buffer();
            _sut = new CanCreateRoomParser();
        }

        [Fact]
        private void Parse_WithClientPacket_CanCreateRoomMessage()
        {
            // Arrange
            var packetHeader = _fixture.Create<int>();

            var packet = new ClientPacket(packetHeader, _buffer);

            // Act
            var result = _sut.Parse(packet);

            // Assert
            Assert.IsType<CanCreateRoomMessage>(result);
        }
    }
}
