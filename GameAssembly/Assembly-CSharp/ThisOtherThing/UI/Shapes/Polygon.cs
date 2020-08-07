/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThisOtherThing.UI;
using ThisOtherThing.UI.ShapeUtils;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ThisOtherThing.UI.Shapes
{
	[AddComponentMenu] // 0x00000001802861E0-0x0000000180286210
	public class Polygon : MaskableGraphic, IShape // TypeDefIndex: 14662
	{
		// Fields
		public GeoUtils.ShapeProperties ShapeProperties; // 0xC8
		public PointsList.PointListsProperties PointListsProperties; // 0xD0
		public Polygons.PolygonProperties PolygonProperties; // 0xD8
		public GeoUtils.ShadowsProperties ShadowProperties; // 0xE0
		public GeoUtils.AntiAliasingProperties AntiAliasingProperties; // 0xE8
		private PointsList.PointsData[] pointsListData; // 0xF0
		private GeoUtils.EdgeGradientData edgeGradientData; // 0xF8
		private Rect pixelRect; // 0x108
	
		// Constructors
		public Polygon(); // 0x0000000180F84FC0-0x0000000180F85190
	
		// Methods
		public void ForceMeshUpdate(); // 0x0000000180F84010-0x0000000180F841C0
		protected override void OnEnable(); // 0x0000000180F841C0-0x0000000180F84240
		protected override void OnRectTransformDimensionsChange(); // 0x0000000180F84EC0-0x0000000180F84FC0
		protected override void OnPopulateMesh(VertexHelper vh); // 0x0000000180F84240-0x0000000180F84EC0
	}
}
