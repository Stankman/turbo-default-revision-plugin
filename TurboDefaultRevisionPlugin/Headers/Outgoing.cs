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

        #region Navigator
        public const int GetGuestRoomResult = 687;
        #endregion

        #region Room

        #region Engine
        public const int FloorHeightMap = 1301;
        public const int HeightMap = 2753;
        public const int HeightMapUpdate = 558;
        public const int RoomEntryInfo = 749;
        public const int FurnitureAliases = 1723;
        public const int Users = 374;
        public const int UserUpdate = 1640;
        public const int UserRemove = 2661;
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
