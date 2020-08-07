/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThisOtherThing.UI;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ThisOtherThing.UI.ShapeUtils
{
	public class RoundedRects // TypeDefIndex: 14648
	{
		// Fields
		private static Vector3 tmpV3; // 0x00
		private static Vector3 tmpPos; // 0x0C
		private static Vector2 tmpUV; // 0x18
	
		// Nested types
		public struct RoundedCornerUnitPositionData // TypeDefIndex: 14649
		{
			// Fields
			public Vector2[] TLUnitPositions; // 0x00
			public Vector2[] TRUnitPositions; // 0x08
			public Vector2[] BRUnitPositions; // 0x10
			public Vector2[] BLUnitPositions; // 0x18
		}
	
		[Serializable]
		public class RoundedProperties // TypeDefIndex: 14650
		{
			// Fields
			public RoundedType Type; // 0x10
			public ResolutionType ResolutionMode; // 0x14
			public float UniformRadius; // 0x18
			public bool UseMaxRadius; // 0x1C
			public float TLRadius; // 0x20
			public GeoUtils.RoundingProperties TLResolution; // 0x28
			public float TRRadius; // 0x30
			public GeoUtils.RoundingProperties TRResolution; // 0x38
			public float BRRadius; // 0x40
			public GeoUtils.RoundingProperties BRResolution; // 0x48
			public float BLRadius; // 0x50
			public GeoUtils.RoundingProperties BLResolution; // 0x58
			public GeoUtils.RoundingProperties UniformResolution; // 0x60
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private float <AdjustedTLRadius>k__BackingField; // 0x68
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private float <AdjustedTRRadius>k__BackingField; // 0x6C
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private float <AdjustedBRRadius>k__BackingField; // 0x70
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private float <AdjustedBLRadius>k__BackingField; // 0x74
	
			// Properties
			public float AdjustedTLRadius { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804C5F40-0x00000001804C5F50 0x00000001804C6190-0x00000001804C61A0
			public float AdjustedTRRadius { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804C5F30-0x00000001804C5F40 0x00000001804C6180-0x00000001804C6190
			public float AdjustedBRRadius { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018096DED0-0x000000018096DEE0 0x0000000180F8A060-0x0000000180F8A070
			public float AdjustedBLRadius { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180F8A040-0x0000000180F8A050 0x0000000180F8A050-0x0000000180F8A060
	
			// Nested types
			public enum RoundedType // TypeDefIndex: 14651
			{
				None = 0,
				Uniform = 1,
				Individual = 2
			}
	
			public enum ResolutionType // TypeDefIndex: 14652
			{
				Uniform = 0,
				Individual = 1
			}
	
			// Constructors
			public RoundedProperties(); // 0x0000000180F89F50-0x0000000180F8A040
	
			// Methods
			public void UpdateAdjusted(Rect rect, float offset); // 0x0000000180F89CA0-0x0000000180F89F50
			public void OnCheck(Rect rect); // 0x0000000180F89AC0-0x0000000180F89CA0
		}
	
		// Constructors
		public RoundedRects(); // 0x0000000180373240-0x0000000180373250
		static RoundedRects(); // 0x0000000180F8C9A0-0x0000000180F8CA90
	
		// Methods
		private static void SetCornerUnitPositions(RoundedProperties roundedProperties, ref RoundedCornerUnitPositionData cornerUnitPositions); // 0x0000000180F8C4A0-0x0000000180F8C640
		private static void SetUnitPosition(ref Vector2[] unitPositions, int resolution, float baseAngle, bool makeSharpCorner); // 0x0000000180F8C640-0x0000000180F8C9A0
		public static void AddRoundedRect(ref VertexHelper vh, Vector2 center, float width, float height, RoundedProperties roundedProperties, Color32 color, Vector2 uv, ref RoundedCornerUnitPositionData cornerUnitPositions, GeoUtils.EdgeGradientData edgeGradientData, Vector2[] vertOffsets, bool flipUVX, bool flipUVY); // 0x0000000180F8BAA0-0x0000000180F8C2C0
		public static void AddRoundedRectLine(ref VertexHelper vh, Vector2 center, float width, float height, GeoUtils.OutlineProperties outlineProperties, RoundedProperties roundedProperties, Color32 color, Vector2 uv, ref RoundedCornerUnitPositionData cornerUnitPositions, GeoUtils.EdgeGradientData edgeGradientData, Vector2[] vertOffsets, bool flipUVX, bool flipUVY); // 0x0000000180F8A070-0x0000000180F8A820
		private static void AddRoundedRectVerticesRing(ref VertexHelper vh, Vector2 center, float width, float height, float fullWidth, float fullHeight, float tlRadius, float tlOuterRadius, float trRadius, float trOuterRadius, float brRadius, float brOuterRadius, float blRadius, float blOuterRadius, RoundedCornerUnitPositionData cornerUnitPositions, Color32 color, Vector2 uv, bool addIndices, Vector2[] vertOffsets); // 0x0000000180F8A820-0x0000000180F8BAA0
		private static void AddRoundedRingIndices(ref VertexHelper vh, RoundedCornerUnitPositionData cornerUnitPositions); // 0x0000000180F8C2C0-0x0000000180F8C4A0
	}
}
