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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Platforms.XboxOne
{
	[CustomClassObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	[CustomObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	internal sealed class XboxOneInputSource : CustomInputSource, IXboxOneInputSource // TypeDefIndex: 6944
	{
		// Fields
		private const int CljYMibFYEKebAlwFYmJUyrwtij = 8; // Metadata: 0x00731D18
		private readonly bool UiuVfXaOVJlpnMDNdnJtrhHFBAyf; // 0x48
		private bool pyGeXNEBbHwJbQEEeOUTZGJFHBcC; // 0x49
		private Queue<rflDiHfmIiyzeUOeHoOuSMbBGydt> QoCsVbrNbDrlNdtDlVkqPOHfTLU; // 0x50
		private bool vEblpmllYIOuQHCXVghuIpihdSG; // 0x58
	
		// Properties
		public override bool isReady { get; } // 0x00000001805E3A60-0x00000001805E3A70 
	
		// Nested types
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private enum BadConnectionReason // TypeDefIndex: 6945
		{
			None = 0,
			GamepadNotActive = 1,
			InvalidName = 2
		}
	
		private struct rflDiHfmIiyzeUOeHoOuSMbBGydt // TypeDefIndex: 6946
		{
			// Fields
			public uint yakyHVnzrOMeZdFhXNCFSGyAFNJh; // 0x00
			public uint HQXhoqfkzLflnbuuTrhWOUOsxKH; // 0x04
	
			// Constructors
			public rflDiHfmIiyzeUOeHoOuSMbBGydt(uint unityJoystickId, uint connectedFrame); // 0x0000000180012950-0x0000000180012990
		}
	
		private class BAggblEwbzkGnmKltXUmGbwGZdr : CustomInputSource.Joystick // TypeDefIndex: 6947
		{
			// Fields
			private const int HSpXIOmQNElWIyytfUCCACgxbmfG = 6; // Metadata: 0x00731D28
			private const int frWlFJmIuHDCrDwnhgqBkPNnPHK = 14; // Metadata: 0x00731D2C
			private const string uKDxeFKtfnwGPvkHrjhVFDuaWaQo = "Xbox One Controller"; // Metadata: 0x00731D30
			private const int PJHfszffTHZddbYqNkohfczQCGj = 0; // Metadata: 0x00731D47
			private const int mWoGHZQNjtYjjCCufdSIXxpXZJO = 1; // Metadata: 0x00731D4B
			private const int VImxkSsWioOUPCQAneQizhUzfgVi = 2; // Metadata: 0x00731D4F
			private const int eMQCObENobJsHDiamEBVmTAjtJL = 3; // Metadata: 0x00731D53
			private const int pvKnYdVMJgPUUuBOirGwFjDpyWn = 4; // Metadata: 0x00731D57
			private const int SggBkLtPbYbphCToZBMrTOFgjnEL = 5; // Metadata: 0x00731D5B
			private const int spHTvylmOUFroBJixXaFvZHUKtyf = 6; // Metadata: 0x00731D5F
			private const int PZAsbeNupayJnjUpRVBfPDnajOb = 7; // Metadata: 0x00731D63
			private const int pLgeISCQzuqBbjrqHuuirPeqiQbC = 8; // Metadata: 0x00731D67
			private const int DJHNsPfGNheTzalclmJsupYExoX = 9; // Metadata: 0x00731D6B
			private const int ysmhsjwTxsYYkXDmjHXLVAmOkKL = 12; // Metadata: 0x00731D6F
			private const int xUkoNEMjxMkOrRdeBCpmaFNMaYk = 13; // Metadata: 0x00731D73
			private const int VKzGtaGKpjzERDNSRNBpHEvpUiq = 14; // Metadata: 0x00731D77
			private const int BFIjBYvbKkBNveTGExWwuRomvSt = 15; // Metadata: 0x00731D7B
			private const int DNyPiEFpTbGNvTgHqaaGKARsyjD = 0; // Metadata: 0x00731D7F
			private const int gXPwHcnPNDxftbaxqnAyHPpypDN = 1; // Metadata: 0x00731D83
			private const int jlqjIjzPdLHAvGCzZROnqCuaEuOr = 3; // Metadata: 0x00731D87
			private const int iytgxJHSREAfTapjKMMpdIXqHoGK = 4; // Metadata: 0x00731D8B
			private const int NcZDvMdeDbEbdHTGBlYxErQLjKDk = 8; // Metadata: 0x00731D8F
			private const int qBUZhZapWIzjJMYztNyCDAsiamH = 9; // Metadata: 0x00731D93
			private readonly IXboxOneInputSource IfWmLaqyRlsuporQiJgqwmXsLqe; // 0x70
			private int PwftjjvcgliCLJyonFqzuKQTKBiF; // 0x78
			private ulong CBXmiFoQFoTazOFFeobCBxnQqOY; // 0x80
			private string[] laTiEekcmcoZfZgrSDZOeWgHGyQ; // 0x88
	
			// Properties
			public ulong LgvHvwZktzCBtWrELBYgfCvURvt { get; } // 0x000000018035FCB0-0x000000018035FCC0 
	
			// Constructors
			public BAggblEwbzkGnmKltXUmGbwGZdr(IXboxOneInputSource inputSource, ulong xboxControllerId, int unityJoystickId, bool isConnected); // 0x000000018082FCE0-0x000000018082FE80
	
			// Methods
			public override void Update(); // 0x000000018082EDE0-0x000000018082FCE0
			public void ItdhavHGXcUkAhyjaCFbIXENJheh(ulong param_0000f470); // 0x000000018082E8D0-0x000000018082EA00
			private void duLuRPLQXuawkWSRsiMYVvscyVg(); // 0x000000018082FE80-0x000000018082FF30
			private bool fanZEvScpHOhjdyqIAGzUttVsod(int param_0000f471); // 0x000000018082FF30-0x000000018082FF50
			private void UpSNrCWxlLHTMarUaEyOkHdRUug(); // 0x000000018082EA00-0x000000018082EDE0
		}
	
		// Constructors
		public XboxOneInputSource(); // 0x000000018084E570-0x000000018084E760
	
		// Methods
		public override void Update(); // 0x000000018084E370-0x000000018084E570
		private void IdrJLwlQkclhWJnlmoCaMKrlJEm(uint param_0000f45a, bool param_0000f45b); // 0x000000018084DC80-0x000000018084DE80
		private void uHpqNzGhRTBZibUgqVZPNPardwDD(uint param_0000f45c, bool param_0000f45d); // 0x000000018084EA60-0x000000018084EC60
		private void NsUKomOVOfUmonpfKuZRSJscJoa(); // 0x000000018084DE80-0x000000018084E0C0
		private bool scAswdcibZgXmojhsmmgibTxHlC(uint param_0000f45e, bool param_0000f45f, out BadConnectionReason param_0000f460); // 0x000000018084E7B0-0x000000018084EA60
		private void eytOUFzpxdBqVGrBUfevEeQiFTKA(); // 0x000000018084E760-0x000000018084E7B0
		public int GetXboxOneUserIdFromUnityJoystick(int unityJoystickId); // 0x000000018084DB80-0x000000018084DC80
		public void PulseVibrateMotor(ulong xboxOneJoystickId, XboxOneGamepadMotorType motor, float startLevel, float endLevel, float duration); // 0x000000018084E0C0-0x000000018084E230
		public bool SetXboxOneVibration(ulong xboxOneJoystickId, xcWyiIfNoFqFVFpAfvXHnUTXXPi vibration); // 0x000000018084E230-0x000000018084E370
		public override void Dispose(); // 0x000000018084D960-0x000000018084D9D0
		~XboxOneInputSource(); // 0x00000001806396C0-0x0000000180639760
		protected override void Dispose(bool disposing); // 0x000000018084D9D0-0x000000018084DB80
	}
}
