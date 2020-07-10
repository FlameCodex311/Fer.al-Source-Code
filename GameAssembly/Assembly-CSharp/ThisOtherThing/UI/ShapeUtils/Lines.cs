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
	public class Lines // TypeDefIndex: 13963
	{
		// Fields
		private static Vector3 tmpPos; // 0x00
		private static Vector2 tmpPos2; // 0x0C
	
		// Nested types
		[Serializable]
		public class LineProperties // TypeDefIndex: 13964
		{
			// Fields
			public LineCapTypes LineCap; // 0x10
			public bool Closed; // 0x14
			public GeoUtils.RoundingProperties RoundedCapResolution; // 0x18
	
			// Nested types
			public enum LineCapTypes // TypeDefIndex: 13965
			{
				Close = 0,
				Projected = 1,
				Round = 2
			}
	
			// Constructors
			public LineProperties(); // 0x00000001819F64E0-0x00000001819F6540
	
			// Methods
			public void OnCheck(); // 0x00000001819F64B0-0x00000001819F64E0
		}
	
		// Constructors
		public Lines(); // 0x000000018036B6C0-0x000000018036B6D0
		static Lines(); // 0x00000001819FC710-0x00000001819FC7D0
	
		// Methods
		public static void AddLine(ref VertexHelper vh, LineProperties lineProperties, PointsList.PointListProperties pointListProperties, Vector2 positionOffset, GeoUtils.OutlineProperties outlineProperties, Color32 color, Vector2 uv, ref PointsList.PointsData pointsData, GeoUtils.EdgeGradientData edgeGradientData, RectTransform rectTransform); // 0x00000001819F8560-0x00000001819FAA90
		public static void AddStartCap(ref VertexHelper vh, LineProperties lineProperties, Vector2 positionOffset, GeoUtils.OutlineProperties outlineProperties, Color32 color, Vector2 uv, float uvXMin, float uvXLength, PointsList.PointsData pointsData, GeoUtils.EdgeGradientData edgeGradientData); // 0x00000001819FBEA0-0x00000001819FC710
		public static void AddEndCap(ref VertexHelper vh, LineProperties lineProperties, Vector2 positionOffset, GeoUtils.OutlineProperties outlineProperties, Color32 color, Vector2 uv, float uvXMin, float uvXLength, PointsList.PointsData pointsData, GeoUtils.EdgeGradientData edgeGradientData); // 0x00000001819F7C00-0x00000001819F8560
		public static void AddCloseCap(ref VertexHelper vh, bool isStart, int firstVertIndex, Vector2 position, Vector2 normal, Vector2 capOffset, int invertIndices, LineProperties lineProperties, GeoUtils.OutlineProperties outlineProperties, Color32 color, Vector2 uv, PointsList.PointsData pointsData, GeoUtils.EdgeGradientData edgeGradientData, int currentVertCount); // 0x00000001819F76F0-0x00000001819F7C00
		public static void AddProjectedCap(ref VertexHelper vh, bool isStart, int firstVertIndex, Vector2 position, Vector2 normal, Vector2 capOffset, int invertIndices, LineProperties lineProperties, GeoUtils.OutlineProperties outlineProperties, Color32 color, Vector2 uv, PointsList.PointsData pointsData, GeoUtils.EdgeGradientData edgeGradientData, int currentVertCount); // 0x00000001819FAA90-0x00000001819FB3E0
		public static void AddRoundedCap(ref VertexHelper vh, bool isStart, int firstVertIndex, Vector2 position, Vector2 normal, Vector2 capOffset, int invertIndices, LineProperties lineProperties, GeoUtils.OutlineProperties outlineProperties, Color32 color, Vector2 uv, PointsList.PointsData pointsData, GeoUtils.EdgeGradientData edgeGradientData, Vector2[] capOffsets, Vector2[] uvOffsets, float uvXMin, float uvXLength, int currentVertCount); // 0x00000001819FB3E0-0x00000001819FBEA0
	}
}
