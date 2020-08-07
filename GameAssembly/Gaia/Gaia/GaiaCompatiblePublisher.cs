/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	public class GaiaCompatiblePublisher // TypeDefIndex: 9165
	{
		// Fields
		public string m_publisherName; // 0x10
		public bool m_installedFoldedOut; // 0x18
		public bool m_compatibleFoldedOut; // 0x19
		private Dictionary<string, GaiaCompatiblePackage> m_packages; // 0x20
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 9166
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<GaiaCompatiblePackage> <>9__5_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000180E4E4B0-0x0000000180E4E510
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal int <GetPackages>b__5_0(GaiaCompatiblePackage a, GaiaCompatiblePackage b); // 0x0000000180E4E370-0x0000000180E4E3B0
		}
	
		// Constructors
		public GaiaCompatiblePublisher(); // 0x0000000180E3BA30-0x0000000180E3BA90
	
		// Methods
		public GaiaCompatiblePackage GetPackage(string packageName); // 0x0000000180E3B710-0x0000000180E3B790
		public List<GaiaCompatiblePackage> GetPackages(); // 0x0000000180E3B790-0x0000000180E3B8D0
		public int InstalledPackages(); // 0x0000000180E3B8D0-0x0000000180E3BA30
		public int CompatiblePackages(); // 0x0000000180E3B5B0-0x0000000180E3B710
		public void AddPackage(GaiaCompatiblePackage package); // 0x0000000180E3B540-0x0000000180E3B5B0
	}
}
