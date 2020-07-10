/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Drivers.Interfaces;
using Rewired.Interfaces;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.ControllerExtensions
{
	public sealed class RailDriverExtension : Controller.Extension // TypeDefIndex: 5920
	{
		// Fields
		private UiAQXZWWcbPCDtotNvWeVUhyWvq EWvxEcokoAEStdCudJqOMgkHwwyD; // 0x28
	
		// Properties
		private Joystick joystick { get; } // 0x000000018045D870-0x000000018045D8B0 
		public bool speakerEnabled { get; set; } // 0x000000018045D8B0-0x000000018045D990 0x000000018045D990-0x000000018045DB30
	
		// Nested types
		private class UiAQXZWWcbPCDtotNvWeVUhyWvq : IControllerExtensionSource // TypeDefIndex: 5921
		{
			// Fields
			public readonly IDriver_RailDriver pLSlGvFkDOedcZzLNmTZIETLroL; // 0x10
	
			// Constructors
			public UiAQXZWWcbPCDtotNvWeVUhyWvq(IDriver_RailDriver driver); // 0x000000018037D3F0-0x000000018037D420
		}
	
		// Constructors
		internal RailDriverExtension(IDriver_RailDriver driver); // 0x000000018045D800-0x000000018045D870
		private RailDriverExtension(RailDriverExtension source); // 0x000000018045A5E0-0x000000018045A640
	
		// Methods
		public void SetLEDDisplay(int digitIndex, byte digitBitValues); // 0x000000018045D640-0x000000018045D780
		public void SetLEDDisplay(byte digit1BitValues, byte digit2BitValues, byte digit3BitValues); // 0x000000018045D460-0x000000018045D640
		internal override void UpdateData(UpdateLoopType param_0000ca2c); // 0x00000001803581E0-0x00000001803581F0
		internal override void SourceUpdated(IControllerExtensionSource param_0000ca2d); // 0x000000018045D780-0x000000018045D800
		internal override Controller.Extension Clone(); // 0x000000018045D3D0-0x000000018045D460
	}
}
