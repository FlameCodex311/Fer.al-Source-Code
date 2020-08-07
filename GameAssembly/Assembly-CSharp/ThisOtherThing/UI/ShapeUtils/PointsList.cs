/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThisOtherThing.UI;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ThisOtherThing.UI.ShapeUtils
{
	public class PointsList // TypeDefIndex: 14635
	{
		// Fields
		private static Vector2 tmpPos; // 0x00
		private static Vector2 tmpBackV; // 0x08
		private static Vector2 tmpBackNormV; // 0x10
		private static Vector2 tmpForwV; // 0x18
		private static Vector2 tmpForwNormV; // 0x20
		private static Vector2 tmpBackPos; // 0x28
		private static Vector2 tmpForwPos; // 0x30
		private static List<Vector2> tmpCachedPositions; // 0x38
	
		// Nested types
		[Serializable]
		public class PointListsProperties // TypeDefIndex: 14636
		{
			// Fields
			public PointListProperties[] PointListProperties; // 0x10
	
			// Constructors
			public PointListsProperties(); // 0x0000000180F7EBC0-0x0000000180F7EC90
		}
	
		[Serializable]
		public class PointListProperties // TypeDefIndex: 14637
		{
			// Fields
			public PointListGeneratorData GeneratorData; // 0x10
			public Vector2[] Positions; // 0x18
			[Range] // 0x0000000180282890-0x00000001802828B0
			public float MaxAngle; // 0x20
			[Min] // 0x0000000180280980-0x00000001802809A0
			public float RoundingDistance; // 0x24
			public GeoUtils.RoundingProperties CornerRounding; // 0x28
			public bool ShowHandles; // 0x30
	
			// Constructors
			public PointListProperties(); // 0x0000000180F7E8F0-0x0000000180F7EBC0
	
			// Methods
			public void SetPoints(RectTransform rectTransform); // 0x0000000180F7E830-0x0000000180F7E8F0
		}
	
		[Serializable]
		public class PointListGeneratorData // TypeDefIndex: 14638
		{
			// Fields
			public Generators Generator; // 0x10
			public bool NeedsUpdate; // 0x14
			public Vector2 Center; // 0x18
			[Min] // 0x0000000180282AE0-0x0000000180282B00
			public float Width; // 0x20
			[Min] // 0x0000000180282AE0-0x0000000180282B00
			public float Height; // 0x24
			[Min] // 0x0000000180282AE0-0x0000000180282B00
			public float Radius; // 0x28
			[Range] // 0x0000000180244630-0x0000000180244650
			public float Direction; // 0x2C
			public float[] FloatValues; // 0x30
			public float MinFloatValue; // 0x38
			public float MaxFloatValue; // 0x3C
			public int IntStartOffset; // 0x40
			public float FloatStartOffset; // 0x44
			public float Length; // 0x48
			public float EndRadius; // 0x4C
			[Min] // 0x000000018027F910-0x000000018027F930
			public int Resolution; // 0x50
			public bool CenterPoint; // 0x54
			public bool SkipLastPosition; // 0x55
			public float Angle; // 0x58
			public float InnerScaler; // 0x5C
			public float OuterScaler; // 0x60
			public CornerPosition CornerA; // 0x64
			public CornerPosition CornerB; // 0x70
			public CornerPosition CornerC; // 0x7C
			public CornerPosition CornerD; // 0x88
	
			// Nested types
			public enum Generators // TypeDefIndex: 14639
			{
				Custom = 0,
				Rect = 1,
				Round = 2,
				RadialGraph = 3,
				LineGraph = 4,
				AngleLine = 5,
				Star = 6,
				Gear = 7,
				SkewedQuad = 8
			}
	
			[Serializable]
			public struct CornerPosition // TypeDefIndex: 14640
			{
				// Fields
				public Vector2 position; // 0x00
				public CornerAnchor anchor; // 0x08
	
				// Constructors
				public CornerPosition(Vector2 inPosition, CornerAnchor inAnchor); // 0x0000000180051B20-0x0000000180051B30
			}
	
			public enum CornerAnchor // TypeDefIndex: 14641
			{
				Center = 0,
				TopLeft = 1,
				TopRight = 2,
				BottomRight = 3,
				BottomLeft = 4
			}
	
			// Constructors
			public PointListGeneratorData(); // 0x0000000180F7E6D0-0x0000000180F7E830
		}
	
		public struct PointsData // TypeDefIndex: 14642
		{
			// Fields
			public bool NeedsUpdate; // 0x00
			public bool IsClosed; // 0x01
			public List<Vector2> Positions; // 0x08
			public int NumPositions; // 0x10
			public Vector2[] PositionTangents; // 0x18
			public Vector2[] PositionNormals; // 0x20
			public float TotalLength; // 0x28
			public float[] PositionDistances; // 0x30
			public float[] NormalizedPositionDistances; // 0x38
			public Vector2 StartCapOffset; // 0x40
			public Vector2 EndCapOffset; // 0x48
			public bool GenerateRoundedCaps; // 0x50
			public int RoundedCapResolution; // 0x54
			public Vector2[] StartCapOffsets; // 0x58
			public Vector2[] StartCapUVs; // 0x60
			public Vector2[] EndCapOffsets; // 0x68
			public Vector2[] EndCapUVs; // 0x70
			public float LineWeight; // 0x78
		}
	
		// Constructors
		public PointsList(); // 0x0000000180373240-0x0000000180373250
		static PointsList(); // 0x0000000180F83C50-0x0000000180F83CB0
	
		// Methods
		public static void SetPositions(PointListProperties pointListProperties, ref PointsData lineData); // 0x0000000180F832E0-0x0000000180F83990
		private static void CheckMinPointDistances(ref Vector2[] inPositions, ref List<Vector2> outPositions, float minDistance, bool isClosed); // 0x0000000180F812D0-0x0000000180F81A40
		private static void InterpolatePoints(ref PointsData lineData, Vector2 prevPosition, Vector2 position, Vector2 nextPosition, PointListProperties pointListProperties, int index); // 0x0000000180F81A40-0x0000000180F81E90
		private static void AddRoundedPoints(ref PointsData lineData, Vector2 backNormV, Vector2 position, Vector2 forwNormV, PointListProperties pointListProperties, float angle, float maxDistance); // 0x0000000180F80EB0-0x0000000180F812D0
		public static bool SetLineData(PointListProperties pointListProperties, ref PointsData lineData); // 0x0000000180F81E90-0x0000000180F83090
		private static void SetRoundedCapPointData(float centerAngle, ref Vector2[] offsets, ref Vector2[] uvs, int resolution, bool isStart); // 0x0000000180F83990-0x0000000180F83C50
		private static void SetPointData(Vector2 currentPoint, Vector2 nextPoint, ref Vector2 currentUnitTangent, ref Vector2 positionTangent, ref Vector2 positionNormal, ref Vector2 lastUnitTangent, ref float distance); // 0x0000000180F83090-0x0000000180F832E0
	}
}
