/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal static class ThreadSafeUnityInput // TypeDefIndex: 5944
	{
		// Fields
		private static Mouse KUXWtLbLKAAvBupLaWwXlFqZRDl; // 0x00
		private static Keyboard dnBiMHFXdLFwnSykRGBRBCnxcnuh; // 0x08
	
		// Properties
		public static Mouse mouse { get; } // 0x00000001810A8A30-0x00000001810A8B50 
		public static Keyboard keyboard { get; } // 0x00000001810A89B0-0x00000001810A8A30 
	
		// Nested types
		[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
		[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
		public sealed class Keyboard // TypeDefIndex: 5945
		{
			// Fields
			private const int dkbQwWEGdYvWqHgwDVFfqiIBuCI = 132; // Metadata: 0x00763885
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
			public bool enabled { get; set; } // 0x00000001804C6790-0x00000001804C67A0 0x0000000181095C10-0x0000000181095D70
			public bool monitoring { get; } // 0x0000000181095BC0-0x0000000181095BD0 
			public int keyCount { get; } // 0x000000018040D5D0-0x000000018040D5E0 
	
			// Constructors
			static Keyboard(); // 0x00000001810953D0-0x0000000181095940
			public Keyboard(); // 0x0000000181095940-0x0000000181095BC0
	
			// Methods
			public void Initialize(); // 0x0000000181094E50-0x0000000181094EA0
			public void PostInitialize(); // 0x0000000181094F40-0x0000000181094F50
			public void Update(); // 0x0000000181094F60-0x00000001810953D0
			public void Monitor(bool state); // 0x0000000181094EA0-0x0000000181094F40
			public bool GetKey(KeyCode keyCode); // 0x0000000181094D90-0x0000000181094E50
			public void GetKeyValues(bool[] values); // 0x0000000181094CE0-0x0000000181094D90
			public void Clear(); // 0x0000000181094B80-0x0000000181094CA0
			private void pwUnWPfbiGLoijyBXbHmkHOMWJp(); // 0x0000000180411D90-0x0000000180411DB0
			private void UoMHNaNPthiGlAUrLPIFatCuFSe(); // 0x0000000181094F50-0x0000000181094F60
			private void jQAZxqkbnfpgPDirpgJRdSfwkMUj(); // 0x00000001803774A0-0x00000001803774B0
			private void VOjUhZVjXhkzyponQzpGGexPwtY(); // 0x0000000180411D90-0x0000000180411DB0
			private void EQirVzcBFzDMfwJrOzCZJTVFPQq(); // 0x0000000181094CA0-0x0000000181094CE0
			private void kdIyphmIlDvIhUeVLNpAxkpnpCL(); // 0x0000000181095BD0-0x0000000181095C10
		}
	
		[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
		[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
		public sealed class Mouse // TypeDefIndex: 5946
		{
			// Fields
			private const int yPnzCDCUouValTYijrIjZkOzBoi = 7; // Metadata: 0x00763889
			private const int mcagbMPDbZbuDLVSXAdSGosiwJk = 3; // Metadata: 0x0076388D
			private readonly bool[] fjFgJnkphrVLUzcZIWNBokLGbBNJ; // 0x10
			private readonly float[] GtbxbNliAGztmrCOiIgKeWgIuiM; // 0x18
			private int NTRlznJuCWyalPjsOAcueZOjbbH; // 0x20
			private Vector3 FgZjBWgjiNfbEPIznkEcpHOjNnFq; // 0x24
			private bool IsfJgSAMOpcemHbMURwDTpiUaIT; // 0x30
	
			// Properties
			public bool monitoring { get; } // 0x0000000181096500-0x0000000181096510 
			public Vector3 mousePosition { get; } // 0x00000001806757C0-0x00000001806757E0 
			public bool mousePresent { get; } // 0x0000000180455B90-0x0000000180455BA0 
	
			// Constructors
			public Mouse(); // 0x0000000181096440-0x0000000181096500
	
			// Methods
			public void PostInitialize(); // 0x0000000181096100-0x0000000181096110
			public void Update(); // 0x0000000181096180-0x00000001810963E0
			public void Monitor(bool state); // 0x0000000181096010-0x0000000181096100
			public bool GetButton(int index); // 0x0000000181095F70-0x0000000181096010
			public float GetAxisRaw(int index); // 0x0000000181095E50-0x0000000181095ED0
			public void GetButtonValues(bool[] buttons); // 0x0000000181095ED0-0x0000000181095F70
			public void GetAxisRawValues(float[] axes); // 0x0000000181095DB0-0x0000000181095E50
			private void pwUnWPfbiGLoijyBXbHmkHOMWJp(); // 0x00000001810963E0-0x0000000181096440
			private void UoMHNaNPthiGlAUrLPIFatCuFSe(); // 0x0000000181096110-0x0000000181096180
			private void jQAZxqkbnfpgPDirpgJRdSfwkMUj(); // 0x00000001803774A0-0x00000001803774B0
			private void VOjUhZVjXhkzyponQzpGGexPwtY(); // 0x00000001810963E0-0x0000000181096440
			private void CVEbVTgQOePpPTOLOcYeelaTkqD(); // 0x0000000181095D70-0x0000000181095DB0
			private void kdIyphmIlDvIhUeVLNpAxkpnpCL(); // 0x0000000181096510-0x0000000181096550
		}
	
		// Methods
		public static void Initialize(); // 0x00000001803774A0-0x00000001803774B0
		public static void PostInitialize(); // 0x00000001810A8660-0x00000001810A86F0
		public static void PostInitialize2(); // 0x00000001803774A0-0x00000001803774B0
		public static void Deinitialize(); // 0x00000001810A85E0-0x00000001810A8660
		public static void Update(); // 0x00000001810A86F0-0x00000001810A89B0
	}
}
