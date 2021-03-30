namespace TurboDefaultRevisionPlugin.Headers
{
    public static class Outgoing
    {
        #region Handshake
        public const int AuthenticationOK = 2491;
        public const int Ping = 3928;
        public const int UniqueMachineID = 1488;
        public const int UserObject = 2725;
        #endregion

        #region Inventory
        #region Furni
        public const int FurniListAddOrUpdate = 104;
        public const int FurniListInvalidate = 3151;
        public const int FurniListRemove = 159;
        public const int FurniList = 994;
        public const int PostItPlaced = 1501;
        #endregion
        #endregion

        #region Navigator
        public const int GetGuestRoomResult = 687;
        public const int NavigatorMetaData = 3052;
        public const int NavigatorLiftedRooms = 3104;
        public const int NavigatorSavedSearches = 3984;
        public const int NavigatorEventCategories = 3244;
        #endregion

        #region Room

        #region Action
        public const int AvatarEffect = 1167;
        public const int CarryObject = 1474;
        public const int Dance = 2233;
        public const int Expression = 1631;
        public const int Sleep = 1797;
        public const int UseObject = 1774;
        #endregion

        #region Engine
        public const int FavouriteMembershipUpdate = 3403;
        public const int FloorHeightMap = 1301;
        public const int HeightMap = 2753;
        public const int HeightMapUpdate = 558;
        public const int RoomEntryInfo = 749;
        public const int FurnitureAliases = 1723;
        public const int Users = 374;
        public const int UserUpdate = 1640;
        public const int UserRemove = 2661;
        public const int ObjectAdd = 1534;
        public const int ObjectDataUpdate = 2547;
        public const int ObjectRemove = 2703;
        public const int ObjectsDataUpdate = 1453;
        public const int Objects = 1778;
        public const int ObjectUpdate = 3776;
        public const int ItemAdd = 2187;
        public const int ItemDataUpdate = 2202;
        public const int ItemRemove = 3208;
        public const int Items = 1369;
        public const int ItemUpdate = 2009;
        public const int RoomProperty = 2454;
        public const int RoomVisualizationSettings = 3547;
        public const int SlideObjectBundle = 3207;
        public const int UserChange = 3920;
        #endregion

        #region Permissions
        public const int YouAreOwner = 339;
        public const int YouAreController = 780;
        public const int YouAreNotController = 2392;
        #endregion

        #region Session
        public const int OpenConnection = 758;
        public const int RoomReady = 2031;
        public const int RoomForward = 160;
        public const int CantConnect = 899;
        public const int CloseConnection = 122;
        #endregion
        #endregion
    }
}
