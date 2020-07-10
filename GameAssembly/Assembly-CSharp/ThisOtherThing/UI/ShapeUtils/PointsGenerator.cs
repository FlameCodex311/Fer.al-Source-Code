/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ThisOtherThing.UI.ShapeUtils
{
	public class PointsGenerator // TypeDefIndex: 13966
	{
		// Fields
		private static Dictionary<PointsList.PointListGeneratorData.CornerAnchor, Vector2> _anchorLookup; // 0x00
	
		// Constructors
		public PointsGenerator(); // 0x000000018036B6C0-0x000000018036B6D0
		static PointsGenerator(); // 0x00000001819FF550-0x00000001819FF5B0
	
		// Methods
		public static void SetPoints(ref Vector2[] positions, PointsList.PointListGeneratorData data, RectTransform rectTransform); // 0x00000001819FF2F0-0x00000001819FF550
		public static void SetPointsRect(ref Vector2[] positions, PointsList.PointListGeneratorData data); // 0x00000001819FDFA0-0x00000001819FE270
		public static void SetPointsSkewedQuad(ref Vector2[] positions, PointsList.PointListGeneratorData data, RectTransform rectTransform); // 0x00000001819FE930-0x00000001819FF020
		public static void SetPointsRound(ref Vector2[] positions, PointsList.PointListGeneratorData data); // 0x00000001819FE270-0x00000001819FE930
		public static void SetPointsRadialGraph(ref Vector2[] positions, PointsList.PointListGeneratorData data); // 0x00000001819FDD30-0x00000001819FDFA0
		public static void SetPointsLineGraph(ref Vector2[] positions, PointsList.PointListGeneratorData data); // 0x00000001819FD910-0x00000001819FDD30
		public static void SetPointsAngleLine(ref Vector2[] positions, PointsList.PointListGeneratorData data); // 0x00000001819FD270-0x00000001819FD490
		public static void SetPointsStar(ref Vector2[] positions, PointsList.PointListGeneratorData data); // 0x00000001819FF020-0x00000001819FF2F0
		public static void SetPointsGear(ref Vector2[] positions, PointsList.PointListGeneratorData data); // 0x00000001819FD490-0x00000001819FD910
	}
}
