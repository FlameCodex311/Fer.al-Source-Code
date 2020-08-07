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
	public class GaiaExtensionManager // TypeDefIndex: 9167
	{
		// Fields
		private Dictionary<string, GaiaCompatiblePublisher> m_extensions; // 0x10
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 9168
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<GaiaCompatiblePublisher> <>9__3_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000180E4E510-0x0000000180E4E570
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal int <GetPublishers>b__3_0(GaiaCompatiblePublisher a, GaiaCompatiblePublisher b); // 0x0000000180E4E370-0x0000000180E4E3B0
		}
	
		// Constructors
		public GaiaExtensionManager(); // 0x0000000180E3E860-0x0000000180E3E8C0
	
		// Methods
		public void ScanForExtensions(); // 0x0000000180E3DC60-0x0000000180E3E860
		public int GetInstalledExtensionCount(); // 0x0000000180E3D730-0x0000000180E3D890
		public List<GaiaCompatiblePublisher> GetPublishers(); // 0x0000000180E3D890-0x0000000180E3D9D0
		public List<Type> GetTypesInNamespace(string nameSpace); // 0x0000000180E3D9D0-0x0000000180E3DC60
	}
}
