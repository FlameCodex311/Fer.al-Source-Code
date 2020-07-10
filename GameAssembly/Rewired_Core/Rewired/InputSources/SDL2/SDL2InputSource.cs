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
using Rewired.Config;
using Rewired.Interfaces;
using Rewired.Utils.Classes.Data;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.InputSources.SDL2
{
	[CustomClassObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	[CustomObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	internal class SDL2InputSource : IInputSource // TypeDefIndex: 6772
	{
		// Fields
		private const int plxeZeVfHQLnGjshIxKjElCCfcQ = 32; // Metadata: 0x007318F4
		private bool pSRVZPQHHLdqaCmDIDqEkwkQucOa; // 0x10
		private bool miJWcVWeQXlcUDrUlRaMRILjqTN; // 0x11
		private bool ReJWQryoBAahRzFrevXyiVZGxmJ; // 0x12
		private bool qiiEmbGbcnhQClsRHlkOikgiwyiS; // 0x13
		private bool ZjOOLblNcYQwrXXNEEJgJyiCsWf; // 0x14
		private ADictionary<int, ofCXUZZnthwMsLfobYEuFfXddmd> YxWCMHbPaQgZcysPKFMIEybVXlg; // 0x18
		private ADictionary<int, YpOXstdUISWZyhnwSxuyzINfBuO> enoBmNllMvDoxGsoUeIxydpFpBhK; // 0x20
		private XuQduOJtehtSnRIDvBZHHUdTYQd.VWPjGWEoQUlbjzVArBuzvMhEZTD VRpoIuoZCakijspNBAndamLPUBu; // 0x28
		private NativeBuffer uOlaDNeWiMxBKUQIhxYNYMppvQM; // 0xB0
		private Action yWUlHJfAowoXwxtjUhoNiHqDKak; // 0xB8
		private bool vEblpmllYIOuQHCXVghuIpihdSG; // 0xC0
	
		// Properties
		public bool initialized { get; } // 0x0000000180491CD0-0x0000000180491CE0 
	
		// Events
		private event Action _DeviceChangedEvent {
			add; // 0x0000000180490B70-0x0000000180490C40
			remove; // 0x000000018048FE10-0x000000018048FED0
		}
		public event Action DeviceChangedEvent {
			add; // 0x0000000180490B70-0x0000000180490C40
			remove; // 0x000000018048FE10-0x000000018048FED0
		}
	
		// Nested types
		public delegate void uwjZggTggHTBFDQfjMwGaSLOFIX(int joystickId, byte rewiredElementType, byte elementIndex, short value); // TypeDefIndex: 6773; 0x000000018049B8A0-0x000000018049BB00
	
		public delegate void DeLfqRCqbcdOgUpoBUouRXfvGJlt(int joystickIndex); // TypeDefIndex: 6774; 0x0000000180484C40-0x0000000180484E00
	
		public delegate void ZMOPkowrnwYTqyMKXwJAXaOfKbO(int joystickId); // TypeDefIndex: 6775; 0x0000000180484C40-0x0000000180484E00
	
		public delegate void xCxjPqmGZJdILDrTWBQFiFIMmOIs(int gameControllerId, byte rewiredElementType, byte sdlElementType, short value); // TypeDefIndex: 6776; 0x000000018049B8A0-0x000000018049BB00
	
		// Constructors
		public SDL2InputSource(UpdateLoopSetting updateLoop, bool handleJoysticks, bool handleGamepads, bool handleUnifiedMouse, bool handleUnifiedKeyboard); // 0x00000001804911D0-0x00000001804914E0
	
		// Methods
		public void SystemDeviceConnected(); // 0x0000000180490870-0x00000001804908C0
		public void SystemDeviceDisconnected(); // 0x00000001804908C0-0x0000000180490910
		public void Update(); // 0x00000001803581E0-0x00000001803581F0
		public void UpdateDevices(UpdateLoopType updateLoop); // 0x0000000180490910-0x0000000180490920
		public void UpdateFinished(); // 0x00000001803581E0-0x00000001803581F0
		public IList<T> GetJoysticks<T>()
			where T : class;
		private int kmDiaVkDOxWZPWJknkGiaOdwdOR(); // 0x0000000180491CE0-0x0000000180491D50
		private int oRyFhUVvytbmsDHHhtDbWocChZNw(); // 0x0000000180491D50-0x0000000180491E20
		private ofCXUZZnthwMsLfobYEuFfXddmd JTJRDbWIJsALOCWPVJzLDDXNikSH(int param_0000e983); // 0x00000001804901B0-0x00000001804902C0
		private YpOXstdUISWZyhnwSxuyzINfBuO fbyYLBMDLvSkJStFMWypxeAZVNN(int param_0000e984); // 0x0000000180491B10-0x0000000180491CD0
		private NZfxZgapcZrDfHOIlImhbYniErsQ WlRdAMASEuJhkZuvlJtChLGaXddg(int param_0000e985, vxJvUArhEAFCtWNhHGCwJpxnawZ param_0000e986); // 0x0000000180490920-0x0000000180490AF0
		private NZfxZgapcZrDfHOIlImhbYniErsQ MroXjiGHtYtORLdnEnEJObdjDJLH(int param_0000e987, ooiUvbxDJOfANpQNqxCQYuhBdqW param_0000e988); // 0x0000000180490360-0x0000000180490460
		private void SFdkawHchMjouIijwHcpLeFrppT(); // 0x0000000180490740-0x0000000180490870
		private void auejyNVQFahvIYYDWTfcsfvkytm(); // 0x00000001804915A0-0x00000001804918E0
		private bool XaPQxcyWqNsdQjhKzBKsjimvZyS(int param_0000e989); // 0x0000000180490C40-0x0000000180490F30
		private void xzceZeGGWmetBAeiWNsduDUsewIa(int param_0000e98a); // 0x0000000180492010-0x00000001804920F0
		private bool PBHZsPtuEbxYILeNNedeeArLgHk(int param_0000e98b); // 0x00000001804905A0-0x0000000180490740
		private void pDpVsCyBVQtoWpNscFUJYZrMgxM(int param_0000e98c); // 0x0000000180491E20-0x0000000180491F10
		private ofCXUZZnthwMsLfobYEuFfXddmd YenhsGyKhilmpWqdaavZzFpxwk(int param_0000e98d); // 0x0000000180491150-0x00000001804911D0
		private YpOXstdUISWZyhnwSxuyzINfBuO WtXKmRbxoZPiDarUmooqQcFMkDu(int param_0000e98e); // 0x0000000180490AF0-0x0000000180490B70
		private void HrKyBteQRTGPVZoOyXtDRwkStWJ(); // 0x000000018048FED0-0x00000001804901B0
		private void fQioYvBbwXIqfkEAMtzXUmcldUS(ref XuQduOJtehtSnRIDvBZHHUdTYQd.XjyyRsSGBQTmFSrAEjSYYxYVcvZ param_0000e98f, float param_0000e990); // 0x0000000180491AD0-0x0000000180491B10
		private void rCHeKFOVlnBeLkqBFsDahkjBQyv(ref XuQduOJtehtSnRIDvBZHHUdTYQd.eaiLQxFPVbiyzQeYbMDfsjXuYus param_0000e991, float param_0000e992); // 0x0000000180491F10-0x0000000180491F50
		private void CpFBdEmuutFwHBCVXuwZRdenKwV(ref XuQduOJtehtSnRIDvBZHHUdTYQd.VbqHzpkFQxelXAAgaCTyIBDkDeiS param_0000e993, float param_0000e994); // 0x000000018048FC00-0x000000018048FC40
		private void KfGsqunNaoaRJkjbFMseyVJmbDap(ref XuQduOJtehtSnRIDvBZHHUdTYQd.vFoaHIvxPKHheIeNlMtTEhigGsHh param_0000e995, float param_0000e996); // 0x00000001803581E0-0x00000001803581F0
		private void MOAzAShnoEtLIJiGRGTiIdLqOLpp(ref XuQduOJtehtSnRIDvBZHHUdTYQd.KeufpOPSyPatYATlqXKEcbKbDMxe param_0000e997); // 0x00000001804902C0-0x0000000180490360
		private void ArIooqjuAaMpjMeGWIJWUBKjXUj(ref XuQduOJtehtSnRIDvBZHHUdTYQd.KeufpOPSyPatYATlqXKEcbKbDMxe param_0000e998); // 0x000000018048FA90-0x000000018048FC00
		private void zljZKcoetjcSBkJyfKGGqJsttKOk(ref XuQduOJtehtSnRIDvBZHHUdTYQd.nqEtmsjAEnVUpVynOEmjtAVlpJT param_0000e999, float param_0000e99a); // 0x00000001804920F0-0x00000001804921A0
		private void AeIfhvlGbNQHVsGeEGhtMwWZKCx(ref XuQduOJtehtSnRIDvBZHHUdTYQd.kYOOkxdUscjOIJJnvKGoGAdHCDC param_0000e99b, float param_0000e99c); // 0x000000018048F9E0-0x000000018048FA90
		private void dghGPtQAmsiURiBZQDsOoLljdZG(ref XuQduOJtehtSnRIDvBZHHUdTYQd.TWbSqjGUHWCCRHgNzSNRhhTPAAw param_0000e99d); // 0x00000001804918E0-0x0000000180491AD0
		private void NSYKTwNWdKqoDyplZhWfEfHrpNE(ref XuQduOJtehtSnRIDvBZHHUdTYQd.TWbSqjGUHWCCRHgNzSNRhhTPAAw param_0000e99e); // 0x0000000180490460-0x00000001804905A0
		private void yzlkJDggnLqEgPETmBviQcQtfdx(ref XuQduOJtehtSnRIDvBZHHUdTYQd.TWbSqjGUHWCCRHgNzSNRhhTPAAw param_0000e99f); // 0x00000001803581E0-0x00000001803581F0
		private void viMVeAbZyzvWWShccQnmKwbAOGs(int param_0000e9a0, heWsaowXosfzMSjjpixrjKJUuub param_0000e9a1, byte param_0000e9a2, short param_0000e9a3, float param_0000e9a4); // 0x0000000180491F50-0x0000000180492010
		private void aCkXDLyoBSVamKmqZkvIsmfYgFt(int param_0000e9a5, heWsaowXosfzMSjjpixrjKJUuub param_0000e9a6, byte param_0000e9a7, short param_0000e9a8, float param_0000e9a9); // 0x00000001804914E0-0x00000001804915A0
		private void YEEGRcrMNcgsYAerxnXVzhvkzPs(); // 0x0000000180490F30-0x0000000180491150
		public void Dispose(); // 0x000000018048FCE0-0x000000018048FD70
		~SDL2InputSource(); // 0x000000018048FD70-0x000000018048FE10
		protected virtual void Dispose(bool disposing); // 0x000000018048FC40-0x000000018048FCE0
	}
}
