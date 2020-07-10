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
	[AddComponentMenu] // 0x0000000180159880-0x00000001801598B0
	public class Line : MaskableGraphic, IShape // TypeDefIndex: 13992
	{
		// Fields
		public GeoUtils.ShapeProperties ShapeProperties; // 0xC8
		public PointsList.PointListsProperties PointListsProperties; // 0xD0
		public Lines.LineProperties LineProperties; // 0xD8
		public GeoUtils.OutlineProperties OutlineProperties; // 0xE0
		public GeoUtils.ShadowsProperties ShadowProperties; // 0xE8
		public GeoUtils.AntiAliasingProperties AntiAliasingProperties; // 0xF0
		public Sprite Sprite; // 0xF8
		private PointsList.PointsData[] pointsListData; // 0x100
		private GeoUtils.EdgeGradientData edgeGradientData; // 0x108
	
		// Properties
		public override Texture mainTexture { get; } // 0x00000001819F7550-0x00000001819F76F0 
	
		// Constructors
		public Line(); // 0x00000001819F73F0-0x00000001819F7550
	
		// Methods
		public void ForceMeshUpdate(); // 0x00000001819F6540-0x00000001819F6700
		protected override void OnPopulateMesh(VertexHelper vh); // 0x00000001819F6700-0x00000001819F72D0
		protected override void UpdateMaterial(); // 0x00000001819F72D0-0x00000001819F73F0
	}
}
