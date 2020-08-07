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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Platforms.PS4
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal sealed class PS4InputSource : CustomInputSource, IControllerAssigner // TypeDefIndex: 6825
	{
		// Fields
		private bVdLitkJwIkMtgpGEhlltNcDAVtB KKgGBnvVPIHKLeoEiDFMVEWiQgg; // 0x48
		private bool oNOIeYMKHAHgxzxbeCSiMiBWGly; // 0x50
		private bool vEblpmllYIOuQHCXVghuIpihdSG; // 0x51
	
		// Properties
		public override bool isReady { get; } // 0x0000000180380B60-0x0000000180380B70 
		bool IControllerAssigner.enabled { get; set; } // 0x0000000180379EC0-0x0000000180379ED0 0x000000018047A1C0-0x000000018047A1D0
	
		// Nested types
		private class bVdLitkJwIkMtgpGEhlltNcDAVtB // TypeDefIndex: 6826
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
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<gJimgVEtEKjjtBghbyfHMHtAltx> SoptGiBIwpEzOTmBujKpoVBsSer; // 0x00
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<gJimgVEtEKjjtBghbyfHMHtAltx> AGoLVphFiYSQJEBguHfxHhzJytur; // 0x08
	
			// Events
			public event Action<amDVRclcdlhHlNBNMFAuxkaDfvL> otSrWzRexeFOjkthPDUVyKctLKV {
				add; // 0x0000000180EB88E0-0x0000000180EB89B0
				remove; // 0x0000000180EB8B10-0x0000000180EB8C00
			}
			public event Action<QUohiajXjNgRguTFzwsChJokNwo> XwQJpVrFTBzrglJROxGzUiOThmr {
				add; // 0x0000000180EB89B0-0x0000000180EB8A50
				remove; // 0x0000000180EB8C00-0x0000000180EB8CE0
			}
	
			// Nested types
			public struct amDVRclcdlhHlNBNMFAuxkaDfvL // TypeDefIndex: 6827
			{
				// Fields
				public int yqGgGVbZkMCNTIxfuiHTVgIqHCJ; // 0x00
				public int UWBFQEfrTnYUCjshCYfdJplmoOOm; // 0x04
				public int bdmIEaEbgsJTwdQWVXeQWkyhpqFe; // 0x08
				public bool STsORkqoVwmWsWAMVLhuWNzKAJj; // 0x0C
	
				// Constructors
				public amDVRclcdlhHlNBNMFAuxkaDfvL(int playerId, int handle, int deviceClass, bool isSpecialController); // 0x00000001800A4D10-0x00000001800A4DC0
			}
	
			public struct QUohiajXjNgRguTFzwsChJokNwo // TypeDefIndex: 6828
			{
				// Fields
				public int yqGgGVbZkMCNTIxfuiHTVgIqHCJ; // 0x00
				public int UWBFQEfrTnYUCjshCYfdJplmoOOm; // 0x04
				public bool STsORkqoVwmWsWAMVLhuWNzKAJj; // 0x08
	
				// Constructors
				public QUohiajXjNgRguTFzwsChJokNwo(int playerId, int handle, bool isSpecialController); // 0x00000001800A4CC0-0x00000001800A4D10
			}
	
			private class gJimgVEtEKjjtBghbyfHMHtAltx // TypeDefIndex: 6829
			{
				// Fields
				public readonly bool STsORkqoVwmWsWAMVLhuWNzKAJj; // 0x10
				public bool hvZFJvCsezEBoyduXJlPDonRVQP; // 0x11
				public int UWBFQEfrTnYUCjshCYfdJplmoOOm; // 0x14
				public int bdmIEaEbgsJTwdQWVXeQWkyhpqFe; // 0x18
	
				// Constructors
				public gJimgVEtEKjjtBghbyfHMHtAltx(bool isSpecialController); // 0x0000000180EB9C00-0x0000000180EB9C40
	
				// Methods
				public iOffFQkOuXzkNBIpmUecQVQqSVLS KkJiNfHDfiJwfwbJJdnbTpAKFxkf(bool param_0000e739, int param_0000e73a, int param_0000e73b); // 0x0000000180EB9B30-0x0000000180EB9C00
				private void vMfAexzdpfzhXKkyGdAHmJVnQEr(); // 0x0000000180EB9C40-0x0000000180EB9C50
			}
	
			[Flags] // 0x00000001801CDAD0-0x00000001801CDAE0
			private enum iOffFQkOuXzkNBIpmUecQVQqSVLS // TypeDefIndex: 6830
			{
				PoBZZNoYGVGuWkUBxQqhGBhFqWy = 0,
				MuvJHvZGEoEJPiVlttEMQktXAcqj = 1,
				tzmAMoABfcLEwMCWeFSzgCQDVbI = 2,
				qQucigIhMiBUrHzLuPJvduaBobf = 4
			}
	
			// Constructors
			public bVdLitkJwIkMtgpGEhlltNcDAVtB(int maxPlayers, bool supportSpecialControllers); // 0x0000000180EB86C0-0x0000000180EB88E0
	
			// Methods
			public void MrPMknIMZzaXDjcXZFUzCeTcWDAs(); // 0x0000000180EB7890-0x0000000180EB83A0
			private void UtGfmFMhxafSIjqIPBQMfvpUQDKu(int param_0000e72d, gJimgVEtEKjjtBghbyfHMHtAltx param_0000e72e, int param_0000e72f, bool param_0000e730); // 0x0000000180EB83A0-0x0000000180EB86C0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static gJimgVEtEKjjtBghbyfHMHtAltx pOcCcEPETYfiVgcsLGAPfcnitqGJ(); // 0x0000000180EB8AB0-0x0000000180EB8B10
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static gJimgVEtEKjjtBghbyfHMHtAltx nKBfZOoSRNcWGVmXsGDbjHqfeFdg(); // 0x0000000180EB8A50-0x0000000180EB8AB0
		}
	
		private abstract class meaDvZLdTStMzqDmUtkldoXVBFq : CustomInputSource.Joystick, IPS4ControllerExtensionSource // TypeDefIndex: 6831
		{
			// Fields
			public const bool NxiTYncgJCKPdSFDMzEERQuieof = true; // Metadata: 0x00765EA7
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
			private static int oUnPkmyGsXCbUrBRISmROqOzVyR { get; } // 0x0000000180EBD1C0-0x0000000180EBD220 
			protected LoggedInUser jFcgNPgLNoHPNaHdtdgwroqnnJh { get; } // 0x0000000180EBD220-0x0000000180EBD320 
			public ControllerType JmvHHQieRmxAYahCfvzgQBWHgSne { get; } // 0x0000000180476030-0x0000000180476040 
			public int yqGgGVbZkMCNTIxfuiHTVgIqHCJ { get; } // 0x00000001804B4700-0x00000001804B4710 
			public int UWBFQEfrTnYUCjshCYfdJplmoOOm { get; } // 0x00000001804428A0-0x00000001804428B0 
			public bool STsORkqoVwmWsWAMVLhuWNzKAJj { get; } // 0x0000000180453D00-0x0000000180453D10 
			private bool BSWZxPQiWxBhGncxrWjXxmTWBcOd { get; } // 0x0000000180EBD170-0x0000000180EBD1C0 
			public int zGdbUshTycKAtYCpVcJXKunoKXo { get; } // 0x0000000180EBD320-0x0000000180EBD340 
	
			// Nested types
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			public enum ControllerType // TypeDefIndex: 6832
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
	
			protected enum RdBLmZZaUnqkUJwfsSPLBCRwHRe // TypeDefIndex: 6833
			{
				IjuFlluoMybUtpSqFtBQAlMgUyR = 0,
				NmKtZgJGKXhhdAwkHccPjmHfhnk = 1,
				xeXPypynNGxwlFuyHbzDZbmdEHH = 2
			}
	
			public class tQdmWIvYpLTtWCLOpumBTXPfGCC // TypeDefIndex: 6834
			{
				// Fields
				public readonly int RweyBZyAAIjbTgpvgIOlbybhzioP; // 0x10
				public readonly int QsBvetqPHrzKthaGEErdieSJgIkd; // 0x14
				public readonly float HweParDwxxcsTfyepGGaAhkTWgF; // 0x18
				public readonly int zGdbUshTycKAtYCpVcJXKunoKXo; // 0x1C
				public readonly int NvkUvSVhegrIiySWCTpxvOgoaTSa; // 0x20
	
				// Constructors
				public tQdmWIvYpLTtWCLOpumBTXPfGCC(int axisCount, int buttonCount, float dpadDeadzone, int vibrationMotorCount, int maxTouches); // 0x0000000180EBE4E0-0x0000000180EBE540
			}
	
			// Constructors
			protected meaDvZLdTStMzqDmUtkldoXVBFq(ControllerType type, string name, int playerId, int unityJoystickId, int handle, tQdmWIvYpLTtWCLOpumBTXPfGCC capabilities); // 0x0000000180EBC070-0x0000000180EBD140
			static meaDvZLdTStMzqDmUtkldoXVBFq(); // 0x00000001803774A0-0x00000001803774B0
	
			// Methods
			public static meaDvZLdTStMzqDmUtkldoXVBFq AQMpZVIIXTyemnHtIDPtxhINdLN(ControllerType param_0000e73c, int param_0000e73d, int param_0000e73e); // 0x0000000180EBA210-0x0000000180EBA390
			public static meaDvZLdTStMzqDmUtkldoXVBFq AQMpZVIIXTyemnHtIDPtxhINdLN(bool param_0000e73f, int param_0000e740, int param_0000e741, int param_0000e742); // 0x0000000180EBA170-0x0000000180EBA210
			public override void Update(); // 0x0000000180EBBE70-0x0000000180EBBE90
			public int GetUserId(); // 0x0000000180EBAC00-0x0000000180EBAC20
			public int GetUserStatus(); // 0x0000000180EBAC60-0x0000000180EBAC80
			public bool GetUserIsPrimary(); // 0x0000000180EBAC20-0x0000000180EBAC40
			public Color GetUserColor(); // 0x0000000180EBAB50-0x0000000180EBAC00
			public int GetUserColorId(); // 0x0000000180EBAB30-0x0000000180EBAB50
			public string GetUserName(); // 0x0000000180EBAC40-0x0000000180EBAC60
			public void StopVibration(); // 0x0000000180EBAFC0-0x0000000180EBB000
			public void SetVibration(int param_0000e749, float param_0000e74a); // 0x0000000180EBAF20-0x0000000180EBAFC0
			public float GetVibration(int param_0000e74b); // 0x0000000180EBAC80-0x0000000180EBACE0
			public void SetMotionSensorState(bool param_0000e74c); // 0x0000000180EBAE60-0x0000000180EBAEC0
			public void SetTiltCorrectionState(bool param_0000e74d); // 0x0000000180EBAEC0-0x0000000180EBAF20
			public void SetAngularVelocityDeadbandState(bool param_0000e74e); // 0x0000000180EBAD80-0x0000000180EBADE0
			public void ResetOrientation(); // 0x0000000180EBAD30-0x0000000180EBAD80
			public Vector3 GetLastAcceleration(); // 0x0000000180EBA4C0-0x0000000180EBA690
			public Vector3 GetLastAccelerationRaw(); // 0x0000000180EBA3C0-0x0000000180EBA4C0
			public Vector3 GetLastGyro(); // 0x0000000180EBA790-0x0000000180EBA8E0
			public Vector3 GetLastGyroRaw(); // 0x0000000180EBA690-0x0000000180EBA790
			public Quaternion GetLastOrientation(); // 0x0000000180EBAA00-0x0000000180EBAB30
			public Quaternion GetLastOrientationRaw(); // 0x0000000180EBA8E0-0x0000000180EBAA00
			public void SetLightColor(int param_0000e74f, int param_0000e750, int param_0000e751); // 0x0000000180EBADE0-0x0000000180EBAE60
			public void ResetLight(); // 0x0000000180EBACE0-0x0000000180EBAD30
			protected virtual void UpdateElementValues(); // 0x0000000180EBB000-0x0000000180EBBE70
			protected void YIJmswKDRGGwbeMwDPctrpFlaCfB(); // 0x0000000180EBBE90-0x0000000180EBC070
			protected static int EiFnhVyRTjWqpJdPQkRqjBgOfCtJ(float param_0000e752); // 0x0000000180EBA390-0x0000000180EBA3C0
			protected static void wMNgJRrudGAWubGHyAWxyCZGiRK(ref Vector3 param_0000e753); // 0x0000000180EBD140-0x0000000180EBD170
			protected static void cXLjRmmfCEMdyWhIZBaghglIYrM(ref Vector3 param_0000e754); // 0x0000000180EBD140-0x0000000180EBD170
			protected static bool pPraApegcHjBgTMNFkMziqCEubU(int param_0000e755, out ControllerType param_0000e756); // 0x0000000180EBD340-0x0000000180EBD6D0
		}
	
		private sealed class fEnDRSNGvhiPWyEueacdxsgliKZD : meaDvZLdTStMzqDmUtkldoXVBFq, IPS4GamepadExtensionSource // TypeDefIndex: 6835
		{
			// Fields
			private const int mcagbMPDbZbuDLVSXAdSGosiwJk = 6; // Metadata: 0x00765EE4
			private const int yPnzCDCUouValTYijrIjZkOzBoi = 14; // Metadata: 0x00765EE8
			private const float swbSgarzlrGRoFvCfYeRBWtvXGW = 0.05f; // Metadata: 0x00765EEC
			private const int iKKGYPMEeUBIYTaUvEXNQCRNdYp = 2; // Metadata: 0x00765EF0
			private const int YTmtiWsooyXPPDNxOuSQfjMYCjb = 2; // Metadata: 0x00765EF4
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
			public int NvkUvSVhegrIiySWCTpxvOgoaTSa { get; } // 0x0000000180EB9B10-0x0000000180EB9B30 
	
			// Constructors
			public fEnDRSNGvhiPWyEueacdxsgliKZD(string name, int playerId, int unityJoystickId, int handle); // 0x0000000180EB97E0-0x0000000180EB98F0
	
			// Methods
			public int GetConnectionType(); // 0x0000000180DBB690-0x0000000180DBB6A0
			public int GetAnalogDeadZoneLeft(); // 0x0000000180EB8CE0-0x0000000180EB8CF0
			public int GetAnalogDeadZoneRight(); // 0x0000000180DBB680-0x0000000180DBB690
			public float GetTouchPixelDensity(); // 0x000000018058CA30-0x000000018058CA40
			public int GetTouchpadResolutionX(); // 0x0000000180491490-0x00000001804914A0
			public int GetTouchpadResolutionY(); // 0x0000000180EB94A0-0x0000000180EB94B0
			public int GetTouchCount(); // 0x000000018057C3B0-0x000000018057C3C0
			public int GetTouchId(int param_0000e760); // 0x0000000180EB8CF0-0x0000000180EB8D40
			public bool GetTouchPositionAbsByIndex(int param_0000e761, out Vector2 param_0000e762); // 0x0000000180EB8D40-0x0000000180EB8E80
			public bool GetTouchPositionAbsByTouchId(int param_0000e763, out Vector2 param_0000e764); // 0x0000000180EB8E80-0x0000000180EB9060
			public bool GetTouchPositionByIndex(int param_0000e765, out Vector2 param_0000e766); // 0x0000000180EB9060-0x0000000180EB9240
			public bool GetTouchPositionByTouchId(int param_0000e767, out Vector2 param_0000e768); // 0x0000000180EB9240-0x0000000180EB94A0
			public bool IsTouchingByIndex(int param_0000e769); // 0x0000000180EB94B0-0x0000000180EB9510
			public bool IsTouchingByTouchId(int param_0000e76a); // 0x0000000180EB9510-0x0000000180EB9590
			protected override void UpdateElementValues(); // 0x0000000180EB9590-0x0000000180EB9780
			private void duLuRPLQXuawkWSRsiMYVvscyVg(); // 0x0000000180EB98F0-0x0000000180EB9B10
			private int UsLXGrvbyhupVWNLGtdNiZcXneC(int param_0000e76b); // 0x0000000180EB9780-0x0000000180EB97E0
		}
	
		private abstract class CknYkuQcoBUbjagcoOrGtIdyKQI : meaDvZLdTStMzqDmUtkldoXVBFq // TypeDefIndex: 6836
		{
			// Constructors
			protected CknYkuQcoBUbjagcoOrGtIdyKQI(ControllerType controllerType, string name, int playerId, int unityJoystickId, int handle, tQdmWIvYpLTtWCLOpumBTXPfGCC capabilities); // 0x0000000180E9E7C0-0x0000000180E9E850
	
			// Methods
			public static CknYkuQcoBUbjagcoOrGtIdyKQI AQMpZVIIXTyemnHtIDPtxhINdLN(int param_0000e772, int param_0000e773, int param_0000e774); // 0x0000000180E9E310-0x0000000180E9E7C0
			public static new CknYkuQcoBUbjagcoOrGtIdyKQI AQMpZVIIXTyemnHtIDPtxhINdLN(ControllerType param_0000e775, int param_0000e776, int param_0000e777); // 0x0000000180E9DE60-0x0000000180E9E310
		}
	
		private sealed class YsLdaqHZYDISWmrMuFxZJmPjYif : CknYkuQcoBUbjagcoOrGtIdyKQI // TypeDefIndex: 6837
		{
			// Fields
			private const int mcagbMPDbZbuDLVSXAdSGosiwJk = 13; // Metadata: 0x00765EF8
			private const int yPnzCDCUouValTYijrIjZkOzBoi = 14; // Metadata: 0x00765EFC
			private const float swbSgarzlrGRoFvCfYeRBWtvXGW = 0.05f; // Metadata: 0x00765F00
			private const int iKKGYPMEeUBIYTaUvEXNQCRNdYp = 2; // Metadata: 0x00765F04
			private const int YTmtiWsooyXPPDNxOuSQfjMYCjb = 0; // Metadata: 0x00765F08
	
			// Constructors
			public YsLdaqHZYDISWmrMuFxZJmPjYif(string name, int playerId, int unityJoystickId, int handle); // 0x0000000180EB7770-0x0000000180EB7890
	
			// Methods
			protected override void UpdateElementValues(); // 0x0000000180EB71F0-0x0000000180EB7770
		}
	
		private sealed class lWkOlHrPyWcPVJxrdRpstuTftvDD : CknYkuQcoBUbjagcoOrGtIdyKQI // TypeDefIndex: 6838
		{
			// Fields
			private const int mcagbMPDbZbuDLVSXAdSGosiwJk = 11; // Metadata: 0x00765F0C
			private const int yPnzCDCUouValTYijrIjZkOzBoi = 14; // Metadata: 0x00765F10
			private const float swbSgarzlrGRoFvCfYeRBWtvXGW = 0.05f; // Metadata: 0x00765F14
			private const int iKKGYPMEeUBIYTaUvEXNQCRNdYp = 2; // Metadata: 0x00765F18
			private const int YTmtiWsooyXPPDNxOuSQfjMYCjb = 0; // Metadata: 0x00765F1C
	
			// Constructors
			public lWkOlHrPyWcPVJxrdRpstuTftvDD(string name, int playerId, int unityJoystickId, int handle); // 0x0000000180EBA050-0x0000000180EBA170
	
			// Methods
			protected override void UpdateElementValues(); // 0x0000000180EB9C50-0x0000000180EBA050
		}
	
		private sealed class rzNYMZYIQsNEVTaFRYgqLRGRoq : CknYkuQcoBUbjagcoOrGtIdyKQI // TypeDefIndex: 6839
		{
			// Fields
			private const int mcagbMPDbZbuDLVSXAdSGosiwJk = 13; // Metadata: 0x00765F20
			private const int yPnzCDCUouValTYijrIjZkOzBoi = 14; // Metadata: 0x00765F24
			private const float swbSgarzlrGRoFvCfYeRBWtvXGW = 0.05f; // Metadata: 0x00765F28
			private const int iKKGYPMEeUBIYTaUvEXNQCRNdYp = 2; // Metadata: 0x00765F2C
			private const int YTmtiWsooyXPPDNxOuSQfjMYCjb = 0; // Metadata: 0x00765F30
	
			// Constructors
			public rzNYMZYIQsNEVTaFRYgqLRGRoq(string name, int playerId, int unityJoystickId, int handle); // 0x0000000180EBE3C0-0x0000000180EBE4E0
	
			// Methods
			protected override void UpdateElementValues(); // 0x0000000180EBDDE0-0x0000000180EBE3C0
		}
	
		private sealed class rCMtaRpoIOPIugppYzJiTIEyDeF : CknYkuQcoBUbjagcoOrGtIdyKQI // TypeDefIndex: 6840
		{
			// Fields
			private const int mcagbMPDbZbuDLVSXAdSGosiwJk = 16; // Metadata: 0x00765F34
			private const int yPnzCDCUouValTYijrIjZkOzBoi = 14; // Metadata: 0x00765F38
			private const float swbSgarzlrGRoFvCfYeRBWtvXGW = 0.05f; // Metadata: 0x00765F3C
			private const int iKKGYPMEeUBIYTaUvEXNQCRNdYp = 2; // Metadata: 0x00765F40
			private const int YTmtiWsooyXPPDNxOuSQfjMYCjb = 0; // Metadata: 0x00765F44
	
			// Constructors
			public rCMtaRpoIOPIugppYzJiTIEyDeF(string name, int playerId, int unityJoystickId, int handle); // 0x0000000180EBDCC0-0x0000000180EBDDE0
	
			// Methods
			protected override void UpdateElementValues(); // 0x0000000180EBD6D0-0x0000000180EBDCC0
		}
	
		// Constructors
		public PS4InputSource(); // 0x0000000180EB16B0-0x0000000180EB1C10
	
		// Methods
		public override void Update(); // 0x0000000180EB15A0-0x0000000180EB16B0
		private static int rLVmTOqNErjHkWyUpBjrFOoWFIpH(int param_0000e71d); // 0x0000000180EB1C10-0x0000000180EB1C20
		private void GdRcCOFmVZAjFbwjBuCgYQywFWCa(bVdLitkJwIkMtgpGEhlltNcDAVtB.amDVRclcdlhHlNBNMFAuxkaDfvL param_0000e71e); // 0x0000000180EB0F40-0x0000000180EB1180
		private void tIwuLieLNiScUkipWTuUyLaZXHX(meaDvZLdTStMzqDmUtkldoXVBFq param_0000e71f); // 0x0000000180EB1C20-0x0000000180EB1D10
		private void DzWNUjqlJPmrsXCgJElPACZumzA(bVdLitkJwIkMtgpGEhlltNcDAVtB.QUohiajXjNgRguTFzwsChJokNwo param_0000e720); // 0x0000000180EB0B80-0x0000000180EB0EA0
		bool IControllerAssigner.CanHandleAssignment(ControllerType param_0000e722, Controller param_0000e723); // 0x0000000180EB1520-0x0000000180EB15A0
		void IControllerAssigner.AssignController(ControllerType param_0000e724, Controller param_0000e725); // 0x0000000180EB1180-0x0000000180EB1520
		~PS4InputSource(); // 0x0000000180EB0EA0-0x0000000180EB0F40
		protected override void Dispose(bool disposing); // 0x0000000180EB0B70-0x0000000180EB0B80
	}
}
