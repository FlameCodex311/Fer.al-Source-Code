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
using Rewired.Interfaces;
using Rewired.Platforms.Custom;
using Rewired.Platforms.PS4.Internal;
using Rewired.Utils.Interfaces;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Platforms.PS4
{
	[CustomClassObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	[CustomObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	internal sealed class PS4InputSource : CustomInputSource, IControllerAssigner // TypeDefIndex: 6666
	{
		// Fields
		private bVdLitkJwIkMtgpGEhlltNcDAVtB KKgGBnvVPIHKLeoEiDFMVEWiQgg; // 0x48
		private bool oNOIeYMKHAHgxzxbeCSiMiBWGly; // 0x50
		private bool vEblpmllYIOuQHCXVghuIpihdSG; // 0x51
	
		// Properties
		public override bool isReady { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		bool IControllerAssigner.enabled { get; set; } // 0x0000000180619B50-0x0000000180619B60 0x0000000180639DF0-0x0000000180639E00
	
		// Nested types
		private class bVdLitkJwIkMtgpGEhlltNcDAVtB // TypeDefIndex: 6667
		{
			// Fields
			private readonly int fRskZosLuSThEgySMpCXrMvfEqAf; // 0x10
			private readonly bool mswGSyiKsnzKVrCPvokGGJlKMST; // 0x14
			private readonly int[] UUjceoLFgvIGaMyOQDfnconnThG; // 0x18
			private readonly int[] idiRIMrDIGaSGhMbgWLBMfoxGZn; // 0x20
			private readonly IExternalTools nhAGFSdWWacMFCxNPAHNFwdgKnWN; // 0x28
			private readonly gJimgVEtEKjjtBghbyfHMHtAltx[] UlmLLsTkJpWdOfbQsFlLjUIHKtE; // 0x30
			private readonly gJimgVEtEKjjtBghbyfHMHtAltx[] myaxGznpiRYndWgPoVJUdBdMRLE; // 0x38
			private readonly List<amDVRclcdlhHlNBNMFAuxkaDfvL> ayAOfBdgxZPHSGhlydbfGudSkRr; // 0x40
			private readonly List<QUohiajXjNgRguTFzwsChJokNwo> PRJXUKSZqDhVcGjBINtDBqGFgQw; // 0x48
			private Action<amDVRclcdlhHlNBNMFAuxkaDfvL> otSrWzRexeFOjkthPDUVyKctLKV; // 0x50
			private Action<QUohiajXjNgRguTFzwsChJokNwo> XwQJpVrFTBzrglJROxGzUiOThmr; // 0x58
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<gJimgVEtEKjjtBghbyfHMHtAltx> SoptGiBIwpEzOTmBujKpoVBsSer; // 0x00
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<gJimgVEtEKjjtBghbyfHMHtAltx> AGoLVphFiYSQJEBguHfxHhzJytur; // 0x08
	
			// Events
			public event Action<amDVRclcdlhHlNBNMFAuxkaDfvL> otSrWzRexeFOjkthPDUVyKctLKV {
				add; // 0x0000000180641250-0x0000000180641320
				remove; // 0x0000000180641480-0x0000000180641570
			}
			public event Action<QUohiajXjNgRguTFzwsChJokNwo> XwQJpVrFTBzrglJROxGzUiOThmr {
				add; // 0x0000000180641320-0x00000001806413C0
				remove; // 0x0000000180641570-0x0000000180641650
			}
	
			// Nested types
			public struct amDVRclcdlhHlNBNMFAuxkaDfvL // TypeDefIndex: 6668
			{
				// Fields
				public int yqGgGVbZkMCNTIxfuiHTVgIqHCJ; // 0x00
				public int UWBFQEfrTnYUCjshCYfdJplmoOOm; // 0x04
				public int bdmIEaEbgsJTwdQWVXeQWkyhpqFe; // 0x08
				public bool STsORkqoVwmWsWAMVLhuWNzKAJj; // 0x0C
	
				// Constructors
				public amDVRclcdlhHlNBNMFAuxkaDfvL(int playerId, int handle, int deviceClass, bool isSpecialController); // 0x000000018000C390-0x000000018000C590
			}
	
			public struct QUohiajXjNgRguTFzwsChJokNwo // TypeDefIndex: 6669
			{
				// Fields
				public int yqGgGVbZkMCNTIxfuiHTVgIqHCJ; // 0x00
				public int UWBFQEfrTnYUCjshCYfdJplmoOOm; // 0x04
				public bool STsORkqoVwmWsWAMVLhuWNzKAJj; // 0x08
	
				// Constructors
				public QUohiajXjNgRguTFzwsChJokNwo(int playerId, int handle, bool isSpecialController); // 0x000000018000C340-0x000000018000C390
			}
	
			private class gJimgVEtEKjjtBghbyfHMHtAltx // TypeDefIndex: 6670
			{
				// Fields
				public readonly bool STsORkqoVwmWsWAMVLhuWNzKAJj; // 0x10
				public bool hvZFJvCsezEBoyduXJlPDonRVQP; // 0x11
				public int UWBFQEfrTnYUCjshCYfdJplmoOOm; // 0x14
				public int bdmIEaEbgsJTwdQWVXeQWkyhpqFe; // 0x18
	
				// Constructors
				public gJimgVEtEKjjtBghbyfHMHtAltx(bool isSpecialController); // 0x00000001806425D0-0x0000000180642610
	
				// Methods
				public iOffFQkOuXzkNBIpmUecQVQqSVLS KkJiNfHDfiJwfwbJJdnbTpAKFxkf(bool param_0000e4c9, int param_0000e4ca, int param_0000e4cb); // 0x0000000180642500-0x00000001806425D0
				private void vMfAexzdpfzhXKkyGdAHmJVnQEr(); // 0x0000000180642610-0x0000000180642620
			}
	
			[Flags] // 0x00000001800B36B0-0x00000001800B36C0
			private enum iOffFQkOuXzkNBIpmUecQVQqSVLS // TypeDefIndex: 6671
			{
				PoBZZNoYGVGuWkUBxQqhGBhFqWy = 0,
				MuvJHvZGEoEJPiVlttEMQktXAcqj = 1,
				tzmAMoABfcLEwMCWeFSzgCQDVbI = 2,
				qQucigIhMiBUrHzLuPJvduaBobf = 4
			}
	
			// Constructors
			public bVdLitkJwIkMtgpGEhlltNcDAVtB(int maxPlayers, bool supportSpecialControllers); // 0x0000000180641030-0x0000000180641250
	
			// Methods
			public void MrPMknIMZzaXDjcXZFUzCeTcWDAs(); // 0x00000001806401B0-0x0000000180640D00
			private void UtGfmFMhxafSIjqIPBQMfvpUQDKu(int param_0000e4bd, gJimgVEtEKjjtBghbyfHMHtAltx param_0000e4be, int param_0000e4bf, bool param_0000e4c0); // 0x0000000180640D00-0x0000000180641030
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static gJimgVEtEKjjtBghbyfHMHtAltx pOcCcEPETYfiVgcsLGAPfcnitqGJ(); // 0x0000000180641420-0x0000000180641480
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static gJimgVEtEKjjtBghbyfHMHtAltx nKBfZOoSRNcWGVmXsGDbjHqfeFdg(); // 0x00000001806413C0-0x0000000180641420
		}
	
		private abstract class meaDvZLdTStMzqDmUtkldoXVBFq : CustomInputSource.Joystick, IPS4ControllerExtensionSource // TypeDefIndex: 6672
		{
			// Fields
			public const bool NxiTYncgJCKPdSFDMzEERQuieof = true; // Metadata: 0x0073120A
			private static int ucpRwVXBZbQgsGhKbOwcYGtApRI; // 0x00
			protected readonly int qInCCRhldamcdoUHmMSlSCAIgFUz; // 0x70
			protected readonly int QMUmjZykbifGzWsGXBcuZDqXGch; // 0x74
			protected readonly bool KDDiayBbyUnoivkjIEsSEPzqrqa; // 0x78
			protected readonly tQdmWIvYpLTtWCLOpumBTXPfGCC OgaPkhmfietDMGNMncaxtfOzABd; // 0x80
			protected readonly int PwftjjvcgliCLJyonFqzuKQTKBiF; // 0x88
			protected readonly float[] aYpEXMpeIlDrjPmxJHNTdCFZEre; // 0x90
			private readonly LoggedInUser VvJaKBblAblboVBpsLwTwPFJZejV; // 0x98
			protected readonly ControllerType qYQtZXCUUQiyGpzdDXLOHBOwcPe; // 0xA0
			private readonly Func<int, bool> OpXdpQccvLImWIXxHKgvuzfGsAmF; // 0xA8
			private readonly Action<int, int, int> vWhrNKOqEhrdskFUnMvMpauOGbqH; // 0xB0
			private readonly Action<int, int, int, int> sxZGfQdFVZIGlJwDoYJCEEKyBXvg; // 0xB8
			private readonly Action<int> ajZwKdHBxJwudVLhbNcxmfCHOOw; // 0xC0
			private Action<int, bool> HFgnOHnDYptVLvyQcpHRiGoTBMr; // 0xC8
			private Action<int, bool> HIbiqWlIcGkhhGMUmGLDpMMwdoO; // 0xD0
			private Action<int, bool> jKgyyjmaziMcrZEufFHDpNhyaqY; // 0xD8
			private Action<int> cycXMrdWdneDgzJsUeuLdmudHGdi; // 0xE0
			private Func<int, Vector3> USNpbppkhrGrUFwdnjvxnsyxTEnL; // 0xE8
			private Func<int, Vector3> IOIUuNmayTsgFrRAIYTLjONLpOv; // 0xF0
			private Func<int, Vector4> geVNoYXfjwWRPnRCRdakcgPddEn; // 0xF8
	
			// Properties
			private static int oUnPkmyGsXCbUrBRISmROqOzVyR { get; } // 0x0000000180645C50-0x0000000180645CB0 
			protected LoggedInUser jFcgNPgLNoHPNaHdtdgwroqnnJh { get; } // 0x0000000180645CB0-0x0000000180645DC0 
			public ControllerType JmvHHQieRmxAYahCfvzgQBWHgSne { get; } // 0x00000001804A36F0-0x00000001804A3700 
			public int yqGgGVbZkMCNTIxfuiHTVgIqHCJ { get; } // 0x00000001803DAD00-0x00000001803DAD10 
			public int UWBFQEfrTnYUCjshCYfdJplmoOOm { get; } // 0x00000001803DAD10-0x00000001803DAD20 
			public bool STsORkqoVwmWsWAMVLhuWNzKAJj { get; } // 0x00000001804A2540-0x00000001804A2550 
			private bool BSWZxPQiWxBhGncxrWjXxmTWBcOd { get; } // 0x0000000180645C00-0x0000000180645C50 
			public int zGdbUshTycKAtYCpVcJXKunoKXo { get; } // 0x0000000180645DC0-0x0000000180645DE0 
	
			// Nested types
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			public enum ControllerType // TypeDefIndex: 6673
			{
				Unknown = 0,
				Gamepad = 1,
				Move = 2,
				Guitar = 3,
				Drum = 4,
				DjTurntable = 5,
				DanceMat = 6,
				Navigation = 7,
				SteeringWheel = 8,
				Stick = 9,
				FlightStick = 10,
				Gun = 11
			}
	
			protected enum RdBLmZZaUnqkUJwfsSPLBCRwHRe // TypeDefIndex: 6674
			{
				IjuFlluoMybUtpSqFtBQAlMgUyR = 0,
				NmKtZgJGKXhhdAwkHccPjmHfhnk = 1,
				xeXPypynNGxwlFuyHbzDZbmdEHH = 2
			}
	
			public class tQdmWIvYpLTtWCLOpumBTXPfGCC // TypeDefIndex: 6675
			{
				// Fields
				public readonly int RweyBZyAAIjbTgpvgIOlbybhzioP; // 0x10
				public readonly int QsBvetqPHrzKthaGEErdieSJgIkd; // 0x14
				public readonly float HweParDwxxcsTfyepGGaAhkTWgF; // 0x18
				public readonly int zGdbUshTycKAtYCpVcJXKunoKXo; // 0x1C
				public readonly int NvkUvSVhegrIiySWCTpxvOgoaTSa; // 0x20
	
				// Constructors
				public tQdmWIvYpLTtWCLOpumBTXPfGCC(int axisCount, int buttonCount, float dpadDeadzone, int vibrationMotorCount, int maxTouches); // 0x0000000180646FB0-0x0000000180647010
			}
	
			// Constructors
			protected meaDvZLdTStMzqDmUtkldoXVBFq(ControllerType type, string name, int playerId, int unityJoystickId, int handle, tQdmWIvYpLTtWCLOpumBTXPfGCC capabilities); // 0x0000000180644AD0-0x0000000180645BD0
			static meaDvZLdTStMzqDmUtkldoXVBFq(); // 0x00000001803581E0-0x00000001803581F0
	
			// Methods
			public static meaDvZLdTStMzqDmUtkldoXVBFq AQMpZVIIXTyemnHtIDPtxhINdLN(ControllerType param_0000e4cc, int param_0000e4cd, int param_0000e4ce); // 0x0000000180642BF0-0x0000000180642D70
			public static meaDvZLdTStMzqDmUtkldoXVBFq AQMpZVIIXTyemnHtIDPtxhINdLN(bool param_0000e4cf, int param_0000e4d0, int param_0000e4d1, int param_0000e4d2); // 0x0000000180642B50-0x0000000180642BF0
			public override void Update(); // 0x00000001806448C0-0x00000001806448E0
			public int GetUserId(); // 0x0000000180643600-0x0000000180643620
			public int GetUserStatus(); // 0x0000000180643680-0x00000001806436A0
			public bool GetUserIsPrimary(); // 0x0000000180643620-0x0000000180643650
			public Color GetUserColor(); // 0x0000000180643550-0x0000000180643600
			public int GetUserColorId(); // 0x0000000180643530-0x0000000180643550
			public string GetUserName(); // 0x0000000180643650-0x0000000180643680
			public void StopVibration(); // 0x00000001806439E0-0x0000000180643A20
			public void SetVibration(int param_0000e4d9, float param_0000e4da); // 0x0000000180643940-0x00000001806439E0
			public float GetVibration(int param_0000e4db); // 0x00000001806436A0-0x0000000180643700
			public void SetMotionSensorState(bool param_0000e4dc); // 0x0000000180643880-0x00000001806438E0
			public void SetTiltCorrectionState(bool param_0000e4dd); // 0x00000001806438E0-0x0000000180643940
			public void SetAngularVelocityDeadbandState(bool param_0000e4de); // 0x00000001806437A0-0x0000000180643800
			public void ResetOrientation(); // 0x0000000180643750-0x00000001806437A0
			public Vector3 GetLastAcceleration(); // 0x0000000180642EB0-0x0000000180643080
			public Vector3 GetLastAccelerationRaw(); // 0x0000000180642DA0-0x0000000180642EB0
			public Vector3 GetLastGyro(); // 0x0000000180643190-0x00000001806432E0
			public Vector3 GetLastGyroRaw(); // 0x0000000180643080-0x0000000180643190
			public Quaternion GetLastOrientation(); // 0x0000000180643400-0x0000000180643530
			public Quaternion GetLastOrientationRaw(); // 0x00000001806432E0-0x0000000180643400
			public void SetLightColor(int param_0000e4df, int param_0000e4e0, int param_0000e4e1); // 0x0000000180643800-0x0000000180643880
			public void ResetLight(); // 0x0000000180643700-0x0000000180643750
			protected virtual void UpdateElementValues(); // 0x0000000180643A20-0x00000001806448C0
			protected void YIJmswKDRGGwbeMwDPctrpFlaCfB(); // 0x00000001806448E0-0x0000000180644AD0
			protected static int EiFnhVyRTjWqpJdPQkRqjBgOfCtJ(float param_0000e4e2); // 0x0000000180642D70-0x0000000180642DA0
			protected static void wMNgJRrudGAWubGHyAWxyCZGiRK(ref Vector3 param_0000e4e3); // 0x0000000180645BD0-0x0000000180645C00
			protected static void cXLjRmmfCEMdyWhIZBaghglIYrM(ref Vector3 param_0000e4e4); // 0x0000000180645BD0-0x0000000180645C00
			protected static bool pPraApegcHjBgTMNFkMziqCEubU(int param_0000e4e5, out ControllerType param_0000e4e6); // 0x0000000180645DE0-0x0000000180646170
		}
	
		private sealed class fEnDRSNGvhiPWyEueacdxsgliKZD : meaDvZLdTStMzqDmUtkldoXVBFq, IPS4GamepadExtensionSource // TypeDefIndex: 6676
		{
			// Fields
			private const int mcagbMPDbZbuDLVSXAdSGosiwJk = 6; // Metadata: 0x00731247
			private const int yPnzCDCUouValTYijrIjZkOzBoi = 14; // Metadata: 0x0073124B
			private const float swbSgarzlrGRoFvCfYeRBWtvXGW = 0.05f; // Metadata: 0x0073124F
			private const int iKKGYPMEeUBIYTaUvEXNQCRNdYp = 2; // Metadata: 0x00731253
			private const int YTmtiWsooyXPPDNxOuSQfjMYCjb = 2; // Metadata: 0x00731257
			private int CLokCjmRDuGKgNijaGpGBWdmSwD; // 0x100
			private int rfRbawqrmICYjFWUXzcXQqfCztB; // 0x104
			private Vector2 DvbJPHrSfpygvvUdVrrkWlukaxg; // 0x108
			private int aHlbeFwPGEHrjwMwhDSRkTHdGnMa; // 0x110
			private Vector2 ZDjjIbbrIkFQcdXvzzJkZgNwNfa; // 0x114
			private RdBLmZZaUnqkUJwfsSPLBCRwHRe IxfsoeEpAHVPWghijMaYjysTBpG; // 0x11C
			private int yRciSqJMnhbljRPfJxDJnVBAVbx; // 0x120
			private int sUwfKsIesLcHCHQAWOjfiltLoSwN; // 0x124
			private int kTaFgxgLQTpfdVsnOULhFfdGEWxW; // 0x128
			private int DrloXsoVwXQnbYChKvNmoPFVFpD; // 0x12C
			private float JMVlDVdgZyMqASCdOEPeeqvpHqoE; // 0x130
	
			// Properties
			public int NvkUvSVhegrIiySWCTpxvOgoaTSa { get; } // 0x00000001806424E0-0x0000000180642500 
	
			// Constructors
			public fEnDRSNGvhiPWyEueacdxsgliKZD(string name, int playerId, int unityJoystickId, int handle); // 0x00000001806421B0-0x00000001806422C0
	
			// Methods
			public int GetConnectionType(); // 0x0000000180641670-0x0000000180641680
			public int GetAnalogDeadZoneLeft(); // 0x0000000180641650-0x0000000180641660
			public int GetAnalogDeadZoneRight(); // 0x0000000180641660-0x0000000180641670
			public float GetTouchPixelDensity(); // 0x00000001806416E0-0x00000001806416F0
			public int GetTouchpadResolutionX(); // 0x0000000180641E60-0x0000000180641E70
			public int GetTouchpadResolutionY(); // 0x0000000180641E70-0x0000000180641E80
			public int GetTouchCount(); // 0x0000000180641680-0x0000000180641690
			public int GetTouchId(int param_0000e4f0); // 0x0000000180641690-0x00000001806416E0
			public bool GetTouchPositionAbsByIndex(int param_0000e4f1, out Vector2 param_0000e4f2); // 0x00000001806416F0-0x0000000180641840
			public bool GetTouchPositionAbsByTouchId(int param_0000e4f3, out Vector2 param_0000e4f4); // 0x0000000180641840-0x0000000180641A20
			public bool GetTouchPositionByIndex(int param_0000e4f5, out Vector2 param_0000e4f6); // 0x0000000180641A20-0x0000000180641C00
			public bool GetTouchPositionByTouchId(int param_0000e4f7, out Vector2 param_0000e4f8); // 0x0000000180641C00-0x0000000180641E60
			public bool IsTouchingByIndex(int param_0000e4f9); // 0x0000000180641E80-0x0000000180641EE0
			public bool IsTouchingByTouchId(int param_0000e4fa); // 0x0000000180641EE0-0x0000000180641F60
			protected override void UpdateElementValues(); // 0x0000000180641F60-0x0000000180642150
			private void duLuRPLQXuawkWSRsiMYVvscyVg(); // 0x00000001806422C0-0x00000001806424E0
			private int UsLXGrvbyhupVWNLGtdNiZcXneC(int param_0000e4fb); // 0x0000000180642150-0x00000001806421B0
		}
	
		private abstract class CknYkuQcoBUbjagcoOrGtIdyKQI : meaDvZLdTStMzqDmUtkldoXVBFq // TypeDefIndex: 6677
		{
			// Constructors
			protected CknYkuQcoBUbjagcoOrGtIdyKQI(ControllerType controllerType, string name, int playerId, int unityJoystickId, int handle, tQdmWIvYpLTtWCLOpumBTXPfGCC capabilities); // 0x0000000180626B90-0x0000000180626C20
	
			// Methods
			public static CknYkuQcoBUbjagcoOrGtIdyKQI AQMpZVIIXTyemnHtIDPtxhINdLN(int param_0000e502, int param_0000e503, int param_0000e504); // 0x00000001806266D0-0x0000000180626B90
			public static new CknYkuQcoBUbjagcoOrGtIdyKQI AQMpZVIIXTyemnHtIDPtxhINdLN(ControllerType param_0000e505, int param_0000e506, int param_0000e507); // 0x0000000180626220-0x00000001806266D0
		}
	
		private sealed class YsLdaqHZYDISWmrMuFxZJmPjYif : CknYkuQcoBUbjagcoOrGtIdyKQI // TypeDefIndex: 6678
		{
			// Fields
			private const int mcagbMPDbZbuDLVSXAdSGosiwJk = 13; // Metadata: 0x0073125B
			private const int yPnzCDCUouValTYijrIjZkOzBoi = 14; // Metadata: 0x0073125F
			private const float swbSgarzlrGRoFvCfYeRBWtvXGW = 0.05f; // Metadata: 0x00731263
			private const int iKKGYPMEeUBIYTaUvEXNQCRNdYp = 2; // Metadata: 0x00731267
			private const int YTmtiWsooyXPPDNxOuSQfjMYCjb = 0; // Metadata: 0x0073126B
	
			// Constructors
			public YsLdaqHZYDISWmrMuFxZJmPjYif(string name, int playerId, int unityJoystickId, int handle); // 0x0000000180640090-0x00000001806401B0
	
			// Methods
			protected override void UpdateElementValues(); // 0x000000018063FB00-0x0000000180640090
		}
	
		private sealed class lWkOlHrPyWcPVJxrdRpstuTftvDD : CknYkuQcoBUbjagcoOrGtIdyKQI // TypeDefIndex: 6679
		{
			// Fields
			private const int mcagbMPDbZbuDLVSXAdSGosiwJk = 11; // Metadata: 0x0073126F
			private const int yPnzCDCUouValTYijrIjZkOzBoi = 14; // Metadata: 0x00731273
			private const float swbSgarzlrGRoFvCfYeRBWtvXGW = 0.05f; // Metadata: 0x00731277
			private const int iKKGYPMEeUBIYTaUvEXNQCRNdYp = 2; // Metadata: 0x0073127B
			private const int YTmtiWsooyXPPDNxOuSQfjMYCjb = 0; // Metadata: 0x0073127F
	
			// Constructors
			public lWkOlHrPyWcPVJxrdRpstuTftvDD(string name, int playerId, int unityJoystickId, int handle); // 0x0000000180642A30-0x0000000180642B50
	
			// Methods
			protected override void UpdateElementValues(); // 0x0000000180642620-0x0000000180642A30
		}
	
		private sealed class rzNYMZYIQsNEVTaFRYgqLRGRoq : CknYkuQcoBUbjagcoOrGtIdyKQI // TypeDefIndex: 6680
		{
			// Fields
			private const int mcagbMPDbZbuDLVSXAdSGosiwJk = 13; // Metadata: 0x00731283
			private const int yPnzCDCUouValTYijrIjZkOzBoi = 14; // Metadata: 0x00731287
			private const float swbSgarzlrGRoFvCfYeRBWtvXGW = 0.05f; // Metadata: 0x0073128B
			private const int iKKGYPMEeUBIYTaUvEXNQCRNdYp = 2; // Metadata: 0x0073128F
			private const int YTmtiWsooyXPPDNxOuSQfjMYCjb = 0; // Metadata: 0x00731293
	
			// Constructors
			public rzNYMZYIQsNEVTaFRYgqLRGRoq(string name, int playerId, int unityJoystickId, int handle); // 0x0000000180646E90-0x0000000180646FB0
	
			// Methods
			protected override void UpdateElementValues(); // 0x00000001806468A0-0x0000000180646E90
		}
	
		private sealed class rCMtaRpoIOPIugppYzJiTIEyDeF : CknYkuQcoBUbjagcoOrGtIdyKQI // TypeDefIndex: 6681
		{
			// Fields
			private const int mcagbMPDbZbuDLVSXAdSGosiwJk = 16; // Metadata: 0x00731297
			private const int yPnzCDCUouValTYijrIjZkOzBoi = 14; // Metadata: 0x0073129B
			private const float swbSgarzlrGRoFvCfYeRBWtvXGW = 0.05f; // Metadata: 0x0073129F
			private const int iKKGYPMEeUBIYTaUvEXNQCRNdYp = 2; // Metadata: 0x007312A3
			private const int YTmtiWsooyXPPDNxOuSQfjMYCjb = 0; // Metadata: 0x007312A7
	
			// Constructors
			public rCMtaRpoIOPIugppYzJiTIEyDeF(string name, int playerId, int unityJoystickId, int handle); // 0x0000000180646780-0x00000001806468A0
	
			// Methods
			protected override void UpdateElementValues(); // 0x0000000180646170-0x0000000180646780
		}
	
		// Constructors
		public PS4InputSource(); // 0x0000000180639F10-0x000000018063A470
	
		// Methods
		public override void Update(); // 0x0000000180639E00-0x0000000180639F10
		private static int rLVmTOqNErjHkWyUpBjrFOoWFIpH(int param_0000e4ad); // 0x000000018063A470-0x000000018063A480
		private void GdRcCOFmVZAjFbwjBuCgYQywFWCa(bVdLitkJwIkMtgpGEhlltNcDAVtB.amDVRclcdlhHlNBNMFAuxkaDfvL param_0000e4ae); // 0x0000000180639760-0x00000001806399B0
		private void tIwuLieLNiScUkipWTuUyLaZXHX(meaDvZLdTStMzqDmUtkldoXVBFq param_0000e4af); // 0x000000018063A480-0x000000018063A580
		private void DzWNUjqlJPmrsXCgJElPACZumzA(bVdLitkJwIkMtgpGEhlltNcDAVtB.QUohiajXjNgRguTFzwsChJokNwo param_0000e4b0); // 0x00000001806393A0-0x00000001806396C0
		bool IControllerAssigner.CanHandleAssignment(ControllerType param_0000e4b2, Controller param_0000e4b3); // 0x0000000180639D60-0x0000000180639DF0
		void IControllerAssigner.AssignController(ControllerType param_0000e4b4, Controller param_0000e4b5); // 0x00000001806399B0-0x0000000180639D60
		~PS4InputSource(); // 0x00000001806396C0-0x0000000180639760
		protected override void Dispose(bool disposing); // 0x0000000180639390-0x00000001806393A0
	}
}
