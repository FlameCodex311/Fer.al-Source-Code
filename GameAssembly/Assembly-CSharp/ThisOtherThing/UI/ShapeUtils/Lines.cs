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
	public class Lines // TypeDefIndex: 14631
	{
		// Fields
		private static Vector3 tmpPos; // 0x00
		private static Vector2 tmpPos2; // 0x0C
	
		// Nested types
		[Serializable]
		public class LineProperties // TypeDefIndex: 14632
		{
			// Fields
			public LineCapTypes LineCap; // 0x10
			public bool Closed; // 0x14
			public GeoUtils.RoundingProperties RoundedCapResolution; // 0x18
	
			// Nested types
			public enum LineCapTypes // TypeDefIndex: 14633
			{
				Close = 0,
				Projected = 1,
				Round = 2
			}
	
			// Constructors
			public LineProperties(); // 0x0000000180F7D070-0x0000000180F7D0D0
	
			// Methods
			public void OnCheck(); // 0x0000000180F7D040-0x0000000180F7D070
		}
	
		// Constructors
		public Lines(); // 0x0000000180373240-0x0000000180373250
		static Lines(); // 0x00000001809568C0-0x0000000180956980
	
		// Methods
		public static void AddLine(ref VertexHelper vh, LineProperties lineProperties, PointsList.PointListProperties pointListProperties, Vector2 positionOffset, GeoUtils.OutlineProperties outlineProperties, Color32 color, Vector2 uv, ref PointsList.PointsData pointsData, GeoUtils.EdgeGradientData edgeGradientData, RectTransform rectTransform); // 0x0000000180952780-0x0000000180954C90
		public static void AddStartCap(ref VertexHelper vh, LineProperties lineProperties, Vector2 positionOffset, GeoUtils.OutlineProperties outlineProperties, Color32 color, Vector2 uv, float uvXMin, float uvXLength, PointsList.PointsData pointsData, GeoUtils.EdgeGradientData edgeGradientData); // 0x0000000180956060-0x00000001809568C0
		public static void AddEndCap(ref VertexHelper vh, LineProperties lineProperties, Vector2 positionOffset, GeoUtils.OutlineProperties outlineProperties, Color32 color, Vector2 uv, float uvXMin, float uvXLength, PointsList.PointsData pointsData, GeoUtils.EdgeGradientData edgeGradientData); // 0x0000000180951E30-0x0000000180952780
		public static void AddCloseCap(ref VertexHelper vh, bool isStart, int firstVertIndex, Vector2 position, Vector2 normal, Vector2 capOffset, int invertIndices, LineProperties lineProperties, GeoUtils.OutlineProperties outlineProperties, Color32 color, Vector2 uv, PointsList.PointsData pointsData, GeoUtils.EdgeGradientData edgeGradientData, int currentVertCount); // 0x0000000180951920-0x0000000180951E30
		public static void AddProjectedCap(ref VertexHelper vh, bool isStart, int firstVertIndex, Vector2 position, Vector2 normal, Vector2 capOffset, int invertIndices, LineProperties lineProperties, GeoUtils.OutlineProperties outlineProperties, Color32 color, Vector2 uv, PointsList.PointsData pointsData, GeoUtils.EdgeGradientData edgeGradientData, int currentVertCount); // 0x0000000180954C90-0x00000001809555D0
		public static void AddRoundedCap(ref VertexHelper vh, bool isStart, int firstVertIndex, Vector2 position, Vector2 normal, Vector2 capOffset, int invertIndices, LineProperties lineProperties, GeoUtils.OutlineProperties outlineProperties, Color32 color, Vector2 uv, PointsList.PointsData pointsData, GeoUtils.EdgeGradientData edgeGradientData, Vector2[] capOffsets, Vector2[] uvOffsets, float uvXMin, float uvXLength, int currentVertCount); // 0x00000001809555D0-0x0000000180956060
	}
}
