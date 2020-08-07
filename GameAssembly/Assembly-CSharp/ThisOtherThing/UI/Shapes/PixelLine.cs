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

namespace ThisOtherThing.UI.Shapes
{
	[AddComponentMenu] // 0x0000000180286060-0x0000000180286090
	public class PixelLine : MaskableGraphic, IShape // TypeDefIndex: 14661
	{
		// Fields
		public float LineWeight; // 0xC8
		public GeoUtils.SnappedPositionAndOrientationProperties SnappedProperties; // 0xD0
		private Vector3 center; // 0xD8
	
		// Constructors
		public PixelLine(); // 0x0000000180F7E620-0x0000000180F7E6D0
	
		// Methods
		public void ForceMeshUpdate(); // 0x0000000180F7AE80-0x0000000180F7AEC0
		protected override void OnPopulateMesh(VertexHelper vh); // 0x0000000180F7E200-0x0000000180F7E620
	}
}
