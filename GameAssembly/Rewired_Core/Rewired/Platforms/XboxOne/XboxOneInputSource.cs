/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Platforms.Custom;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Platforms.XboxOne
{
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal sealed class XboxOneInputSource : CustomInputSource, IXboxOneInputSource // TypeDefIndex: 7103
	{
		// Fields
		private const int CljYMibFYEKebAlwFYmJUyrwtij = 8; // Metadata: 0x007669B5
		private readonly bool UiuVfXaOVJlpnMDNdnJtrhHFBAyf; // 0x48
		private bool pyGeXNEBbHwJbQEEeOUTZGJFHBcC; // 0x49
		private Queue<rflDiHfmIiyzeUOeHoOuSMbBGydt> QoCsVbrNbDrlNdtDlVkqPOHfTLU; // 0x50
		private bool vEblpmllYIOuQHCXVghuIpihdSG; // 0x58
	
		// Properties
		public override bool isReady { get; } // 0x00000001803C9D60-0x00000001803C9D70 
	
		// Nested types
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private enum BadConnectionReason // TypeDefIndex: 7104
		{
			None = 0,
			GamepadNotActive = 1,
			InvalidName = 2
		}
	
		private struct rflDiHfmIiyzeUOeHoOuSMbBGydt // TypeDefIndex: 7105
		{
			// Fields
			public uint yakyHVnzrOMeZdFhXNCFSGyAFNJh; // 0x00
			public uint HQXhoqfkzLflnbuuTrhWOUOsxKH; // 0x04
	
			// Constructors
			public rflDiHfmIiyzeUOeHoOuSMbBGydt(uint unityJoystickId, uint connectedFrame); // 0x0000000180006A50-0x0000000180006A60
		}
	
		private class BAggblEwbzkGnmKltXUmGbwGZdr : CustomInputSource.Joystick // TypeDefIndex: 7106
		{
			// Fields
			private const int HSpXIOmQNElWIyytfUCCACgxbmfG = 6; // Metadata: 0x007669C5
			private const int frWlFJmIuHDCrDwnhgqBkPNnPHK = 14; // Metadata: 0x007669C9
			private const string uKDxeFKtfnwGPvkHrjhVFDuaWaQo = "Xbox One Controller"; // Metadata: 0x007669CD
			private const int PJHfszffTHZddbYqNkohfczQCGj = 0; // Metadata: 0x007669E4
			private const int mWoGHZQNjtYjjCCufdSIXxpXZJO = 1; // Metadata: 0x007669E8
			private const int VImxkSsWioOUPCQAneQizhUzfgVi = 2; // Metadata: 0x007669EC
			private const int eMQCObENobJsHDiamEBVmTAjtJL = 3; // Metadata: 0x007669F0
			private const int pvKnYdVMJgPUUuBOirGwFjDpyWn = 4; // Metadata: 0x007669F4
			private const int SggBkLtPbYbphCToZBMrTOFgjnEL = 5; // Metadata: 0x007669F8
			private const int spHTvylmOUFroBJixXaFvZHUKtyf = 6; // Metadata: 0x007669FC
			private const int PZAsbeNupayJnjUpRVBfPDnajOb = 7; // Metadata: 0x00766A00
			private const int pLgeISCQzuqBbjrqHuuirPeqiQbC = 8; // Metadata: 0x00766A04
			private const int DJHNsPfGNheTzalclmJsupYExoX = 9; // Metadata: 0x00766A08
			private const int ysmhsjwTxsYYkXDmjHXLVAmOkKL = 12; // Metadata: 0x00766A0C
			private const int xUkoNEMjxMkOrRdeBCpmaFNMaYk = 13; // Metadata: 0x00766A10
			private const int VKzGtaGKpjzERDNSRNBpHEvpUiq = 14; // Metadata: 0x00766A14
			private const int BFIjBYvbKkBNveTGExWwuRomvSt = 15; // Metadata: 0x00766A18
			private const int DNyPiEFpTbGNvTgHqaaGKARsyjD = 0; // Metadata: 0x00766A1C
			private const int gXPwHcnPNDxftbaxqnAyHPpypDN = 1; // Metadata: 0x00766A20
			private const int jlqjIjzPdLHAvGCzZROnqCuaEuOr = 3; // Metadata: 0x00766A24
			private const int iytgxJHSREAfTapjKMMpdIXqHoGK = 4; // Metadata: 0x00766A28
			private const int NcZDvMdeDbEbdHTGBlYxErQLjKDk = 8; // Metadata: 0x00766A2C
			private const int qBUZhZapWIzjJMYztNyCDAsiamH = 9; // Metadata: 0x00766A30
			private readonly IXboxOneInputSource IfWmLaqyRlsuporQiJgqwmXsLqe; // 0x70
			private int PwftjjvcgliCLJyonFqzuKQTKBiF; // 0x78
			private ulong CBXmiFoQFoTazOFFeobCBxnQqOY; // 0x80
			private string[] laTiEekcmcoZfZgrSDZOeWgHGyQ; // 0x88
	
			// Properties
			public ulong LgvHvwZktzCBtWrELBYgfCvURvt { get; } // 0x000000018040ED60-0x000000018040ED70 
	
			// Constructors
			public BAggblEwbzkGnmKltXUmGbwGZdr(IXboxOneInputSource inputSource, ulong xboxControllerId, int unityJoystickId, bool isConnected); // 0x0000000181169C90-0x0000000181169E30
	
			// Methods
			public override void Update(); // 0x0000000181168DD0-0x0000000181169C90
			public void ItdhavHGXcUkAhyjaCFbIXENJheh(ulong param_0000f6e0); // 0x00000001811688F0-0x0000000181168A20
			private void duLuRPLQXuawkWSRsiMYVvscyVg(); // 0x0000000181169E30-0x0000000181169EE0
			private bool fanZEvScpHOhjdyqIAGzUttVsod(int param_0000f6e1); // 0x0000000181169EE0-0x0000000181169F00
			private void UpSNrCWxlLHTMarUaEyOkHdRUug(); // 0x0000000181168A20-0x0000000181168DD0
		}
	
		// Constructors
		public XboxOneInputSource(); // 0x00000001811883D0-0x00000001811885B0
	
		// Methods
		public override void Update(); // 0x00000001811881D0-0x00000001811883D0
		private void IdrJLwlQkclhWJnlmoCaMKrlJEm(uint param_0000f6ca, bool param_0000f6cb); // 0x0000000181187AE0-0x0000000181187CE0
		private void uHpqNzGhRTBZibUgqVZPNPardwDD(uint param_0000f6cc, bool param_0000f6cd); // 0x00000001811888A0-0x0000000181188AA0
		private void NsUKomOVOfUmonpfKuZRSJscJoa(); // 0x0000000181187CE0-0x0000000181187F20
		private bool scAswdcibZgXmojhsmmgibTxHlC(uint param_0000f6ce, bool param_0000f6cf, out BadConnectionReason param_0000f6d0); // 0x0000000181188600-0x00000001811888A0
		private void eytOUFzpxdBqVGrBUfevEeQiFTKA(); // 0x00000001811885B0-0x0000000181188600
		public int GetXboxOneUserIdFromUnityJoystick(int unityJoystickId); // 0x00000001811879E0-0x0000000181187AE0
		public void PulseVibrateMotor(ulong xboxOneJoystickId, XboxOneGamepadMotorType motor, float startLevel, float endLevel, float duration); // 0x0000000181187F20-0x0000000181188090
		public bool SetXboxOneVibration(ulong xboxOneJoystickId, xcWyiIfNoFqFVFpAfvXHnUTXXPi vibration); // 0x0000000181188090-0x00000001811881D0
		public override void Dispose(); // 0x00000001811877C0-0x0000000181187830
		~XboxOneInputSource(); // 0x0000000180EB0EA0-0x0000000180EB0F40
		protected override void Dispose(bool disposing); // 0x0000000181187830-0x00000001811879E0
	}
}
