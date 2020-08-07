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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal class UnityUnifiedMouseSource : IDisposable, IUnifiedMouseSource // TypeDefIndex: 6610
	{
		// Fields
		private static HardwareControllerMap_Game qGQYerJXPeWtuzKISCxSYKrxjAn; // 0x00
		private UpdateLoopDataSet<SPCymIlDlGGPmeJZCcYvgaLCYZLV> otizAYZCokzxsCxXuUdnNnkkePI; // 0x10
		private float[] tqvJxZMwPGvIiAEICfKkSPeUdIa; // 0x18
		private bool[] LygNNlgWjNAscoMioInRQhJieDl; // 0x20
		private bool vEblpmllYIOuQHCXVghuIpihdSG; // 0x28
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Func<SPCymIlDlGGPmeJZCcYvgaLCYZLV> RmAwVhXJkTmkPbnjHBqKiBrHewI; // 0x08
	
		// Properties
		public InputSource inputSource { get; } // 0x00000001810AA060-0x00000001810AA070 
		public HardwareControllerMap_Game hardwareMap { get; } // 0x00000001810AAC20-0x00000001810AAC90 
		public int buttonCount { get; } // 0x000000018069B0C0-0x000000018069B0D0 
		public int axisCount { get; } // 0x000000018043E010-0x000000018043E020 
		public Vector2 mousePosition { get; } // 0x00000001810AAC90-0x00000001810AAD20 
	
		// Nested types
		private class SPCymIlDlGGPmeJZCcYvgaLCYZLV // TypeDefIndex: 6611
		{
			// Fields
			private float[] tqvJxZMwPGvIiAEICfKkSPeUdIa; // 0x10
			private bool[] LygNNlgWjNAscoMioInRQhJieDl; // 0x18
	
			// Constructors
			public SPCymIlDlGGPmeJZCcYvgaLCYZLV(int buttonCount, int axisCount); // 0x000000018109B930-0x000000018109B9A0
	
			// Methods
			public void JSgAZtuHctESHkxJfpLaYaakPwh(bool[] param_0000d7fc, float[] param_0000d7fd); // 0x000000018109B7B0-0x000000018109B8B0
			public void JldQocyyJAtAGMnlAOBzEqKkcyl(ControllerDataUpdater param_0000d7fe); // 0x000000018109B8B0-0x000000018109B930
			public void vMfAexzdpfzhXKkyGdAHmJVnQEr(); // 0x000000018109B9D0-0x000000018109BAB0
			public void iRSdQZIPTRKDKaonAZQLCdscQcCu(); // 0x000000018109B9A0-0x000000018109B9D0
		}
	
		// Constructors
		public UnityUnifiedMouseSource(); // 0x00000001810AA9A0-0x00000001810AAC20
	
		// Methods
		public void UpdateInputData(ControllerDataUpdater dataUpdater); // 0x00000001810AA860-0x00000001810AA9A0
		public void Clear(); // 0x00000001810AA530-0x00000001810AA630
		private void uDwJKfTvnpluXPdnXAwRrcbxjEb(); // 0x00000001810AAE30-0x00000001810AB130
		private void gnWDgXDhVtiPMJYjjMiBygVqBtL(UpdateLoopType param_0000d7f7); // 0x00000001810AAD20-0x00000001810AADA0
		private static HardwareControllerMap_Game ucxBBbNIZPrkEAlWZbXBqgYqHGL(); // 0x00000001810AB130-0x00000001810ABC70
		public void Dispose(); // 0x00000001810AA630-0x00000001810AA6A0
		~UnityUnifiedMouseSource(); // 0x000000018043CAE0-0x000000018043CB80
		protected virtual void Dispose(bool disposing); // 0x00000001810AA6A0-0x00000001810AA7C0
		public static ControllerElementType GetHardwareElementType(int elementIdentifierId); // 0x00000001810AA7C0-0x00000001810AA860
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static SPCymIlDlGGPmeJZCcYvgaLCYZLV pOcCcEPETYfiVgcsLGAPfcnitqGJ(); // 0x00000001810AADA0-0x00000001810AAE30
	}
}
