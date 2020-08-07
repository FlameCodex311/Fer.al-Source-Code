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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public sealed class PlayerMouse : PlayerController, IPlayerMouse, IMouseInputSource // TypeDefIndex: 6175
	{
		// Fields
		internal const bool HQEdndDaFwIwGalojhdRtrhDpwew = true; // Metadata: 0x00764472
		internal const float pWzyrjXxGEoDGbEWiLORWqktbuQ = 1f; // Metadata: 0x00764473
		internal const bool wKCyDIeaoKvbOGmyrUKZlOBsebj = true; // Metadata: 0x00764477
		internal const MovementAreaUnit WMQxPvlljeuHsJVjfTqwcggfryg = MovementAreaUnit.Screen; // Metadata: 0x00764478
		private const int jZRthwHNmPbGwjLfWJZtBeZgLcAa = 3; // Metadata: 0x0076447C
		private const int dnsJJLjtGEVHrnAXHDHcEiatluew = 3; // Metadata: 0x00764480
		internal const string bhrRVluoFFIpaqucZecGDEQQySt = "Movement"; // Metadata: 0x00764484
		internal const string CpQDulgkhglxvQGxytDeoJxDBbFb = "Horizontal"; // Metadata: 0x00764490
		internal const string hGlAHideXxDeMONVqVIAsoSniHjP = "Vertical"; // Metadata: 0x0076449E
		internal const string xyuMaMvxrWOlZIbqeLzbnhtWyyE = "Wheel"; // Metadata: 0x007644AA
		internal const string SfMzeGrsYrlcsDSoybYRPAtuJfR = "Wheel Horizontal"; // Metadata: 0x007644B3
		internal const string ZYbhVRtTAAryygNrIrIOWSCBllJ = "Wheel Vertical"; // Metadata: 0x007644C7
		internal const string ITrObforPxvmdtnlnHeKuAHPPuB = "Left Button"; // Metadata: 0x007644D9
		internal const string LMhdOeIljkXnmhuqCNUGPMGQfIkI = "Right Button"; // Metadata: 0x007644E8
		internal const string nHahgWkwqniHjsNcPotUXpLPrwD = "Middle Button"; // Metadata: 0x007644F8
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Predicate<Axis> rMADKvwwlBDxGizQaeqoBdFZwld; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Predicate<Axis> JTCXEGDxEOeUKhqiWcgWTpItzfs; // 0x18
	
		// Properties
		public bool defaultToCenter { get; set; } // 0x0000000180B34F20-0x0000000180B35050 0x0000000180AB93D0-0x0000000180AB93E0
		public ScreenRect movementArea { get; set; } // 0x0000000180B35440-0x0000000180B35580 0x0000000180B36720-0x0000000180B36730
		public MovementAreaUnit movementAreaUnit { get; set; } // 0x0000000180B35310-0x0000000180B35440 0x0000000180479300-0x0000000180479310
		public Vector2 screenPosition { get; set; } // 0x0000000180B35C00-0x0000000180B35D70 0x0000000180B368B0-0x0000000180B368C0
		public Vector2 screenPositionPrev { get; } // 0x0000000180B35A90-0x0000000180B35C00 
		public Vector2 screenPositionDelta { get; } // 0x0000000180B358B0-0x0000000180B35A90 
		public MouseAxis xAxis { get; } // 0x0000000180B360A0-0x0000000180B362E0 
		public MouseAxis yAxis { get; } // 0x0000000180B362E0-0x0000000180B36510 
		public MouseWheel wheel { get; } // 0x0000000180B35EA0-0x0000000180B360A0 
		public Button leftButton { get; } // 0x0000000180B35050-0x0000000180B351B0 
		public Button rightButton { get; } // 0x0000000180B356B0-0x0000000180B358B0 
		public Button middleButton { get; } // 0x0000000180B351B0-0x0000000180B35310 
		public float pointerSpeed { get; set; } // 0x0000000180B35580-0x0000000180B356B0 0x0000000180B36730-0x0000000180B368B0
		public bool useHardwarePointerPosition { get; set; } // 0x0000000180B35D70-0x0000000180B35EA0 0x0000000180B368C0-0x0000000180B36D10
		bool IMouseInputSource.enabled { get; } // 0x0000000180B33940-0x0000000180B33950 
		Vector2 IMouseInputSource.screenPosition { get; } // 0x0000000180B33970-0x0000000180B33990 
		Vector2 IMouseInputSource.screenPositionDelta { get; } // 0x0000000180B33950-0x0000000180B33970 
		Vector2 IMouseInputSource.wheelDelta { get; } // 0x0000000180B33990-0x0000000180B33A20 
		bool IMouseInputSource.locked { get; } // 0x0000000180380950-0x0000000180380960 
	
		// Events
		public event Action<Vector2> ScreenPositionChangedEvent {
			add; // 0x0000000180B34C40-0x0000000180B34DE0
			remove; // 0x0000000180B36690-0x0000000180B36720
		}
	
		// Nested types
		public sealed class Definition : PlayerController.Definition // TypeDefIndex: 6176
		{
			// Fields
			public bool defaultToCenter; // 0x20
			public ScreenRect movementArea; // 0x24
			public MovementAreaUnit movementAreaUnit; // 0x34
			public float pointerSpeed; // 0x38
			public bool useHardwarePointerPosition; // 0x3C
	
			// Constructors
			internal Definition(); // 0x0000000180B31130-0x0000000180B311C0
		}
	
		public static class Factory // TypeDefIndex: 6177
		{
			// Methods
			public static PlayerMouse Create(); // 0x0000000180B32990-0x0000000180B329A0
			private static PlayerMouse AQMpZVIIXTyemnHtIDPtxhINdLN(int param_0000cecd, int param_0000cece); // 0x0000000180B32310-0x0000000180B32990
			public static PlayerMouse Create(Definition definition); // 0x0000000180B32A00-0x0000000180B32A70
		}
	
		public enum MovementAreaUnit // TypeDefIndex: 6178
		{
			Screen = 0,
			Pixel = 1
		}
	
		// Constructors
		private PlayerMouse(Definition definition); // 0x0000000180B34160-0x0000000180B34C40
		static PlayerMouse(); // 0x0000000180B340F0-0x0000000180B34160
	
		// Methods
		protected override bool Update(UpdateLoopType updateLoop); // 0x0000000180B33AF0-0x0000000180B340F0
		protected override void UpdateFinished(); // 0x0000000180B33A20-0x0000000180B33AF0
		protected override void ClearVars(); // 0x0000000180B33550-0x0000000180B33600
		private void MISqOAxSrCshFXkTwEtcahOKdPm(Vector2 param_0000cec4); // 0x0000000180B33600-0x0000000180B33870
		private ScreenRect iljzZlGLmAUOKxDsrxjuTuLThZm(); // 0x0000000180B36510-0x0000000180B36690
		private void eJVoVTHkzmqGaCNyrmZYueWcdOR(); // 0x0000000180B34E80-0x0000000180B34F20
		private static float BNJbCEbFMkcPsirKMpDxWXzXNbF(Axis param_0000cec5, float param_0000cec6, float param_0000cec7); // 0x0000000180B334F0-0x0000000180B33550
		bool IMouseInputSource.GetButtonDown(int param_0000cec8); // 0x0000000180B33910-0x0000000180B33920
		bool IMouseInputSource.GetButtonUp(int param_0000cec9); // 0x0000000180B33920-0x0000000180B33930
		bool IMouseInputSource.GetButton(int param_0000ceca); // 0x0000000180B33930-0x0000000180B33940
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static bool QCnBhbrcMfEzZgtusefqogRXgSm(Axis param_0000cecb); // 0x0000000180B33870-0x0000000180B33910
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static bool duLhsEnrjkGDDwuCgfSCCWjnKgSn(Axis param_0000cecc); // 0x0000000180B34DE0-0x0000000180B34E80
	}
}
