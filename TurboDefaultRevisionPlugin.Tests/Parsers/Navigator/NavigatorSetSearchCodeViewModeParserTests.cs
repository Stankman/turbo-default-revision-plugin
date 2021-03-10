using AutoFixture;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Navigator;
using TurboDefaultRevisionPlugin.Parsers.Navigator;
using Xunit;

namespace TurboDefaultRevisionPlugin.Tests.Parsers.Navigator
{
    public class NavigatorSetSearchCodeViewModeParserTests : AbstractParserTestBase<NavigatorSetSearchCodeViewModeParser, NavigatorSetSearchCodeViewModeMessage>
    {
        public NavigatorSetSearchCodeViewModeParserTests() : base()
        {
        }

        [Fact]
        private void Parse_WithClientPacket_NavigatorSetSearchCodeViewModeMessage()
        {
            // Arrange
            var categoryName = _fixture.Create<string>();
            var viewMode = _fixture.Create<int>();

            WriteString(categoryName);
            WriteInt(viewMode);

            var packet = new ClientPacket(_fixture.Create<int>(), _buffer);

            // Act
            var result = (NavigatorSetSearchCodeViewModeMessage) _sut.Parse(packet);

            // Assert
            Assert.Equal(categoryName, result.CategoryName);
            Assert.Equal(viewMode, result.ViewMode);
        }
    }
}
