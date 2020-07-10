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
	public class Polygons // TypeDefIndex: 13975
	{
		// Fields
		private static Vector3 tmpPos; // 0x00
	
		// Nested types
		[Serializable]
		public class PolygonProperties // TypeDefIndex: 13976
		{
			// Fields
			public CenterTypes CenterType; // 0x10
			public Vector2 CenterOffset; // 0x14
			public Vector2 CustomCenter; // 0x1C
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Vector2 AdjustedCenter; // 0x24
			public CutoutProperties CutoutProperties; // 0x30
	
			// Nested types
			public enum CenterTypes // TypeDefIndex: 13977
			{
				Calculated = 0,
				Offset = 1,
				CustomPosition = 2,
				Cutout = 3
			}
	
			// Constructors
			public PolygonProperties(); // 0x0000000181A027A0-0x0000000181A02890
	
			// Methods
			public void UpdateAdjusted(PointsList.PointListProperties pointListProperties); // 0x0000000181A02520-0x0000000181A027A0
		}
	
		[Serializable]
		public class CutoutProperties // TypeDefIndex: 13978
		{
			// Fields
			[Min] // 0x0000000180157710-0x0000000180157730
			public int Resolution; // 0x10
			[Min] // 0x0000000180153690-0x00000001801536B0
			public float Radius; // 0x14
			[Range] // 0x0000000180157A70-0x0000000180157A90
			public float RotationOffset; // 0x18
			public GeoUtils.UnitPositionData UnitPositionData; // 0x20
	
			// Constructors
			public CutoutProperties(); // 0x00000001819F3F10-0x00000001819F3F30
		}
	
		// Constructors
		public Polygons(); // 0x000000018036B6C0-0x000000018036B6D0
		static Polygons(); // 0x0000000181A05070-0x0000000181A050E0
	
		// Methods
		public static void AddPolygon(ref VertexHelper vh, PolygonProperties polygonProperties, PointsList.PointListProperties pointListProperties, Vector2 positionOffset, Color32 color, Vector2 uv, ref PointsList.PointsData pointsData, GeoUtils.EdgeGradientData edgeGradientData, RectTransform rectTransform); // 0x0000000181A03AE0-0x0000000181A05070
	}
}
