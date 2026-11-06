namespace Skyline.DataMiner.Utils.Interfaces.Network
{
	using System;

	/// <summary>
	/// Defines interface settings.
	/// </summary>
	public interface IInterfaceSettings
	{
		/// <summary>
		/// Add a VLAN to the interface. Equivalent to 'switchport trunk allowed vlan add [VLAN ID]' command.
		/// </summary>
		/// <param name="vlan">The VLAN to add.</param>
		/// <returns>The settings object in order to concatenate multiple settings.</returns>
		/// <exception cref="NotSupportedException"><see cref="AddVlan(int)"/> will be thrown if this setting is not supported.</exception>
		IInterfaceSettings AddVlan(int vlan);

		/// <summary>
		/// Add multiple VLANs to the interface. Equivalent to 'switchport trunk allowed vlan add [VLAN ID]' command.
		/// </summary>
		/// <param name="vlans">The VLANs to add.</param>
		/// <returns>The settings object in order to concatenate multiple settings.</returns>
		/// <exception cref="NotSupportedException"><see cref="AddVlan(int[])"/> will be thrown if this setting is not supported.</exception>
		IInterfaceSettings AddVlan(int[] vlans);

		/// <summary>
		/// Push multiple settings at once. No validation is done with this method to see if the set was successful.
		/// </summary>
		/// <exception cref="NotSupportedException">One of the provided settings is not supported.</exception>
		void Push();

		/// <summary>
		/// Remove a VLAN from the interface. Equivalent to 'switchport trunk allowed vlan remove [VLAN ID]' command.
		/// </summary>
		/// <param name="vlan">The VLAN to remove.</param>
		/// <returns>The settings object in order to concatenate multiple settings.</returns>
		/// <exception cref="NotSupportedException"><see cref="RemoveVlan(int)"/> will be thrown if this setting is not supported.</exception>
		IInterfaceSettings RemoveVlan(int vlan);

		/// <summary>
		/// Remove multiple VLANs from the interface. Equivalent to 'switchport trunk allowed vlan remove [VLAN ID]' command.
		/// </summary>
		/// <param name="vlans">The VLANs to remove.</param>
		/// <returns>The settings object in order to concatenate multiple settings.</returns>
		/// <exception cref="NotSupportedException"><see cref="RemoveVlan(int[])"/> will be thrown if this setting is not supported.</exception>
		IInterfaceSettings RemoveVlan(int[] vlans);

		/// <summary>
		/// Sets the administrator state of the interface. Equivalent to 'shutdown' and 'no shutdown' commands.
		/// </summary>
		/// <param name="enabled">Whether the interface should be enabled or not.</param>
		/// <returns>The settings object in order to concatenate multiple settings.</returns>
		/// <exception cref="NotSupportedException"><see cref="SetAdminState(bool)"/> will be thrown if this setting is not supported.</exception>
		IInterfaceSettings SetAdminState(bool enabled);

		/// <summary>
		/// Add this interface to a bridge domain.
		/// </summary>
		/// <param name="bridgeDomain">The bridge domain.</param>
		/// <returns>The settings object in order to concatenate multiple settings.</returns>
		/// <exception cref="NotSupportedException"><see cref="SetBridgeDomain(int)"/> will be thrown if this setting is not supported.</exception>
		IInterfaceSettings SetBridgeDomain(int bridgeDomain);

		/// <summary>
		/// Configure the encapsulation on the interface using IEEE 802.1Q (dot1q).
		/// </summary>
		/// <param name="vlan">The VLAN used for encapsulation.</param>
		/// <returns>The settings object in order to concatenate multiple settings.</returns>
		/// <exception cref="NotSupportedException"><see cref="SetEncapsulation(int)"/> will be thrown if this setting is not supported.</exception>
		IInterfaceSettings SetEncapsulation(int vlan);

		/// <summary>
		/// Configure encapsulation on the interface.
		/// </summary>
		/// <param name="vlan">The VLAN used for encapsulation.</param>
		/// <param name="encapsulationFormat">The encapsulation format to be used.</param>
		/// <returns>The settings object in order to concatenate multiple settings.</returns>
		/// <exception cref="NotSupportedException"><see cref="SetEncapsulation(int, EncapsulationFormats)"/> will be thrown if this setting is not supported.</exception>
		IInterfaceSettings SetEncapsulation(int vlan, EncapsulationFormats encapsulationFormat);

		/// <summary>
		/// Configure the encapsulation on the interface using IEEE 802.1Q (dot1q).
		/// </summary>
		/// <param name="vlan">The VLAN used for encapsulation.</param>
		/// <param name="extVlan">The package with this VLAN will be encapsulated with <paramref name="vlan"/>.</param>
		/// <returns>The settings object in order to concatenate multiple settings.</returns>
		/// <exception cref="NotSupportedException"><see cref="SetEncapsulation(int, int)"/> will be thrown if this setting is not supported.</exception>
		IInterfaceSettings SetEncapsulation(int vlan, int extVlan);

		/// <summary>
		/// Configure encapsulation on the interface for a specific VLAN.
		/// </summary>
		/// <param name="vlan">The VLAN used for encapsulation.</param>
		/// <param name="extVlan">The package with this VLAN will be encapsulated with <paramref name="vlan"/>.</param>
		/// <param name="encapsulationFormat">The encapsulation format to be used.</param>
		/// <returns>The settings object in order to concatenate multiple settings.</returns>
		/// <exception cref="NotSupportedException"><see cref="SetEncapsulation(int, int, EncapsulationFormats)"/> will be thrown if this setting is not supported.</exception>
		IInterfaceSettings SetEncapsulation(int vlan, int extVlan, EncapsulationFormats encapsulationFormat);

		/// <summary>
		/// Set the PVID to the interface. All incoming untagged traffic will be tagged with this VLAN.
		/// </summary>
		/// <param name="pvid">The PVID to set.</param>
		/// <returns>The settings object in order to concatenate multiple settings.</returns>
		/// <exception cref="NotSupportedException"><see cref="SetPvid(int)"/> will be thrown if this setting is not supported.</exception>
		IInterfaceSettings SetPvid(int pvid);

		/// <summary>
		/// Set the VLANs to the interface. Equivalent to 'switchport trunk allowed vlan [VLAN ID]' command.
		/// </summary>
		/// <param name="vlans">The VLANs to add.</param>
		/// <returns>The settings object in order to concatenate multiple settings.</returns>
		/// <exception cref="NotSupportedException"><see cref="SetVlan(int[])"/> will be thrown if this setting is not supported.</exception>
		IInterfaceSettings SetVlan(int[] vlans);

		/// <summary>
		/// Push multiple settings at once. This method will wait until the set is confirmed.
		/// </summary>
		/// <param name="timeout">The maximum time to wait on a response.</param>
		/// <returns><c>true</c> when the VLAN was removed successful; otherwise <c>false</c>.</returns>
		/// <exception cref="NotSupportedException">One of the provided settings is not supported.</exception>
		/// <exception cref="TimeoutException">When the set is not confirmed within the provided timeout time.</exception>
		bool TryPush(TimeSpan timeout);
	}
}