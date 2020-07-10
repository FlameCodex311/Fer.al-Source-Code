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
	public class GaiaExtensionManager // TypeDefIndex: 9001
	{
		// Fields
		private Dictionary<string, GaiaCompatiblePublisher> m_extensions; // 0x10
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 9002
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<GaiaCompatiblePublisher> <>9__3_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001815A7390-0x00000001815A73F0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal int <GetPublishers>b__3_0(GaiaCompatiblePublisher a, GaiaCompatiblePublisher b); // 0x00000001815A72D0-0x00000001815A7310
		}
	
		// Constructors
		public GaiaExtensionManager(); // 0x0000000181587990-0x00000001815879F0
	
		// Methods
		public void ScanForExtensions(); // 0x0000000181586D40-0x0000000181587990
		public int GetInstalledExtensionCount(); // 0x0000000181586800-0x0000000181586960
		public List<GaiaCompatiblePublisher> GetPublishers(); // 0x0000000181586960-0x0000000181586AA0
		public List<Type> GetTypesInNamespace(string nameSpace); // 0x0000000181586AA0-0x0000000181586D40
	}
}
