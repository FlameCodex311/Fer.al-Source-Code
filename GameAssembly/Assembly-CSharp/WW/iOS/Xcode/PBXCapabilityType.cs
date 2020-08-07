/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode
{
	public sealed class PBXCapabilityType // TypeDefIndex: 16130
	{
		// Fields
		public static readonly PBXCapabilityType ApplePay; // 0x00
		public static readonly PBXCapabilityType AppGroups; // 0x08
		public static readonly PBXCapabilityType AssociatedDomains; // 0x10
		public static readonly PBXCapabilityType BackgroundModes; // 0x18
		public static readonly PBXCapabilityType DataProtection; // 0x20
		public static readonly PBXCapabilityType GameCenter; // 0x28
		public static readonly PBXCapabilityType HealthKit; // 0x30
		public static readonly PBXCapabilityType HomeKit; // 0x38
		public static readonly PBXCapabilityType iCloud; // 0x40
		public static readonly PBXCapabilityType InAppPurchase; // 0x48
		public static readonly PBXCapabilityType InterAppAudio; // 0x50
		public static readonly PBXCapabilityType KeychainSharing; // 0x58
		public static readonly PBXCapabilityType Maps; // 0x60
		public static readonly PBXCapabilityType PersonalVPN; // 0x68
		public static readonly PBXCapabilityType PushNotifications; // 0x70
		public static readonly PBXCapabilityType Siri; // 0x78
		public static readonly PBXCapabilityType Wallet; // 0x80
		public static readonly PBXCapabilityType WirelessAccessoryConfiguration; // 0x88
		private readonly string m_ID; // 0x10
		private readonly bool m_RequiresEntitlements; // 0x18
		private readonly string m_Framework; // 0x20
		private readonly bool m_OptionalFramework; // 0x28
	
		// Properties
		public bool optionalFramework { get; } // 0x00000001804C6790-0x00000001804C67A0 
		public string framework { get; } // 0x0000000180374AF0-0x0000000180374B00 
		public string id { get; } // 0x0000000180372440-0x0000000180372450 
		public bool requiresEntitlements { get; } // 0x00000001803F6D30-0x00000001803F6D40 
	
		// Nested types
		public struct TargetCapabilityPair // TypeDefIndex: 16131
		{
			// Fields
			public string targetGuid; // 0x00
			public PBXCapabilityType capability; // 0x08
	
			// Constructors
			public TargetCapabilityPair(string guid, PBXCapabilityType type); // 0x0000000180006CF0-0x0000000180006D00
		}
	
		// Constructors
		private PBXCapabilityType(string _id, bool _requiresEntitlements, string _framework = "" /* Metadata: 0x007BB903 */, bool _optionalFramework = false /* Metadata: 0x007BB907 */); // 0x00000001814B64E0-0x00000001814B6540
		static PBXCapabilityType(); // 0x00000001814B5F70-0x00000001814B64E0
	
		// Methods
		public static PBXCapabilityType StringToPBXCapabilityType(string cap); // 0x00000001814B5870-0x00000001814B5F70
	}
}
