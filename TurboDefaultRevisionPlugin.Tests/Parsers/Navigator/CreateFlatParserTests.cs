using AutoFixture;
using DotNetty.Buffers;
using System.Text;
using Turbo.Core.Navigator.Enums;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;
using TurboDefaultRevisionPlugin.Parsers.Navigator;
using Xunit;

namespace TurboDefaultRevisionPlugin.Tests.Parsers.Navigator
{
    public class CreateFlatParserTests
    {
        private readonly IFixture _fixture;
        private readonly IByteBuffer _buffer;
        private readonly Encoding _encoding = Encoding.UTF8;
        private readonly IParser _sut;

        public CreateFlatParserTests()
        {
            _fixture = new Fixture();
            _buffer = Unpooled.Buffer();
            _sut = new CreateFlatParser();
        }

        [Theory]
        [InlineData(0, RoomTradeSetting.TRADING_NOT_ALLOWED)]
        [InlineData(1, RoomTradeSetting.TRADING_ROOM_OWNER_AND_RIGHTS)]
        [InlineData(2, RoomTradeSetting.TRADING_ALLOWED)]
        [InlineData(3, RoomTradeSetting.TRADING_NOT_ALLOWED)]
        private void Parse_WithClientPacket_CreateFlatMessage(int tradeType, RoomTradeSetting expectedSetting)
        {
            // Arrange
            var flatName = _fixture.Create<string>();
            var flatDescription = _fixture.Create<string>();
            var flatModelName = _fixture.Create<string>();
            var categoryID = _fixture.Create<int>();
            var maxPlayers = _fixture.Create<int>();

            _buffer.WriteShort(_encoding.GetByteCount(flatName));
            _buffer.WriteString(flatName, _encoding);
            _buffer.WriteShort(_encoding.GetByteCount(flatDescription));
            _buffer.WriteString(flatDescription, _encoding);
            _buffer.WriteShort(_encoding.GetByteCount(flatModelName));
            _buffer.WriteString(flatModelName, _encoding);
            _buffer.WriteInt(categoryID);
            _buffer.WriteInt(maxPlayers);
            _buffer.WriteInt(tradeType);

            var packet = new ClientPacket(_fixture.Create<int>(), _buffer);

            // Act
            var result = (CreateFlatMessage)_sut.Parse(packet);

            // Assert
            Assert.Equal(flatName, result.FlatName);
            Assert.Equal(flatDescription, result.FlatDescription);
            Assert.Equal(flatModelName, result.FlatModelName);
            Assert.Equal(categoryID, result.CategoryID);
            Assert.Equal(maxPlayers, result.MaxPlayers);
            Assert.Equal(expectedSetting, result.TradeSetting);
        }
    }
}
