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

        #region Inventory

        #region Furni
        public const int RequestFurniInventory = 3150;
        public const int RequestFurniInventoryWhenNotInRoom = 3500;
        public const int RequestRoomPropertySet = 711;
        #endregion
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

        #region Room

        #region Action
        public const int KickUser = 1320;
        public const int MuteUser = 3485;
        #endregion

        #region Avatar
        public const int Dance = 2080;
        public const int AvatarExpression = 2456;
        public const int ChangeMotto = 2228;
        public const int ChangePosture = 2235;
        public const int CustomizeAvatarWithFurni = 3374;
        public const int DropCarryItem = 2814;
        public const int LookTo = 3301;
        public const int PassCarryItem = 2941;
        public const int PassCarryItemToPet = 2768;
        public const int Sign = 1975;
        #endregion
        #region Chat
        public const int Whisper = 1543;
        #endregion

        #region Engine
        public const int GetFurnitureAliases = 3898;
        public const int GetRoomEntryData = 2300;
        public const int PlaceObject = 1258;
        public const int MoveAvatar = 3320;
        public const int GetItemData = 3964;
        public const int MoveObject = 248;
        public const int MoveWallItem = 168;
        public const int PickupObject = 3456;
        public const int RemoveItem = 3336;
        public const int SetItemData = 3666;
        public const int SetObjectData = 3608;
        public const int UseFurniture = 99;
        public const int UseWallItem = 210;
        #endregion

        #region Session
        public const int OpenFlatConnection = 2312;
        public const int Quit = 105;
        public const int GoToFlat = 685;
        public const int ChangeQueue = 3093;
        #endregion

        #endregion
    }
}
