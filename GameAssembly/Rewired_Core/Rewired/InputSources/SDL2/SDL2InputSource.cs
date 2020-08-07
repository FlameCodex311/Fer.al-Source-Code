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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.InputSources.SDL2
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal class SDL2InputSource : IInputSource // TypeDefIndex: 6931
	{
		// Fields
		private const int plxeZeVfHQLnGjshIxKjElCCfcQ = 32; // Metadata: 0x00766591
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
		public bool initialized { get; } // 0x00000001809A8910-0x00000001809A8920 
	
		// Events
		private event Action _DeviceChangedEvent {
			add; // 0x00000001809A77E0-0x00000001809A78B0
			remove; // 0x00000001809A6A80-0x00000001809A6B40
		}
		public event Action DeviceChangedEvent {
			add; // 0x00000001809A77E0-0x00000001809A78B0
			remove; // 0x00000001809A6A80-0x00000001809A6B40
		}
	
		// Nested types
		public delegate void uwjZggTggHTBFDQfjMwGaSLOFIX(int joystickId, byte rewiredElementType, byte elementIndex, short value); // TypeDefIndex: 6932; 0x00000001809B2470-0x00000001809B2740
	
		public delegate void DeLfqRCqbcdOgUpoBUouRXfvGJlt(int joystickIndex); // TypeDefIndex: 6933; 0x000000018099BBF0-0x000000018099BDF0
	
		public delegate void ZMOPkowrnwYTqyMKXwJAXaOfKbO(int joystickId); // TypeDefIndex: 6934; 0x000000018099BBF0-0x000000018099BDF0
	
		public delegate void xCxjPqmGZJdILDrTWBQFiFIMmOIs(int gameControllerId, byte rewiredElementType, byte sdlElementType, short value); // TypeDefIndex: 6935; 0x00000001809B2470-0x00000001809B2740
	
		// Constructors
		public SDL2InputSource(UpdateLoopSetting updateLoop, bool handleJoysticks, bool handleGamepads, bool handleUnifiedMouse, bool handleUnifiedKeyboard); // 0x00000001809A7E20-0x00000001809A8130
	
		// Methods
		public void SystemDeviceConnected(); // 0x00000001809A74E0-0x00000001809A7530
		public void SystemDeviceDisconnected(); // 0x00000001809A7530-0x00000001809A7580
		public void Update(); // 0x00000001803774A0-0x00000001803774B0
		public void UpdateDevices(UpdateLoopType updateLoop); // 0x00000001809A7580-0x00000001809A7590
		public void UpdateFinished(); // 0x00000001803774A0-0x00000001803774B0
		public IList<T> GetJoysticks<T>()
			where T : class;
		private int kmDiaVkDOxWZPWJknkGiaOdwdOR(); // 0x00000001809A8920-0x00000001809A8990
		private int oRyFhUVvytbmsDHHhtDbWocChZNw(); // 0x00000001809A8990-0x00000001809A8A60
		private ofCXUZZnthwMsLfobYEuFfXddmd JTJRDbWIJsALOCWPVJzLDDXNikSH(int param_0000ebf3); // 0x00000001809A6E20-0x00000001809A6F30
		private YpOXstdUISWZyhnwSxuyzINfBuO fbyYLBMDLvSkJStFMWypxeAZVNN(int param_0000ebf4); // 0x00000001809A8750-0x00000001809A8910
		private NZfxZgapcZrDfHOIlImhbYniErsQ WlRdAMASEuJhkZuvlJtChLGaXddg(int param_0000ebf5, vxJvUArhEAFCtWNhHGCwJpxnawZ param_0000ebf6); // 0x00000001809A7590-0x00000001809A7760
		private NZfxZgapcZrDfHOIlImhbYniErsQ MroXjiGHtYtORLdnEnEJObdjDJLH(int param_0000ebf7, ooiUvbxDJOfANpQNqxCQYuhBdqW param_0000ebf8); // 0x00000001809A6FD0-0x00000001809A70D0
		private void SFdkawHchMjouIijwHcpLeFrppT(); // 0x00000001809A73B0-0x00000001809A74E0
		private void auejyNVQFahvIYYDWTfcsfvkytm(); // 0x00000001809A81F0-0x00000001809A8520
		private bool XaPQxcyWqNsdQjhKzBKsjimvZyS(int param_0000ebf9); // 0x00000001809A78B0-0x00000001809A7B90
		private void xzceZeGGWmetBAeiWNsduDUsewIa(int param_0000ebfa); // 0x00000001809A8C40-0x00000001809A8D20
		private bool PBHZsPtuEbxYILeNNedeeArLgHk(int param_0000ebfb); // 0x00000001809A7210-0x00000001809A73B0
		private void pDpVsCyBVQtoWpNscFUJYZrMgxM(int param_0000ebfc); // 0x00000001809A8A60-0x00000001809A8B40
		private ofCXUZZnthwMsLfobYEuFfXddmd YenhsGyKhilmpWqdaavZzFpxwk(int param_0000ebfd); // 0x00000001809A7DA0-0x00000001809A7E20
		private YpOXstdUISWZyhnwSxuyzINfBuO WtXKmRbxoZPiDarUmooqQcFMkDu(int param_0000ebfe); // 0x00000001809A7760-0x00000001809A77E0
		private void HrKyBteQRTGPVZoOyXtDRwkStWJ(); // 0x00000001809A6B40-0x00000001809A6E20
		private void fQioYvBbwXIqfkEAMtzXUmcldUS(ref XuQduOJtehtSnRIDvBZHHUdTYQd.XjyyRsSGBQTmFSrAEjSYYxYVcvZ param_0000ebff, float param_0000ec00); // 0x00000001809A8710-0x00000001809A8750
		private void rCHeKFOVlnBeLkqBFsDahkjBQyv(ref XuQduOJtehtSnRIDvBZHHUdTYQd.eaiLQxFPVbiyzQeYbMDfsjXuYus param_0000ec01, float param_0000ec02); // 0x00000001809A8B40-0x00000001809A8B80
		private void CpFBdEmuutFwHBCVXuwZRdenKwV(ref XuQduOJtehtSnRIDvBZHHUdTYQd.VbqHzpkFQxelXAAgaCTyIBDkDeiS param_0000ec03, float param_0000ec04); // 0x00000001809A6870-0x00000001809A68B0
		private void KfGsqunNaoaRJkjbFMseyVJmbDap(ref XuQduOJtehtSnRIDvBZHHUdTYQd.vFoaHIvxPKHheIeNlMtTEhigGsHh param_0000ec05, float param_0000ec06); // 0x00000001803774A0-0x00000001803774B0
		private void MOAzAShnoEtLIJiGRGTiIdLqOLpp(ref XuQduOJtehtSnRIDvBZHHUdTYQd.KeufpOPSyPatYATlqXKEcbKbDMxe param_0000ec07); // 0x00000001809A6F30-0x00000001809A6FD0
		private void ArIooqjuAaMpjMeGWIJWUBKjXUj(ref XuQduOJtehtSnRIDvBZHHUdTYQd.KeufpOPSyPatYATlqXKEcbKbDMxe param_0000ec08); // 0x00000001809A6700-0x00000001809A6870
		private void zljZKcoetjcSBkJyfKGGqJsttKOk(ref XuQduOJtehtSnRIDvBZHHUdTYQd.nqEtmsjAEnVUpVynOEmjtAVlpJT param_0000ec09, float param_0000ec0a); // 0x00000001809A8D20-0x00000001809A8DD0
		private void AeIfhvlGbNQHVsGeEGhtMwWZKCx(ref XuQduOJtehtSnRIDvBZHHUdTYQd.kYOOkxdUscjOIJJnvKGoGAdHCDC param_0000ec0b, float param_0000ec0c); // 0x00000001809A6650-0x00000001809A6700
		private void dghGPtQAmsiURiBZQDsOoLljdZG(ref XuQduOJtehtSnRIDvBZHHUdTYQd.TWbSqjGUHWCCRHgNzSNRhhTPAAw param_0000ec0d); // 0x00000001809A8520-0x00000001809A8710
		private void NSYKTwNWdKqoDyplZhWfEfHrpNE(ref XuQduOJtehtSnRIDvBZHHUdTYQd.TWbSqjGUHWCCRHgNzSNRhhTPAAw param_0000ec0e); // 0x00000001809A70D0-0x00000001809A7210
		private void yzlkJDggnLqEgPETmBviQcQtfdx(ref XuQduOJtehtSnRIDvBZHHUdTYQd.TWbSqjGUHWCCRHgNzSNRhhTPAAw param_0000ec0f); // 0x00000001803774A0-0x00000001803774B0
		private void viMVeAbZyzvWWShccQnmKwbAOGs(int param_0000ec10, heWsaowXosfzMSjjpixrjKJUuub param_0000ec11, byte param_0000ec12, short param_0000ec13, float param_0000ec14); // 0x00000001809A8B80-0x00000001809A8C40
		private void aCkXDLyoBSVamKmqZkvIsmfYgFt(int param_0000ec15, heWsaowXosfzMSjjpixrjKJUuub param_0000ec16, byte param_0000ec17, short param_0000ec18, float param_0000ec19); // 0x00000001809A8130-0x00000001809A81F0
		private void YEEGRcrMNcgsYAerxnXVzhvkzPs(); // 0x00000001809A7B90-0x00000001809A7DA0
		public void Dispose(); // 0x00000001809A6950-0x00000001809A69E0
		~SDL2InputSource(); // 0x00000001809A69E0-0x00000001809A6A80
		protected virtual void Dispose(bool disposing); // 0x00000001809A68B0-0x00000001809A6950
	}
}
