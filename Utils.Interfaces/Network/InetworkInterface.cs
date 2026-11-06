namespace Skyline.DataMiner.Utils.Interfaces.Network
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines a Network Interface.
    /// </summary>
    public interface INetworkInterface
    {
        /// <summary>
        /// Gets the key of the interface.
        /// </summary>
        string Key { get; }

        /// <summary>
        /// Gets the name of the interface.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets or sets the Port VLAN ID configured on the interface.
        /// </summary>
        int PVID { get; set; }

        /// <summary>
        /// Gets the VLANs configured on the interface.
        /// </summary>
        IEnumerable<int> VLANs { get; }

        /// <summary>
        /// Gets the interface settings. The settings can be adjusted by calling different methods on it (e.g. 'AddVlan').
        /// Only after using the 'Push' or 'TryPush' command the settings are applied to the device.
        /// </summary>
        IInterfaceSettings Settings { get; }

        /// <summary>
        /// Add a VLAN to the interface. No validation is done with this method to see if the set was successful.
        /// </summary>
        /// <param name="vlan">The VLAN to add to the interface.</param>
        void AddVlan(int vlan);

        /// <summary>
        /// Add a VLAN to the interface. This method will wait until the set is confirmed.
        /// </summary>
        /// <param name="vlan">The VLAN to add to the interface.</param>
        /// <param name="timeout">The maximum time to wait on a response.</param>
        /// <returns><c>true</c> when the VLAN was added successful; otherwise <c>false</c>.</returns>
        /// <exception cref="TimeoutException">When the set is not confirmed within the provided timeout time.</exception>
        bool TryAddVlan(int vlan, TimeSpan timeout);

        /// <summary>
        /// Remove a VLAN from the interface. No validation is done with this method to see if the set was successful.
        /// </summary>
        /// <param name="vlan">The VLAN to remove from the interface.</param>
        void RemoveVlan(int vlan);

        /// <summary>
        /// Remove a VLAN from the interface. This method will wait until the set is confirmed.
        /// </summary>
        /// <param name="vlan">The VLAN to remove from the interface.</param>
        /// <param name="timeout">The maximum time to wait on a response.</param>
        /// <returns><c>true</c> when the VLAN was removed successful; otherwise <c>false</c>.</returns>
        /// <exception cref="TimeoutException">When the set is not confirmed within the provided timeout time.</exception>
        bool TryRemoveVlan(int vlan, TimeSpan timeout);

        /// <summary>
        /// Gets or sets the administrator status of the interface.
        /// </summary>
        AdminSates AdminStatus { get; set; }

        /// <summary>
        /// Gets the operational status of the interface.
        /// </summary>
        OperationalStates OperationalStatus { get; }
    }
}