using AutoFixture;
using DotNetty.Buffers;
using System.Text;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Navigator;
using TurboDefaultRevisionPlugin.Parsers.Navigator;
using Xunit;

namespace TurboDefaultRevisionPlugin.Tests.Parsers.Navigator
{
    public class ForwardToSomeRoomParserTests
    {
        private readonly IFixture _fixture;
        private readonly IByteBuffer _buffer;
        private readonly Encoding _encoding = Encoding.UTF8;
        private readonly IParser _sut;

        public ForwardToSomeRoomParserTests()
        {
            _fixture = new Fixture();
            _buffer = Unpooled.Buffer();
            _sut = new ForwardToSomeRoomParser();
        }

        [Fact]
        private void Parse_WithClientPacket_ForwardToSomeRoomMessage()
        {
            // Arrange
            var forwardData = _fixture.Create<string>();

            _buffer.WriteShort(_encoding.GetByteCount(forwardData));
            _buffer.WriteString(forwardData, _encoding);

            var packet = new ClientPacket(_fixture.Create<int>(), _buffer);

            // Act
            var result = (ForwardToSomeRoomMessage)_sut.Parse(packet);

            // Assert
            Assert.Equal(forwardData, result.ForwardData);
        }
    }
}
