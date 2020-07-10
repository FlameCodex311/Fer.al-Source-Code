/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThisOtherThing.UI;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ThisOtherThing.UI.ShapeUtils
{
	public class RoundedRects // TypeDefIndex: 13980
	{
		// Fields
		private static Vector3 tmpV3; // 0x00
		private static Vector3 tmpPos; // 0x0C
		private static Vector2 tmpUV; // 0x18
	
		// Nested types
		public struct RoundedCornerUnitPositionData // TypeDefIndex: 13981
		{
			// Fields
			public Vector2[] TLUnitPositions; // 0x00
			public Vector2[] TRUnitPositions; // 0x08
			public Vector2[] BRUnitPositions; // 0x10
			public Vector2[] BLUnitPositions; // 0x18
		}
	
		[Serializable]
		public class RoundedProperties // TypeDefIndex: 13982
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
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private float <AdjustedTLRadius>k__BackingField; // 0x68
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private float <AdjustedTRRadius>k__BackingField; // 0x6C
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private float <AdjustedBRRadius>k__BackingField; // 0x70
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private float <AdjustedBLRadius>k__BackingField; // 0x74
	
			// Properties
			public float AdjustedTLRadius { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180487D00-0x0000000180487D10 0x0000000180EF18A0-0x0000000180EF18B0
			public float AdjustedTRRadius { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180EF1650-0x0000000180EF1660 0x0000000180EF1890-0x0000000180EF18A0
			public float AdjustedBRRadius { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000181128C90-0x0000000181128CA0 0x0000000181A08AC0-0x0000000181A08AD0
			public float AdjustedBLRadius { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000181411C40-0x0000000181411C50 0x0000000181646E90-0x0000000181646EA0
	
			// Nested types
			public enum RoundedType // TypeDefIndex: 13983
			{
				None = 0,
				Uniform = 1,
				Individual = 2
			}
	
			public enum ResolutionType // TypeDefIndex: 13984
			{
				Uniform = 0,
				Individual = 1
			}
	
			// Constructors
			public RoundedProperties(); // 0x0000000181A089D0-0x0000000181A08AC0
	
			// Methods
			public void UpdateAdjusted(Rect rect, float offset); // 0x0000000181A08720-0x0000000181A089D0
			public void OnCheck(Rect rect); // 0x0000000181A08540-0x0000000181A08720
		}
	
		// Constructors
		public RoundedRects(); // 0x000000018036B6C0-0x000000018036B6D0
		static RoundedRects(); // 0x0000000181A0B4C0-0x0000000181A0B5B0
	
		// Methods
		private static void SetCornerUnitPositions(RoundedProperties roundedProperties, ref RoundedCornerUnitPositionData cornerUnitPositions); // 0x0000000181A0AF90-0x0000000181A0B140
		private static void SetUnitPosition(ref Vector2[] unitPositions, int resolution, float baseAngle, bool makeSharpCorner); // 0x0000000181A0B140-0x0000000181A0B4C0
		public static void AddRoundedRect(ref VertexHelper vh, Vector2 center, float width, float height, RoundedProperties roundedProperties, Color32 color, Vector2 uv, ref RoundedCornerUnitPositionData cornerUnitPositions, GeoUtils.EdgeGradientData edgeGradientData, Vector2[] vertOffsets, bool flipUVX, bool flipUVY); // 0x0000000181A0A560-0x0000000181A0ADA0
		public static void AddRoundedRectLine(ref VertexHelper vh, Vector2 center, float width, float height, GeoUtils.OutlineProperties outlineProperties, RoundedProperties roundedProperties, Color32 color, Vector2 uv, ref RoundedCornerUnitPositionData cornerUnitPositions, GeoUtils.EdgeGradientData edgeGradientData, Vector2[] vertOffsets, bool flipUVX, bool flipUVY); // 0x0000000181A08AD0-0x0000000181A09280
		private static void AddRoundedRectVerticesRing(ref VertexHelper vh, Vector2 center, float width, float height, float fullWidth, float fullHeight, float tlRadius, float tlOuterRadius, float trRadius, float trOuterRadius, float brRadius, float brOuterRadius, float blRadius, float blOuterRadius, RoundedCornerUnitPositionData cornerUnitPositions, Color32 color, Vector2 uv, bool addIndices, Vector2[] vertOffsets); // 0x0000000181A09280-0x0000000181A0A560
		private static void AddRoundedRingIndices(ref VertexHelper vh, RoundedCornerUnitPositionData cornerUnitPositions); // 0x0000000181A0ADA0-0x0000000181A0AF90
	}
}
