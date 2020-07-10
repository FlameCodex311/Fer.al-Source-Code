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
	[AddComponentMenu] // 0x0000000180159090-0x00000001801590C0
	public class Arc : MaskableGraphic, IShape // TypeDefIndex: 13986
	{
		// Fields
		public GeoUtils.ShapeProperties ShapeProperties; // 0xC8
		public Ellipses.EllipseProperties EllipseProperties; // 0xD0
		public Arcs.ArcProperties ArcProperties; // 0xD8
		public Lines.LineProperties LineProperties; // 0xE0
		public PointsList.PointListProperties PointListProperties; // 0xE8
		private PointsList.PointsData PointsData; // 0xF0
		public GeoUtils.OutlineProperties OutlineProperties; // 0x170
		public GeoUtils.ShadowsProperties ShadowProperties; // 0x178
		public GeoUtils.AntiAliasingProperties AntiAliasingProperties; // 0x180
		private GeoUtils.UnitPositionData unitPositionData; // 0x188
		private GeoUtils.EdgeGradientData edgeGradientData; // 0x198
		private Vector2 radius; // 0x1A8
	
		// Constructors
		public Arc(); // 0x00000001819F3D30-0x00000001819F3F10
	
		// Methods
		protected override void OnEnable(); // 0x00000001819F2970-0x00000001819F2A00
		public void ForceMeshUpdate(); // 0x00000001819F2900-0x00000001819F2970
		protected override void OnPopulateMesh(VertexHelper vh); // 0x00000001819F2A00-0x00000001819F3D30
	}
}
