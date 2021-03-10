using AutoFixture;
using Turbo.Core.Game.Navigator.Constants;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Navigator;
using TurboDefaultRevisionPlugin.Parsers.Navigator;
using Xunit;

namespace TurboDefaultRevisionPlugin.Tests.Parsers.Navigator
{
    public class SetNewNavigatorWindowPreferencesParserTests : AbstractParserTestBase<SetNewNavigatorWindowPreferencesParser, SetNewNavigatorWindowPreferencesMessage>
    {
        public SetNewNavigatorWindowPreferencesParserTests() : base()
        {
        }

        [Theory]
        [InlineData(0, NavigatorResultsMode.ROWS)]
        [InlineData(1, NavigatorResultsMode.TILES)]
        [InlineData(2, NavigatorResultsMode.ROWS)]
        private void Parse_WithClientPacket_SetNewNavigatorWindowPreferencesMessage(int resultsMode, NavigatorResultsMode expectedMode)
        {
            // Arrange
            var x = _fixture.Create<int>();
            var y = _fixture.Create<int>();
            var width = _fixture.Create<int>();
            var height = _fixture.Create<int>();
            var openSavedSearches = _fixture.Create<bool>();

            WriteInt(x);
            WriteInt(y);
            WriteInt(width);
            WriteInt(height);
            WriteBool(openSavedSearches);
            WriteInt(resultsMode);

            var packet = new ClientPacket(_fixture.Create<int>(), _buffer);

            // Act
            var result = (SetNewNavigatorWindowPreferencesMessage)_sut.Parse(packet);

            // Assert
            Assert.Equal(x, result.X);
            Assert.Equal(y, result.Y);
            Assert.Equal(width, result.Width);
            Assert.Equal(height, result.Height);
            Assert.Equal(openSavedSearches, result.OpenSavedSearches);
            Assert.Equal(expectedMode, result.ResultsMode);
        }
    }
}
