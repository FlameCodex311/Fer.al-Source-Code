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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ThisOtherThing.UI.Shapes
{
	[AddComponentMenu] // 0x0000000180159AA0-0x0000000180159AD0
	public class Polygon : MaskableGraphic, IShape // TypeDefIndex: 13994
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
		public Polygon(); // 0x0000000181A03910-0x0000000181A03AE0
	
		// Methods
		public void ForceMeshUpdate(); // 0x0000000181A02890-0x0000000181A02A50
		protected override void OnEnable(); // 0x0000000181A02A50-0x0000000181A02AE0
		protected override void OnRectTransformDimensionsChange(); // 0x0000000181A037F0-0x0000000181A03910
		protected override void OnPopulateMesh(VertexHelper vh); // 0x0000000181A02AE0-0x0000000181A037F0
	}
}
