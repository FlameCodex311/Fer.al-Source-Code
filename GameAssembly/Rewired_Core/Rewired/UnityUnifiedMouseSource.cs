/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Interfaces;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	[CustomObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	internal class UnityUnifiedMouseSource : IDisposable, IUnifiedMouseSource // TypeDefIndex: 6451
	{
		// Fields
		private static HardwareControllerMap_Game qGQYerJXPeWtuzKISCxSYKrxjAn; // 0x00
		private UpdateLoopDataSet<SPCymIlDlGGPmeJZCcYvgaLCYZLV> otizAYZCokzxsCxXuUdnNnkkePI; // 0x10
		private float[] tqvJxZMwPGvIiAEICfKkSPeUdIa; // 0x18
		private bool[] LygNNlgWjNAscoMioInRQhJieDl; // 0x20
		private bool vEblpmllYIOuQHCXVghuIpihdSG; // 0x28
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Func<SPCymIlDlGGPmeJZCcYvgaLCYZLV> RmAwVhXJkTmkPbnjHBqKiBrHewI; // 0x08
	
		// Properties
		public InputSource inputSource { get; } // 0x00000001807B5410-0x00000001807B5420 
		public HardwareControllerMap_Game hardwareMap { get; } // 0x00000001807B6010-0x00000001807B6080 
		public int buttonCount { get; } // 0x00000001806A5520-0x00000001806A5530 
		public int axisCount { get; } // 0x000000018038FAD0-0x000000018038FAE0 
		public Vector2 mousePosition { get; } // 0x00000001807B6080-0x00000001807B6110 
	
		// Nested types
		private class SPCymIlDlGGPmeJZCcYvgaLCYZLV // TypeDefIndex: 6452
		{
			// Fields
			private float[] tqvJxZMwPGvIiAEICfKkSPeUdIa; // 0x10
			private bool[] LygNNlgWjNAscoMioInRQhJieDl; // 0x18
	
			// Constructors
			public SPCymIlDlGGPmeJZCcYvgaLCYZLV(int buttonCount, int axisCount); // 0x00000001807A6A50-0x00000001807A6AC0
	
			// Methods
			public void JSgAZtuHctESHkxJfpLaYaakPwh(bool[] param_0000d58c, float[] param_0000d58d); // 0x00000001807A68B0-0x00000001807A69D0
			public void JldQocyyJAtAGMnlAOBzEqKkcyl(ControllerDataUpdater param_0000d58e); // 0x00000001807A69D0-0x00000001807A6A50
			public void vMfAexzdpfzhXKkyGdAHmJVnQEr(); // 0x00000001807A6AF0-0x00000001807A6BD0
			public void iRSdQZIPTRKDKaonAZQLCdscQcCu(); // 0x00000001807A6AC0-0x00000001807A6AF0
		}
	
		// Constructors
		public UnityUnifiedMouseSource(); // 0x00000001807B5D80-0x00000001807B6010
	
		// Methods
		public void UpdateInputData(ControllerDataUpdater dataUpdater); // 0x00000001807B5C30-0x00000001807B5D80
		public void Clear(); // 0x00000001807B5900-0x00000001807B5A00
		private void uDwJKfTvnpluXPdnXAwRrcbxjEb(); // 0x00000001807B6220-0x00000001807B6530
		private void gnWDgXDhVtiPMJYjjMiBygVqBtL(UpdateLoopType param_0000d587); // 0x00000001807B6110-0x00000001807B6190
		private static HardwareControllerMap_Game ucxBBbNIZPrkEAlWZbXBqgYqHGL(); // 0x00000001807B6530-0x00000001807B70C0
		public void Dispose(); // 0x00000001807B5A00-0x00000001807B5A70
		~UnityUnifiedMouseSource(); // 0x000000018038E540-0x000000018038E5E0
		protected virtual void Dispose(bool disposing); // 0x00000001807B5A70-0x00000001807B5B90
		public static ControllerElementType GetHardwareElementType(int elementIdentifierId); // 0x00000001807B5B90-0x00000001807B5C30
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static SPCymIlDlGGPmeJZCcYvgaLCYZLV pOcCcEPETYfiVgcsLGAPfcnitqGJ(); // 0x00000001807B6190-0x00000001807B6220
	}
}
