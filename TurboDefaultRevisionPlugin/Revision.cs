using System;
using System.Collections.Generic;
using Turbo.Core.Packets.Messages;
using Turbo.Core.Packets.Revisions;
using Turbo.Packets.Outgoing.Handshake;
using TurboDefaultRevisionPlugin.Headers;
using TurboDefaultRevisionPlugin.Parsers.Handshake;
using TurboDefaultRevisionPlugin.Parsers.Navigator;
using TurboDefaultRevisionPlugin.Parsers.Room.Action;
using TurboDefaultRevisionPlugin.Serializers.Handshake;

namespace TurboDefaultRevisionPlugin
{
    public class Revision : IRevision
    {
        public IDictionary<int, IParser> Parsers { get; }

        public IDictionary<Type, ISerializer> Serializers { get; }

        string IRevision.Revision => "PRODUCTION-201611291003-338511768";

        public Revision()
        {
            Parsers = new Dictionary<int, IParser>();
            Serializers = new Dictionary<Type, ISerializer>();
            RegisterParsers();
            RegisterSerializers();
        }

        private void RegisterParsers()
        {
            #region Handshake
            Parsers.Add(Incoming.ClientHello, new ClientHelloParser());
            Parsers.Add(Incoming.SSOTicket, new SSOTicketParser());
            Parsers.Add(Incoming.Pong, new PongParser());
            Parsers.Add(Incoming.InfoRetrieve, new InfoRetrieveParser());
            Parsers.Add(Incoming.UniqueId, new UniqueIdParser());
            Parsers.Add(Incoming.VersionCheck, new VersionCheckParser());
            Parsers.Add(Incoming.CompleteDiffieHandshake, new CompleteDiffieHandshakeParser());
            Parsers.Add(Incoming.Disconnect, new DisconnectParser());
            Parsers.Add(Incoming.InitDiffieHandshake, new InitDiffieHandshakeParser());
            #endregion

            #region Room
            #region Action
            Parsers.Add(Incoming.KickUser, new KickUserParser());
            Parsers.Add(Incoming.MuteUser, new MuteUserParser());
            #endregion
            #endregion

            #region Navigator
            Parsers.Add(Incoming.CanCreateRoom, new CanCreateRoomParser());
            Parsers.Add(Incoming.CreateFlat, new CreateFlatParser());
            Parsers.Add(Incoming.DeleteRoom, new DeleteRoomParser());
            Parsers.Add(Incoming.ForwardToSomeRoom, new ForwardToSomeRoomParser());
            Parsers.Add(Incoming.GetPopularRoomTags, new GetPopularRoomTagsParser());
            Parsers.Add(Incoming.GetUserEventCats, new GetUserEventCatsParser());
            Parsers.Add(Incoming.GetUserFlatCats, new GetUserFlatCatsParser());
            Parsers.Add(Incoming.MyFavouriteRoomsSearch, new MyFavouriteRoomsSearchParser());
            Parsers.Add(Incoming.MyFriendsRoomsSearch, new MyFriendsRoomsSearchParser());
            Parsers.Add(Incoming.MyGuildBasesSearch, new MyGuildBasesSearchParser());
            Parsers.Add(Incoming.MyRoomHistorySearch, new MyRoomHistorySearchParser());
            Parsers.Add(Incoming.MyRoomRightsSearch, new MyRoomRightsSearchParser());
            Parsers.Add(Incoming.MyRoomsSearch, new MyRoomsSearchParser());
            Parsers.Add(Incoming.NavigatorAddCollapsedCategory, new NavigatorAddCollapsedCategoryParser());
            Parsers.Add(Incoming.NavigatorAddSavedSearch, new NavigatorAddSavedSearchParser());
            Parsers.Add(Incoming.NavigatorDeleteSavedSearch, new NavigatorDeleteSavedSearchParser());
            Parsers.Add(Incoming.NavigatorRemoveCollapsedCategory, new NavigatorRemoveCollapsedCategoryParser());
            Parsers.Add(Incoming.NavigatorSetSearchCodeViewMode, new NavigatorSetSearchCodeViewModeParser());
            #endregion
        }

        private void RegisterSerializers()
        {
            Serializers.Add(typeof(AuthenticationOKMessage), new AuthenticationOKSerializer());
            Serializers.Add(typeof(PingMessage), new PingSerializer());
            Serializers.Add(typeof(UniqueMachineIdMessage), new UniqueMachineIdSerializer());
        }
    }
}
