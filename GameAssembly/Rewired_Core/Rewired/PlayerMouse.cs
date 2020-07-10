/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.UI;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public sealed class PlayerMouse : PlayerController, IPlayerMouse, IMouseInputSource // TypeDefIndex: 6016
	{
		// Fields
		internal const bool HQEdndDaFwIwGalojhdRtrhDpwew = true; // Metadata: 0x0072F7D5
		internal const float pWzyrjXxGEoDGbEWiLORWqktbuQ = 1f; // Metadata: 0x0072F7D6
		internal const bool wKCyDIeaoKvbOGmyrUKZlOBsebj = true; // Metadata: 0x0072F7DA
		internal const MovementAreaUnit WMQxPvlljeuHsJVjfTqwcggfryg = MovementAreaUnit.Screen; // Metadata: 0x0072F7DB
		private const int jZRthwHNmPbGwjLfWJZtBeZgLcAa = 3; // Metadata: 0x0072F7DF
		private const int dnsJJLjtGEVHrnAXHDHcEiatluew = 3; // Metadata: 0x0072F7E3
		internal const string bhrRVluoFFIpaqucZecGDEQQySt = "Movement"; // Metadata: 0x0072F7E7
		internal const string CpQDulgkhglxvQGxytDeoJxDBbFb = "Horizontal"; // Metadata: 0x0072F7F3
		internal const string hGlAHideXxDeMONVqVIAsoSniHjP = "Vertical"; // Metadata: 0x0072F801
		internal const string xyuMaMvxrWOlZIbqeLzbnhtWyyE = "Wheel"; // Metadata: 0x0072F80D
		internal const string SfMzeGrsYrlcsDSoybYRPAtuJfR = "Wheel Horizontal"; // Metadata: 0x0072F816
		internal const string ZYbhVRtTAAryygNrIrIOWSCBllJ = "Wheel Vertical"; // Metadata: 0x0072F82A
		internal const string ITrObforPxvmdtnlnHeKuAHPPuB = "Left Button"; // Metadata: 0x0072F83C
		internal const string LMhdOeIljkXnmhuqCNUGPMGQfIkI = "Right Button"; // Metadata: 0x0072F84B
		internal const string nHahgWkwqniHjsNcPotUXpLPrwD = "Middle Button"; // Metadata: 0x0072F85B
		internal static readonly ScreenRect CTmjDrxvDtpliYHLnxhgZrUIkdX; // 0x00
		private readonly int WJHPpBMvjifwgdCoZMTifXYYins; // 0x70
		private readonly int kFzMbawTeCKeFcOAxCsUgNskFXS; // 0x74
		private readonly int AnYAQApbJsgIGrVrdhgQPaoGhDm; // 0x78
		private readonly int OZXAqZwYQEVqlVygkBCwCKwrMGI; // 0x7C
		private readonly int gGoElrTpWpgCznJFJCvftSLJtVr; // 0x80
		private readonly int zXEcRXvvoWZQtqNVTzlzbjEcRvf; // 0x84
		private bool WdeyosbkusXcbkNfnWGHmcggbVO; // 0x88
		private Vector2 HDQaAcmEDoIpLHXMJBUfBpvFZxyA; // 0x8C
		private Vector2 SUWxlKNudhJjradzfyjDmkAgCsQH; // 0x94
		private Vector2 sTSVgVPBgmimeOUJBMVVVRlUnxR; // 0x9C
		private Vector2 apLCgPXpLiavDogCoiNohrBseCu; // 0xA4
		private Vector2 fzJUoNcFXEknrIcSVeTwCEFdGml; // 0xAC
		private float nZkDILCzWFjEgabZDFOJIIVOfTd; // 0xB4
		private bool cEcHVWQCGOFtUbnEesWwTHElauLz; // 0xB8
		private Action<Vector2> SuEjtWTYBYowuCfRQmgbIzLWlmm; // 0xC0
		private bool PZJqsbAzxtNrotnsYzFzlPBGoDm; // 0xC8
		private ScreenRect MHGNrqcfsqIPlQQZabtbWvefCkr; // 0xCC
		private MovementAreaUnit tRtjTqdAqNYMUnesxaCAhoAikrt; // 0xDC
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Predicate<Axis> rMADKvwwlBDxGizQaeqoBdFZwld; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Predicate<Axis> JTCXEGDxEOeUKhqiWcgWTpItzfs; // 0x18
	
		// Properties
		public bool defaultToCenter { get; set; } // 0x000000018050CD10-0x000000018050CE40 0x00000001804E7C20-0x00000001804E7C30
		public ScreenRect movementArea { get; set; } // 0x000000018050D230-0x000000018050D370 0x000000018050E510-0x000000018050E520
		public MovementAreaUnit movementAreaUnit { get; set; } // 0x000000018050D100-0x000000018050D230 0x00000001804A22D0-0x00000001804A22E0
		public Vector2 screenPosition { get; set; } // 0x000000018050D9F0-0x000000018050DB60 0x000000018050E6A0-0x000000018050E6B0
		public Vector2 screenPositionPrev { get; } // 0x000000018050D880-0x000000018050D9F0 
		public Vector2 screenPositionDelta { get; } // 0x000000018050D6A0-0x000000018050D880 
		public MouseAxis xAxis { get; } // 0x000000018050DE90-0x000000018050E0D0 
		public MouseAxis yAxis { get; } // 0x000000018050E0D0-0x000000018050E300 
		public MouseWheel wheel { get; } // 0x000000018050DC90-0x000000018050DE90 
		public Button leftButton { get; } // 0x000000018050CE40-0x000000018050CFA0 
		public Button rightButton { get; } // 0x000000018050D4A0-0x000000018050D6A0 
		public Button middleButton { get; } // 0x000000018050CFA0-0x000000018050D100 
		public float pointerSpeed { get; set; } // 0x000000018050D370-0x000000018050D4A0 0x000000018050E520-0x000000018050E6A0
		public bool useHardwarePointerPosition { get; set; } // 0x000000018050DB60-0x000000018050DC90 0x000000018050E6B0-0x000000018050EB10
		bool IMouseInputSource.enabled { get; } // 0x000000018050B700-0x000000018050B710 
		Vector2 IMouseInputSource.screenPosition { get; } // 0x000000018050B730-0x000000018050B750 
		Vector2 IMouseInputSource.screenPositionDelta { get; } // 0x000000018050B710-0x000000018050B730 
		Vector2 IMouseInputSource.wheelDelta { get; } // 0x000000018050B750-0x000000018050B7E0 
		bool IMouseInputSource.locked { get; } // 0x00000001803C28F0-0x00000001803C2900 
	
		// Events
		public event Action<Vector2> ScreenPositionChangedEvent {
			add; // 0x000000018050CA30-0x000000018050CBD0
			remove; // 0x000000018050E480-0x000000018050E510
		}
	
		// Nested types
		public sealed class Definition : PlayerController.Definition // TypeDefIndex: 6017
		{
			// Fields
			public bool defaultToCenter; // 0x20
			public ScreenRect movementArea; // 0x24
			public MovementAreaUnit movementAreaUnit; // 0x34
			public float pointerSpeed; // 0x38
			public bool useHardwarePointerPosition; // 0x3C
	
			// Constructors
			internal Definition(); // 0x0000000180508E50-0x0000000180508EE0
		}
	
		public static class Factory // TypeDefIndex: 6018
		{
			// Methods
			public static PlayerMouse Create(); // 0x000000018050A6F0-0x000000018050A700
			private static PlayerMouse AQMpZVIIXTyemnHtIDPtxhINdLN(int param_0000cc5d, int param_0000cc5e); // 0x000000018050A060-0x000000018050A6F0
			public static PlayerMouse Create(Definition definition); // 0x000000018050A760-0x000000018050A7D0
		}
	
		public enum MovementAreaUnit // TypeDefIndex: 6019
		{
			Screen = 0,
			Pixel = 1
		}
	
		// Constructors
		private PlayerMouse(Definition definition); // 0x000000018050BF20-0x000000018050CA30
		static PlayerMouse(); // 0x000000018050BEB0-0x000000018050BF20
	
		// Methods
		protected override bool Update(UpdateLoopType updateLoop); // 0x000000018050B8B0-0x000000018050BEB0
		protected override void UpdateFinished(); // 0x000000018050B7E0-0x000000018050B8B0
		protected override void ClearVars(); // 0x000000018050B310-0x000000018050B3C0
		private void MISqOAxSrCshFXkTwEtcahOKdPm(Vector2 param_0000cc54); // 0x000000018050B3C0-0x000000018050B630
		private ScreenRect iljzZlGLmAUOKxDsrxjuTuLThZm(); // 0x000000018050E300-0x000000018050E480
		private void eJVoVTHkzmqGaCNyrmZYueWcdOR(); // 0x000000018050CC70-0x000000018050CD10
		private static float BNJbCEbFMkcPsirKMpDxWXzXNbF(Axis param_0000cc55, float param_0000cc56, float param_0000cc57); // 0x000000018050B2B0-0x000000018050B310
		bool IMouseInputSource.GetButtonDown(int param_0000cc58); // 0x000000018050B6D0-0x000000018050B6E0
		bool IMouseInputSource.GetButtonUp(int param_0000cc59); // 0x000000018050B6E0-0x000000018050B6F0
		bool IMouseInputSource.GetButton(int param_0000cc5a); // 0x000000018050B6F0-0x000000018050B700
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static bool QCnBhbrcMfEzZgtusefqogRXgSm(Axis param_0000cc5b); // 0x000000018050B630-0x000000018050B6D0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static bool duLhsEnrjkGDDwuCgfSCCWjnKgSn(Axis param_0000cc5c); // 0x000000018050CBD0-0x000000018050CC70
	}
}
