namespace TurboDefaultRevisionPlugin.Headers
{
    public static class Incoming
    {
        #region Handshake
        public const int ClientHello = 4000;
        public const int SSOTicket = 2419;
        public const int Pong = 2596;
        public const int UniqueId = 2490;
        public const int InfoRetrieve = 357;
        public const int VersionCheck = 1053;
        public const int Disconnect = 2445;
        public const int CompleteDiffieHandshake = 773;
        public const int InitDiffieHandshake = 3110;
        #endregion

        #region Room

        #region Action
        public const int KickUser = 1320;
        public const int MuteUser = 3485;
        #endregion

        #region Avatar
        public const int Dance = 2080;
        #endregion
        #region Chat
        public const int Whisper = 1543;
        #endregion

        #region Engine
        public const int GetFurnitureAliases = 3898;
        public const int GetRoomEntryData = 2300;
        public const int PlaceObject = 1258;
        public const int MoveAvatar = 3320;
        #endregion

        #endregion

        #region Session
        public const int OpenFlatConnection = 2312;
        public const int Quit = 105;
        #endregion

        #region Navigator
        public const int CanCreateRoom = 2128;
        public const int CreateFlat = 2752;
        public const int DeleteRoom = 532;
        public const int ForwardToSomeRoom = 1703;
        public const int GetPopularRoomTags = 826;
        public const int GetGuestRoom = 2230;
        public const int GetUserEventCats = 1782;
        public const int GetUserFlatCats = 3027;
        public const int MyFavouriteRoomsSearch = 2578;
        public const int MyFriendsRoomsSearch = 2266;
        public const int MyGuildBasesSearch = 39;
        public const int MyRoomHistorySearch = 2264;
        public const int MyRoomRightsSearch = 272;
        public const int MyRoomsSearch = 2277;
        public const int NavigatorAddCollapsedCategory = 1834;
        public const int NavigatorAddSavedSearch = 2226;
        public const int NavigatorDeleteSavedSearch = 1954;
        public const int NavigatorRemoveCollapsedCategory = 637;
        public const int NavigatorSetSearchCodeViewMode = 1202;
        public const int NewNavigatorInit = 2110;
        public const int NewNavigatorSearch = 249;
        public const int PopularRoomsSearch = 2758;
        public const int RoomsWhereMyFriendsAreSearch = 1786;
        public const int RoomsWithHighestScoreSearch = 2939;
        public const int SetNewNavigatorWindowPreferences = 3159;
        #endregion
    }
}
