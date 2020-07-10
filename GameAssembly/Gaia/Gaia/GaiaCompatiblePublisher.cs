/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	public class GaiaCompatiblePublisher // TypeDefIndex: 8999
	{
		// Fields
		public string m_publisherName; // 0x10
		public bool m_installedFoldedOut; // 0x18
		public bool m_compatibleFoldedOut; // 0x19
		private Dictionary<string, GaiaCompatiblePackage> m_packages; // 0x20
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 9000
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<GaiaCompatiblePackage> <>9__5_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001815A7330-0x00000001815A7390
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal int <GetPackages>b__5_0(GaiaCompatiblePackage a, GaiaCompatiblePackage b); // 0x00000001815A72D0-0x00000001815A7310
		}
	
		// Constructors
		public GaiaCompatiblePublisher(); // 0x0000000181584B00-0x0000000181584B60
	
		// Methods
		public GaiaCompatiblePackage GetPackage(string packageName); // 0x00000001815847E0-0x0000000181584860
		public List<GaiaCompatiblePackage> GetPackages(); // 0x0000000181584860-0x00000001815849A0
		public int InstalledPackages(); // 0x00000001815849A0-0x0000000181584B00
		public int CompatiblePackages(); // 0x0000000181584680-0x00000001815847E0
		public void AddPackage(GaiaCompatiblePackage package); // 0x0000000181584610-0x0000000181584680
	}
}
