/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ThisOtherThing.UI
{
	public class GeoUtils // TypeDefIndex: 14609
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
		public class ShapeProperties // TypeDefIndex: 14610
		{
			// Fields
			public Color32 FillColor; // 0x10
	
			// Constructors
			public ShapeProperties(); // 0x00000001809571D0-0x0000000180957220
		}
	
		[Serializable]
		public class OutlineShapeProperties : ShapeProperties // TypeDefIndex: 14611
		{
			// Fields
			public bool DrawFill; // 0x18
			public bool DrawFillShadow; // 0x19
			public bool DrawOutline; // 0x1A
			public Color32 OutlineColor; // 0x1C
			public bool DrawOutlineShadow; // 0x20
	
			// Constructors
			public OutlineShapeProperties(); // 0x0000000180956BF0-0x0000000180956C70
		}
	
		[Serializable]
		public class AntiAliasingProperties // TypeDefIndex: 14612
		{
			// Fields
			public float AntiAliasing; // 0x10
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private float <Adjusted>k__BackingField; // 0x14
	
			// Properties
			public float Adjusted { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018094A320-0x000000018094A330 0x000000018094A330-0x000000018094A340
	
			// Constructors
			public AntiAliasingProperties(); // 0x000000018094A310-0x000000018094A320
	
			// Methods
			public void UpdateAdjusted(Canvas canvas); // 0x000000018094A260-0x000000018094A310
			public void OnCheck(); // 0x000000018094A1F0-0x000000018094A260
		}
	
		[Serializable]
		public class RoundingProperties // TypeDefIndex: 14613
		{
			// Fields
			public ResolutionType Resolution; // 0x10
			[Min] // 0x000000018027F910-0x000000018027F930
			public int FixedResolution; // 0x14
			[Min] // 0x000000018027FD50-0x000000018027FD70
			public float ResolutionMaxDistance; // 0x18
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private int <AdjustedResolution>k__BackingField; // 0x1C
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private bool <MakeSharpCorner>k__BackingField; // 0x20
	
			// Properties
			public int AdjustedResolution { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803FB770-0x00000001803FB780 0x000000018042D0F0-0x000000018042D100
			public bool MakeSharpCorner { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803FA090-0x00000001803FA0A0 0x00000001803FA0B0-0x00000001803FA0C0
	
			// Nested types
			public enum ResolutionType // TypeDefIndex: 14614
			{
				Calculated = 0,
				Fixed = 1
			}
	
			// Constructors
			public RoundingProperties(); // 0x0000000180956F10-0x0000000180956F30
	
			// Methods
			public void OnCheck(int minFixedResolution = 2 /* Metadata: 0x007BAD63 */); // 0x0000000180956C70-0x0000000180956D00
			public void UpdateAdjusted(float radius, float offset, float numCorners); // 0x0000000180956E10-0x0000000180956F10
			public void UpdateAdjusted(float radius, float offset, RoundingProperties overrideProperties, float numCorners); // 0x0000000180956D00-0x0000000180956E10
		}
	
		[Serializable]
		public class OutlineProperties // TypeDefIndex: 14615
		{
			// Fields
			public LineType Type; // 0x10
			public float LineWeight; // 0x14
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private float <HalfLineWeight>k__BackingField; // 0x18
	
			// Properties
			public float HalfLineWeight { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018049DFC0-0x000000018049DFD0 0x0000000180956BE0-0x0000000180956BF0
	
			// Nested types
			public enum LineType // TypeDefIndex: 14616
			{
				Inner = 0,
				Center = 1,
				Outer = 2
			}
	
			// Constructors
			public OutlineProperties(); // 0x0000000180956BC0-0x0000000180956BE0
	
			// Methods
			public float GetOuterDistace(); // 0x0000000180956AA0-0x0000000180956B30
			public float GetCenterDistace(); // 0x0000000180956980-0x0000000180956A10
			public float GetInnerDistace(); // 0x0000000180956A10-0x0000000180956AA0
			public void OnCheck(); // 0x0000000180956B30-0x0000000180956BA0
			public void UpdateAdjusted(); // 0x0000000180956BA0-0x0000000180956BC0
		}
	
		[Serializable]
		public class ShadowsProperties // TypeDefIndex: 14617
		{
			// Fields
			public bool ShowShape; // 0x10
			public bool ShowShadows; // 0x11
			[Range] // 0x0000000180244630-0x0000000180244650
			public float Angle; // 0x14
			[Min] // 0x0000000180280980-0x00000001802809A0
			public float Distance; // 0x18
			public ShadowProperties[] Shadows; // 0x20
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Vector2 Offset; // 0x28
	
			// Properties
			public bool ShadowsEnabled { get; } // 0x00000001809571B0-0x00000001809571D0 
	
			// Constructors
			public ShadowsProperties(); // 0x0000000180957130-0x00000001809571B0
	
			// Methods
			public void UpdateAdjusted(); // 0x0000000180957090-0x0000000180957130
			public Vector2 GetCenterOffset(Vector2 center, int index); // 0x0000000180956FE0-0x0000000180957090
		}
	
		[Serializable]
		public class ShadowProperties // TypeDefIndex: 14618
		{
			// Fields
			public Color32 Color; // 0x10
			public Vector2 Offset; // 0x14
			[Min] // 0x0000000180280980-0x00000001802809A0
			public float Size; // 0x1C
			[Range] // 0x00000001801D3630-0x00000001801D3650
			public float Softness; // 0x20
	
			// Constructors
			public ShadowProperties(); // 0x0000000180956F30-0x0000000180956FE0
		}
	
		public struct EdgeGradientData // TypeDefIndex: 14619
		{
			// Fields
			public bool IsActive; // 0x00
			public float InnerScale; // 0x04
			public float ShadowOffset; // 0x08
			public float SizeAdd; // 0x0C
	
			// Methods
			public void SetActiveData(float innerScale, float shadowOffset, float sizeAdd); // 0x0000000180026EC0-0x0000000180027240
			public void Reset(); // 0x0000000180026EA0-0x0000000180026EC0
		}
	
		[Serializable]
		public class SnappedPositionAndOrientationProperties // TypeDefIndex: 14620
		{
			// Fields
			public OrientationTypes Orientation; // 0x10
			public PositionTypes Position; // 0x14
	
			// Nested types
			public enum OrientationTypes // TypeDefIndex: 14621
			{
				Horizontal = 0,
				Vertical = 1
			}
	
			public enum PositionTypes // TypeDefIndex: 14622
			{
				Center = 0,
				Top = 1,
				Bottom = 2,
				Left = 3,
				Right = 4
			}
	
			// Constructors
			public SnappedPositionAndOrientationProperties(); // 0x0000000180373240-0x0000000180373250
		}
	
		public struct UnitPositionData // TypeDefIndex: 14623
		{
			// Fields
			public Vector3[] UnitPositions; // 0x00
			public float LastBaseAngle; // 0x08
			public float LastDirection; // 0x0C
		}
	
		// Constructors
		public GeoUtils(); // 0x0000000180373240-0x0000000180373250
		static GeoUtils(); // 0x0000000180951720-0x0000000180951920
	
		// Methods
		public static float GetAdjustedAntiAliasing(Canvas canvas, float antiAliasing); // 0x0000000180951110-0x0000000180951150
		public static void AddOffset(ref float width, ref float height, float offset); // 0x00000001809510F0-0x0000000180951110
		public static void SetUnitPositionData(ref UnitPositionData unitPositionData, int resolution, float baseAngle = 0f /* Metadata: 0x007BAD53 */, float direction = 1f /* Metadata: 0x007BAD57 */); // 0x0000000180951250-0x00000001809514F0
		public static void SetUnitPositions(ref Vector2[] positions, int resolution, float angleOffset = 0f /* Metadata: 0x007BAD5B */, float radius = 1f /* Metadata: 0x007BAD5F */); // 0x00000001809514F0-0x0000000180951700
		public static float RadianAngleDifference(float angle1, float angle2); // 0x0000000180951170-0x0000000180951250
		public static int SimpleMap(int x, int in_max, int out_max); // 0x0000000180951700-0x0000000180951710
		public static float SimpleMap(float x, float in_max, float out_max); // 0x0000000180951710-0x0000000180951720
		public static float Map(float x, float in_min, float in_max, float out_min, float out_max); // 0x0000000180951150-0x0000000180951170
	}
}
