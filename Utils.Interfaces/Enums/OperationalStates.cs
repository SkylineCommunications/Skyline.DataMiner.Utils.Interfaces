namespace Skyline.DataMiner.Utils.Interfaces
{
    /// <summary>
    /// Specifies the operational state of the interface.
    /// </summary>
    public enum OperationalStates
    {
        /// <summary>
        /// Specifies that the operational state is up.
        /// </summary>
        Up,

        /// <summary>
        /// Specifies that the operational state is down (as administrator state).
        /// </summary>
        AdminDown,

        /// <summary>
        /// Specifies that the operational state is down.
        /// </summary>
        Down,

        /// <summary>
        /// Specifies that the operational state is testing.
        /// </summary>
        Testing,

        /// <summary>
        /// Specifies that the operational state is unknown.
        /// </summary>
        Unknown,

        /// <summary>
        /// Specifies that the operational state is dormant.
        /// </summary>
        Dormant,

        /// <summary>
        /// Specifies that the operational state is not present.
        /// </summary>
        NotPresent,

        /// <summary>
        /// Specifies that the operational state is lower layer down.
        /// </summary>
        LowerLayerDown,
    }
}