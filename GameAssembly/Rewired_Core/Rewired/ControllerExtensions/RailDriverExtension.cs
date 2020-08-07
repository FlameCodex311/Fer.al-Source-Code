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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.ControllerExtensions
{
	public sealed class RailDriverExtension : Controller.Extension // TypeDefIndex: 6079
	{
		// Fields
		private UiAQXZWWcbPCDtotNvWeVUhyWvq EWvxEcokoAEStdCudJqOMgkHwwyD; // 0x28
	
		// Properties
		private Joystick joystick { get; } // 0x00000001808E4130-0x00000001808E4170 
		public bool speakerEnabled { get; set; } // 0x00000001808E4170-0x00000001808E4250 0x00000001808E4250-0x00000001808E43E0
	
		// Nested types
		private class UiAQXZWWcbPCDtotNvWeVUhyWvq : IControllerExtensionSource // TypeDefIndex: 6080
		{
			// Fields
			public readonly IDriver_RailDriver pLSlGvFkDOedcZzLNmTZIETLroL; // 0x10
	
			// Constructors
			public UiAQXZWWcbPCDtotNvWeVUhyWvq(IDriver_RailDriver driver); // 0x0000000180400150-0x0000000180400180
		}
	
		// Constructors
		internal RailDriverExtension(IDriver_RailDriver driver); // 0x00000001808E40C0-0x00000001808E4130
		private RailDriverExtension(RailDriverExtension source); // 0x00000001808E1090-0x00000001808E10F0
	
		// Methods
		public void SetLEDDisplay(int digitIndex, byte digitBitValues); // 0x00000001808E3F00-0x00000001808E4040
		public void SetLEDDisplay(byte digit1BitValues, byte digit2BitValues, byte digit3BitValues); // 0x00000001808E3D20-0x00000001808E3F00
		internal override void UpdateData(UpdateLoopType param_0000cc9c); // 0x00000001803774A0-0x00000001803774B0
		internal override void SourceUpdated(IControllerExtensionSource param_0000cc9d); // 0x00000001808E4040-0x00000001808E40C0
		internal override Controller.Extension Clone(); // 0x00000001808E3C90-0x00000001808E3D20
	}
}
