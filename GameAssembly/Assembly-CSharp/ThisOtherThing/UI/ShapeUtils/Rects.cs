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
	public class Rects // TypeDefIndex: 14647
	{
		// Fields
		private static Vector3 tmpPos; // 0x00
		private static Vector2 tmpUVPos; // 0x0C
		private static readonly Vector2[] defaultVertOffsets; // 0x18
	
		// Constructors
		public Rects(); // 0x0000000180373240-0x0000000180373250
		static Rects(); // 0x0000000180F898E0-0x0000000180F89AC0
	
		// Methods
		public static void AddRect(ref VertexHelper vh, Vector2 center, float width, float height, Color32 color, Vector2 uv, bool flipUVX, bool flipUVY); // 0x0000000180F89290-0x0000000180F89370
		public static void AddRect(ref VertexHelper vh, Vector2 center, float width, float height, Color32 color, GeoUtils.EdgeGradientData edgeGradientData, Vector2[] vertOffsets, bool flipUVX, bool flipUVY); // 0x0000000180F88FC0-0x0000000180F89290
		public static void AddRectRing(ref VertexHelper vh, GeoUtils.OutlineProperties OutlineProperties, Vector2 center, float width, float height, Color32 color, Vector2 uv, GeoUtils.EdgeGradientData edgeGradientData, Vector2[] vertOffsets, bool flipUVX, bool flipUVY); // 0x0000000180F88060-0x0000000180F88410
		public static void AddRectVertRing(ref VertexHelper vh, Vector2 center, float width, float height, Color32 color, float totalWidth, float totalHeight, bool addRingIndices = false /* Metadata: 0x007BAE0B */, Vector2[] vertOffsets = null, bool flipUVX = false /* Metadata: 0x007BAE0C */, bool flipUVY = false /* Metadata: 0x007BAE0D */); // 0x0000000180F88410-0x0000000180F88FC0
		public static void AddRectQuadIndices(ref VertexHelper vh); // 0x0000000180F87FC0-0x0000000180F88060
		public static void AddVerticalTwoColorRect(ref VertexHelper vh, Vector3 topLeft, float height, float width, Color32 topColor, Color32 bottomColor, Vector2 uv); // 0x0000000180F89370-0x0000000180F898E0
		public static void AddHorizontalTwoColorRect(ref VertexHelper vh, Vector3 topLeft, float height, float width, Color32 leftColor, Color32 rightColor, Vector2 uv); // 0x0000000180F87A50-0x0000000180F87FC0
	}
}
