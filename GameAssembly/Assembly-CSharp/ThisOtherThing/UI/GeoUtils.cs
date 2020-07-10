/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ThisOtherThing.UI
{
	public class GeoUtils // TypeDefIndex: 13941
	{
		// Fields
		public static readonly Vector3 UpV3; // 0x00
		public static readonly Vector3 DownV3; // 0x0C
		public static readonly Vector3 LeftV3; // 0x18
		public static readonly Vector3 RightV3; // 0x24
		public static readonly Vector3 ZeroV3; // 0x30
		public static readonly Vector2 ZeroV2; // 0x3C
		public static readonly Vector3 UINormal; // 0x44
		public static readonly Vector4 UITangent; // 0x50
		public static readonly float HalfPI; // 0x60
		public static readonly float TwoPI; // 0x64
	
		// Nested types
		[Serializable]
		public class ShapeProperties // TypeDefIndex: 13942
		{
			// Fields
			public Color32 FillColor; // 0x10
	
			// Constructors
			public ShapeProperties(); // 0x0000000181202860-0x00000001812028B0
		}
	
		[Serializable]
		public class OutlineShapeProperties : ShapeProperties // TypeDefIndex: 13943
		{
			// Fields
			public bool DrawFill; // 0x18
			public bool DrawFillShadow; // 0x19
			public bool DrawOutline; // 0x1A
			public Color32 OutlineColor; // 0x1C
			public bool DrawOutlineShadow; // 0x20
	
			// Constructors
			public OutlineShapeProperties(); // 0x0000000181201350-0x00000001812013D0
		}
	
		[Serializable]
		public class AntiAliasingProperties // TypeDefIndex: 13944
		{
			// Fields
			public float AntiAliasing; // 0x10
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private float <Adjusted>k__BackingField; // 0x14
	
			// Properties
			public float Adjusted { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018048F530-0x000000018048F540 0x00000001805C1F50-0x00000001805C1F60
	
			// Constructors
			public AntiAliasingProperties(); // 0x00000001811F7150-0x00000001811F7160
	
			// Methods
			public void UpdateAdjusted(Canvas canvas); // 0x00000001811F7090-0x00000001811F7150
			public void OnCheck(); // 0x00000001811F7020-0x00000001811F7090
		}
	
		[Serializable]
		public class RoundingProperties // TypeDefIndex: 13945
		{
			// Fields
			public ResolutionType Resolution; // 0x10
			[Min] // 0x00000001801520C0-0x00000001801520E0
			public int FixedResolution; // 0x14
			[Min] // 0x0000000180152240-0x0000000180152260
			public float ResolutionMaxDistance; // 0x18
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private int <AdjustedResolution>k__BackingField; // 0x1C
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private bool <MakeSharpCorner>k__BackingField; // 0x20
	
			// Properties
			public int AdjustedResolution { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018037E420-0x000000018037E430 0x000000018037E600-0x000000018037E610
			public bool MakeSharpCorner { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803C19E0-0x00000001803C19F0 0x00000001804231D0-0x00000001804231E0
	
			// Nested types
			public enum ResolutionType // TypeDefIndex: 13946
			{
				Calculated = 0,
				Fixed = 1
			}
	
			// Constructors
			public RoundingProperties(); // 0x00000001812025A0-0x00000001812025C0
	
			// Methods
			public void OnCheck(int minFixedResolution = 2 /* Metadata: 0x007842A0 */); // 0x0000000181202300-0x0000000181202390
			public void UpdateAdjusted(float radius, float offset, float numCorners); // 0x00000001812024A0-0x00000001812025A0
			public void UpdateAdjusted(float radius, float offset, RoundingProperties overrideProperties, float numCorners); // 0x0000000181202390-0x00000001812024A0
		}
	
		[Serializable]
		public class OutlineProperties // TypeDefIndex: 13947
		{
			// Fields
			public LineType Type; // 0x10
			public float LineWeight; // 0x14
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private float <HalfLineWeight>k__BackingField; // 0x18
	
			// Properties
			public float HalfLineWeight { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001805D9080-0x00000001805D9090 0x00000001805D90C0-0x00000001805D90D0
	
			// Nested types
			public enum LineType // TypeDefIndex: 13948
			{
				Inner = 0,
				Center = 1,
				Outer = 2
			}
	
			// Constructors
			public OutlineProperties(); // 0x0000000181201330-0x0000000181201350
	
			// Methods
			public float GetOuterDistace(); // 0x0000000181201210-0x00000001812012A0
			public float GetCenterDistace(); // 0x00000001812010F0-0x0000000181201180
			public float GetInnerDistace(); // 0x0000000181201180-0x0000000181201210
			public void OnCheck(); // 0x00000001812012A0-0x0000000181201310
			public void UpdateAdjusted(); // 0x0000000181201310-0x0000000181201330
		}
	
		[Serializable]
		public class ShadowsProperties // TypeDefIndex: 13949
		{
			// Fields
			public bool ShowShape; // 0x10
			public bool ShowShadows; // 0x11
			[Range] // 0x000000018010CDC0-0x000000018010CDE0
			public float Angle; // 0x14
			[Min] // 0x0000000180153690-0x00000001801536B0
			public float Distance; // 0x18
			public ShadowProperties[] Shadows; // 0x20
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Vector2 Offset; // 0x28
	
			// Properties
			public bool ShadowsEnabled { get; } // 0x0000000181202840-0x0000000181202860 
	
			// Constructors
			public ShadowsProperties(); // 0x00000001812027C0-0x0000000181202840
	
			// Methods
			public void UpdateAdjusted(); // 0x0000000181202720-0x00000001812027C0
			public Vector2 GetCenterOffset(Vector2 center, int index); // 0x0000000181202670-0x0000000181202720
		}
	
		[Serializable]
		public class ShadowProperties // TypeDefIndex: 13950
		{
			// Fields
			public Color32 Color; // 0x10
			public Vector2 Offset; // 0x14
			[Min] // 0x0000000180153690-0x00000001801536B0
			public float Size; // 0x1C
			[Range] // 0x00000001800C20E0-0x00000001800C2100
			public float Softness; // 0x20
	
			// Constructors
			public ShadowProperties(); // 0x00000001812025C0-0x0000000181202670
		}
	
		public struct EdgeGradientData // TypeDefIndex: 13951
		{
			// Fields
			public bool IsActive; // 0x00
			public float InnerScale; // 0x04
			public float ShadowOffset; // 0x08
			public float SizeAdd; // 0x0C
	
			// Methods
			public void SetActiveData(float innerScale, float shadowOffset, float sizeAdd); // 0x000000018020EA20-0x000000018020EBB0
			public void Reset(); // 0x000000018020EA00-0x000000018020EA20
		}
	
		[Serializable]
		public class SnappedPositionAndOrientationProperties // TypeDefIndex: 13952
		{
			// Fields
			public OrientationTypes Orientation; // 0x10
			public PositionTypes Position; // 0x14
	
			// Nested types
			public enum OrientationTypes // TypeDefIndex: 13953
			{
				Horizontal = 0,
				Vertical = 1
			}
	
			public enum PositionTypes // TypeDefIndex: 13954
			{
				Center = 0,
				Top = 1,
				Bottom = 2,
				Left = 3,
				Right = 4
			}
	
			// Constructors
			public SnappedPositionAndOrientationProperties(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		public struct UnitPositionData // TypeDefIndex: 13955
		{
			// Fields
			public Vector3[] UnitPositions; // 0x00
			public float LastBaseAngle; // 0x08
			public float LastDirection; // 0x0C
		}
	
		// Constructors
		public GeoUtils(); // 0x000000018036B6C0-0x000000018036B6D0
		static GeoUtils(); // 0x0000000181200420-0x0000000181200620
	
		// Methods
		public static float GetAdjustedAntiAliasing(Canvas canvas, float antiAliasing); // 0x00000001811FFDE0-0x00000001811FFE20
		public static void AddOffset(ref float width, ref float height, float offset); // 0x00000001811FFDC0-0x00000001811FFDE0
		public static void SetUnitPositionData(ref UnitPositionData unitPositionData, int resolution, float baseAngle = 0f /* Metadata: 0x00784290 */, float direction = 1f /* Metadata: 0x00784294 */); // 0x00000001811FFF20-0x00000001812001D0
		public static void SetUnitPositions(ref Vector2[] positions, int resolution, float angleOffset = 0f /* Metadata: 0x00784298 */, float radius = 1f /* Metadata: 0x0078429C */); // 0x00000001812001D0-0x0000000181200400
		public static float RadianAngleDifference(float angle1, float angle2); // 0x00000001811FFE40-0x00000001811FFF20
		public static int SimpleMap(int x, int in_max, int out_max); // 0x0000000181200400-0x0000000181200410
		public static float SimpleMap(float x, float in_max, float out_max); // 0x0000000181200410-0x0000000181200420
		public static float Map(float x, float in_min, float in_max, float out_min, float out_max); // 0x00000001811FFE20-0x00000001811FFE40
	}
}
