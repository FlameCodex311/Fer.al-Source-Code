/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode
{
	public class ProjectCapabilityManager // TypeDefIndex: 16147
	{
		// Fields
		private readonly string m_BuildPath; // 0x10
		private readonly string m_TargetGuid; // 0x18
		private readonly string m_PBXProjectPath; // 0x20
		private readonly string m_EntitlementFilePath; // 0x28
		private PlistDocument m_Entitlements; // 0x30
		private PlistDocument m_InfoPlist; // 0x38
		protected internal PBXProject project; // 0x40
	
		// Constructors
		public ProjectCapabilityManager(string pbxProjectPath, string entitlementFilePath, string targetName); // 0x00000001805D7450-0x00000001805D7570
	
		// Methods
		public void WriteToFile(); // 0x00000001805D7380-0x00000001805D7450
		public void AddiCloud(bool keyValueStorage, bool iCloudDocument, string[] customContainers); // 0x00000001805D6670-0x00000001805D6DB0
		public void AddPushNotifications(bool development); // 0x00000001805D5E40-0x00000001805D6010
		public void AddGameCenter(); // 0x00000001805D2AC0-0x00000001805D2DF0
		public void AddWallet(string[] passSubset); // 0x00000001805D6180-0x00000001805D64F0
		public void AddSiri(); // 0x00000001805D6010-0x00000001805D6180
		public void AddApplePay(string[] merchants); // 0x00000001805D0F10-0x00000001805D11A0
		public void AddInAppPurchase(); // 0x00000001805D3500-0x00000001805D35A0
		public void AddMaps(MapsOptions options); // 0x00000001805D3A20-0x00000001805D5BC0
		public void AddPersonalVPN(); // 0x00000001805D5BC0-0x00000001805D5E40
		public void AddBackgroundModes(BackgroundModesOptions options); // 0x00000001805D1430-0x00000001805D2940
		public void AddKeychainSharing(string[] accessGroups); // 0x00000001805D3710-0x00000001805D3A20
		public void AddInterAppAudio(); // 0x00000001805D35A0-0x00000001805D3710
		public void AddAssociatedDomains(string[] domains); // 0x00000001805D11A0-0x00000001805D1430
		public void AddAppGroups(string[] groups); // 0x00000001805D0C80-0x00000001805D0F10
		public void AddHomeKit(); // 0x00000001805D3390-0x00000001805D3500
		public void AddDataProtection(); // 0x00000001805D2940-0x00000001805D2AC0
		public void AddHealthKit(); // 0x00000001805D2DF0-0x00000001805D3390
		public void AddWirelessAccessoryConfiguration(); // 0x00000001805D64F0-0x00000001805D6670
		private PlistDocument GetOrCreateEntitlementDoc(); // 0x00000001805D6DB0-0x00000001805D6E80
		private PlistDocument GetOrCreateInfoDoc(); // 0x00000001805D6E80-0x00000001805D6F60
		private PlistElementString GetOrCreateStringElementInArray(PlistElementArray root, string value); // 0x00000001805D6F60-0x00000001805D7220
		private PlistElementDict GetOrCreateUniqueDictElementInArray(PlistElementArray root); // 0x00000001805D7220-0x00000001805D7380
	}
}
