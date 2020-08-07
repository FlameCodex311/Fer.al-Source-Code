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
	public class Polygons // TypeDefIndex: 14643
	{
		// Fields
		private static Vector3 tmpPos; // 0x00
	
		// Nested types
		[Serializable]
		public class PolygonProperties // TypeDefIndex: 14644
		{
			// Fields
			public CenterTypes CenterType; // 0x10
			public Vector2 CenterOffset; // 0x14
			public Vector2 CustomCenter; // 0x1C
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Vector2 AdjustedCenter; // 0x24
			public CutoutProperties CutoutProperties; // 0x30
	
			// Nested types
			public enum CenterTypes // TypeDefIndex: 14645
			{
				Calculated = 0,
				Offset = 1,
				CustomPosition = 2,
				Cutout = 3
			}
	
			// Constructors
			public PolygonProperties(); // 0x0000000180F83F20-0x0000000180F84010
	
			// Methods
			public void UpdateAdjusted(PointsList.PointListProperties pointListProperties); // 0x0000000180F83CB0-0x0000000180F83F20
		}
	
		[Serializable]
		public class CutoutProperties // TypeDefIndex: 14646
		{
			// Fields
			[Min] // 0x00000001802832B0-0x00000001802832D0
			public int Resolution; // 0x10
			[Min] // 0x0000000180280980-0x00000001802809A0
			public float Radius; // 0x14
			[Range] // 0x00000001802836D0-0x00000001802836F0
			public float RotationOffset; // 0x18
			public GeoUtils.UnitPositionData UnitPositionData; // 0x20
	
			// Constructors
			public CutoutProperties(); // 0x0000000180F7ADC0-0x0000000180F7ADE0
		}
	
		// Constructors
		public Polygons(); // 0x0000000180373240-0x0000000180373250
		static Polygons(); // 0x0000000180F866B0-0x0000000180F86720
	
		// Methods
		public static void AddPolygon(ref VertexHelper vh, PolygonProperties polygonProperties, PointsList.PointListProperties pointListProperties, Vector2 positionOffset, Color32 color, Vector2 uv, ref PointsList.PointsData pointsData, GeoUtils.EdgeGradientData edgeGradientData, RectTransform rectTransform); // 0x0000000180F85190-0x0000000180F866B0
	}
}
