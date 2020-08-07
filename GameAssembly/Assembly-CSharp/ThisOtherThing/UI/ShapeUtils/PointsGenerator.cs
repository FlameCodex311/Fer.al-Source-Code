/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ThisOtherThing.UI.ShapeUtils
{
	public class PointsGenerator // TypeDefIndex: 14634
	{
		// Fields
		private static Dictionary<PointsList.PointListGeneratorData.CornerAnchor, Vector2> _anchorLookup; // 0x00
	
		// Constructors
		public PointsGenerator(); // 0x0000000180373240-0x0000000180373250
		static PointsGenerator(); // 0x0000000180F80E50-0x0000000180F80EB0
	
		// Methods
		public static void SetPoints(ref Vector2[] positions, PointsList.PointListGeneratorData data, RectTransform rectTransform); // 0x0000000180F80BF0-0x0000000180F80E50
		public static void SetPointsRect(ref Vector2[] positions, PointsList.PointListGeneratorData data); // 0x0000000180F7F940-0x0000000180F7FBF0
		public static void SetPointsSkewedQuad(ref Vector2[] positions, PointsList.PointListGeneratorData data, RectTransform rectTransform); // 0x0000000180F80280-0x0000000180F80940
		public static void SetPointsRound(ref Vector2[] positions, PointsList.PointListGeneratorData data); // 0x0000000180F7FBF0-0x0000000180F80280
		public static void SetPointsRadialGraph(ref Vector2[] positions, PointsList.PointListGeneratorData data); // 0x0000000180F7F6E0-0x0000000180F7F940
		public static void SetPointsLineGraph(ref Vector2[] positions, PointsList.PointListGeneratorData data); // 0x0000000180F7F2F0-0x0000000180F7F6E0
		public static void SetPointsAngleLine(ref Vector2[] positions, PointsList.PointListGeneratorData data); // 0x0000000180F7EC90-0x0000000180F7EEA0
		public static void SetPointsStar(ref Vector2[] positions, PointsList.PointListGeneratorData data); // 0x0000000180F80940-0x0000000180F80BF0
		public static void SetPointsGear(ref Vector2[] positions, PointsList.PointListGeneratorData data); // 0x0000000180F7EEA0-0x0000000180F7F2F0
	}
}
