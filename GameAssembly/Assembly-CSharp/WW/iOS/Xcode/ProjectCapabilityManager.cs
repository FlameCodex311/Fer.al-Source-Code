/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode
{
	public class ProjectCapabilityManager // TypeDefIndex: 15767
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
		public ProjectCapabilityManager(string pbxProjectPath, string entitlementFilePath, string targetName); // 0x0000000180FEF990-0x0000000180FEFAB0
	
		// Methods
		public void WriteToFile(); // 0x0000000180FEF8C0-0x0000000180FEF990
		public void AddiCloud(bool keyValueStorage, bool iCloudDocument, string[] customContainers); // 0x0000000180FEEB20-0x0000000180FEF280
		public void AddPushNotifications(bool development); // 0x0000000180FEE2C0-0x0000000180FEE4A0
		public void AddGameCenter(); // 0x0000000180FEAE70-0x0000000180FEB1B0
		public void AddWallet(string[] passSubset); // 0x0000000180FEE620-0x0000000180FEE9A0
		public void AddSiri(); // 0x0000000180FEE4A0-0x0000000180FEE620
		public void AddApplePay(string[] merchants); // 0x0000000180FE9250-0x0000000180FE94F0
		public void AddInAppPurchase(); // 0x0000000180FEB8E0-0x0000000180FEB980
		public void AddMaps(MapsOptions options); // 0x0000000180FEBE20-0x0000000180FEE030
		public void AddPersonalVPN(); // 0x0000000180FEE030-0x0000000180FEE2C0
		public void AddBackgroundModes(BackgroundModesOptions options); // 0x0000000180FE9790-0x0000000180FEACE0
		public void AddKeychainSharing(string[] accessGroups); // 0x0000000180FEBB00-0x0000000180FEBE20
		public void AddInterAppAudio(); // 0x0000000180FEB980-0x0000000180FEBB00
		public void AddAssociatedDomains(string[] domains); // 0x0000000180FE94F0-0x0000000180FE9790
		public void AddAppGroups(string[] groups); // 0x0000000180FE8FB0-0x0000000180FE9250
		public void AddHomeKit(); // 0x0000000180FEB760-0x0000000180FEB8E0
		public void AddDataProtection(); // 0x0000000180FEACE0-0x0000000180FEAE70
		public void AddHealthKit(); // 0x0000000180FEB1B0-0x0000000180FEB760
		public void AddWirelessAccessoryConfiguration(); // 0x0000000180FEE9A0-0x0000000180FEEB20
		private PlistDocument GetOrCreateEntitlementDoc(); // 0x0000000180FEF280-0x0000000180FEF380
		private PlistDocument GetOrCreateInfoDoc(); // 0x0000000180FEF380-0x0000000180FEF490
		private PlistElementString GetOrCreateStringElementInArray(PlistElementArray root, string value); // 0x0000000180FEF490-0x0000000180FEF760
		private PlistElementDict GetOrCreateUniqueDictElementInArray(PlistElementArray root); // 0x0000000180FEF760-0x0000000180FEF8C0
	}
}
