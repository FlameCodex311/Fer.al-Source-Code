/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	[CustomObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	internal static class ThreadSafeUnityInput // TypeDefIndex: 5785
	{
		// Fields
		private static Mouse KUXWtLbLKAAvBupLaWwXlFqZRDl; // 0x00
		private static Keyboard dnBiMHFXdLFwnSykRGBRBCnxcnuh; // 0x08
	
		// Properties
		public static Mouse mouse { get; } // 0x00000001807B3DC0-0x00000001807B3EE0 
		public static Keyboard keyboard { get; } // 0x00000001807B3D40-0x00000001807B3DC0 
	
		// Nested types
		[CustomClassObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
		[CustomObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
		public sealed class Keyboard // TypeDefIndex: 5786
		{
			// Fields
			private const int dkbQwWEGdYvWqHgwDVFfqiIBuCI = 132; // Metadata: 0x0072EBE8
			public static readonly int keyValueIndex_Escape; // 0x00
			public static readonly int keyValueIndex_Menu; // 0x04
			public static readonly int keyValueIndex_F2; // 0x08
			public static readonly int keyValueIndex_UpArrow; // 0x0C
			public static readonly int keyValueIndex_RightArrow; // 0x10
			public static readonly int keyValueIndex_DownArrow; // 0x14
			public static readonly int keyValueIndex_LeftArrow; // 0x18
			private static readonly int[] AkmBdmXEMLHZyleJSPXZopefEqx; // 0x20
			private readonly int VSueFCIHzEOqbAAHWqyxhoUpmmSQ; // 0x10
			private readonly int[] PHZblNhqmDpIZVZMfCuPPXOkgZa; // 0x18
			private readonly bool[] BtcuDhDnnSEohOGNhSbOXqnStyP; // 0x20
			private bool RYgMGyqWnNNUOzFUBDIFjvchsBxb; // 0x28
			private int NTRlznJuCWyalPjsOAcueZOjbbH; // 0x2C
			private readonly bool RJwxragBQeSTQlSaTeqTjfgyWwH; // 0x30
	
			// Properties
			public bool enabled { get; set; } // 0x00000001803A2790-0x00000001803A27A0 0x00000001807A0C10-0x00000001807A0D70
			public bool monitoring { get; } // 0x00000001807A0BC0-0x00000001807A0BD0 
			public int keyCount { get; } // 0x000000018035E110-0x000000018035E120 
	
			// Constructors
			static Keyboard(); // 0x00000001807A0380-0x00000001807A0920
			public Keyboard(); // 0x00000001807A0920-0x00000001807A0BC0
	
			// Methods
			public void Initialize(); // 0x000000018079FDD0-0x000000018079FE20
			public void PostInitialize(); // 0x000000018079FEC0-0x000000018079FED0
			public void Update(); // 0x000000018079FEE0-0x00000001807A0380
			public void Monitor(bool state); // 0x000000018079FE20-0x000000018079FEC0
			public bool GetKey(KeyCode keyCode); // 0x000000018079FD00-0x000000018079FDD0
			public void GetKeyValues(bool[] values); // 0x000000018079FC50-0x000000018079FD00
			public void Clear(); // 0x000000018079FAE0-0x000000018079FC10
			private void pwUnWPfbiGLoijyBXbHmkHOMWJp(); // 0x0000000180362E20-0x0000000180362E40
			private void UoMHNaNPthiGlAUrLPIFatCuFSe(); // 0x000000018079FED0-0x000000018079FEE0
			private void jQAZxqkbnfpgPDirpgJRdSfwkMUj(); // 0x00000001803581E0-0x00000001803581F0
			private void VOjUhZVjXhkzyponQzpGGexPwtY(); // 0x0000000180362E20-0x0000000180362E40
			private void EQirVzcBFzDMfwJrOzCZJTVFPQq(); // 0x000000018079FC10-0x000000018079FC50
			private void kdIyphmIlDvIhUeVLNpAxkpnpCL(); // 0x00000001807A0BD0-0x00000001807A0C10
		}
	
		[CustomClassObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
		[CustomObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
		public sealed class Mouse // TypeDefIndex: 5787
		{
			// Fields
			private const int yPnzCDCUouValTYijrIjZkOzBoi = 7; // Metadata: 0x0072EBEC
			private const int mcagbMPDbZbuDLVSXAdSGosiwJk = 3; // Metadata: 0x0072EBF0
			private readonly bool[] fjFgJnkphrVLUzcZIWNBokLGbBNJ; // 0x10
			private readonly float[] GtbxbNliAGztmrCOiIgKeWgIuiM; // 0x18
			private int NTRlznJuCWyalPjsOAcueZOjbbH; // 0x20
			private Vector3 FgZjBWgjiNfbEPIznkEcpHOjNnFq; // 0x24
			private bool IsfJgSAMOpcemHbMURwDTpiUaIT; // 0x30
	
			// Properties
			public bool monitoring { get; } // 0x00000001807A1510-0x00000001807A1520 
			public Vector3 mousePosition { get; } // 0x00000001807A1520-0x00000001807A1540 
			public bool mousePresent { get; } // 0x000000018048B840-0x000000018048B850 
	
			// Constructors
			public Mouse(); // 0x00000001807A1450-0x00000001807A1510
	
			// Methods
			public void PostInitialize(); // 0x00000001807A1100-0x00000001807A1110
			public void Update(); // 0x00000001807A1180-0x00000001807A13F0
			public void Monitor(bool state); // 0x00000001807A1010-0x00000001807A1100
			public bool GetButton(int index); // 0x00000001807A0F70-0x00000001807A1010
			public float GetAxisRaw(int index); // 0x00000001807A0E50-0x00000001807A0ED0
			public void GetButtonValues(bool[] buttons); // 0x00000001807A0ED0-0x00000001807A0F70
			public void GetAxisRawValues(float[] axes); // 0x00000001807A0DB0-0x00000001807A0E50
			private void pwUnWPfbiGLoijyBXbHmkHOMWJp(); // 0x00000001807A13F0-0x00000001807A1450
			private void UoMHNaNPthiGlAUrLPIFatCuFSe(); // 0x00000001807A1110-0x00000001807A1180
			private void jQAZxqkbnfpgPDirpgJRdSfwkMUj(); // 0x00000001803581E0-0x00000001803581F0
			private void VOjUhZVjXhkzyponQzpGGexPwtY(); // 0x00000001807A13F0-0x00000001807A1450
			private void CVEbVTgQOePpPTOLOcYeelaTkqD(); // 0x00000001807A0D70-0x00000001807A0DB0
			private void kdIyphmIlDvIhUeVLNpAxkpnpCL(); // 0x00000001807A1540-0x00000001807A1580
		}
	
		// Methods
		public static void Initialize(); // 0x00000001803581E0-0x00000001803581F0
		public static void PostInitialize(); // 0x00000001807B39F0-0x00000001807B3A80
		public static void PostInitialize2(); // 0x00000001803581E0-0x00000001803581F0
		public static void Deinitialize(); // 0x00000001807B3970-0x00000001807B39F0
		public static void Update(); // 0x00000001807B3A80-0x00000001807B3D40
	}
}
