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
	public class Arcs // TypeDefIndex: 13956
	{
		// Fields
		private static Vector3 tmpPosition; // 0x00
		private static Vector2 tmpInnerRadius; // 0x0C
		private static Vector2 tmpOuterRadius; // 0x14
		private static Vector2 tmpArcInnerRadius; // 0x1C
		private static Vector2 tmpArcOuterRadius; // 0x24
		private static Vector3 tmpOffsetCenter; // 0x2C
		private static Vector3 noOverlapInnerOffset; // 0x38
		private static Vector3 noOverlapOuterOffset; // 0x44
	
		// Nested types
		[Serializable]
		public class ArcProperties // TypeDefIndex: 13957
		{
			// Fields
			public ArcDirection Direction; // 0x10
			[Range] // 0x00000001800C20E0-0x00000001800C2100
			public float Length; // 0x14
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private int <AdjustedResolution>k__BackingField; // 0x18
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private float <AdjustedBaseAngle>k__BackingField; // 0x1C
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private float <AdjustedDirection>k__BackingField; // 0x20
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private float <SegmentAngle>k__BackingField; // 0x24
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private float <EndSegmentAngle>k__BackingField; // 0x28
			private Vector3 endSegmentUnitPosition; // 0x2C
			private Vector3 startTangent; // 0x38
			private Vector3 endTangent; // 0x44
			private Vector3 centerNormal; // 0x50
	
			// Properties
			public int AdjustedResolution { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180367710-0x0000000180367720 0x000000018036B1F0-0x000000018036B200
			public float AdjustedBaseAngle { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001805D9070-0x00000001805D9080 0x00000001805D90A0-0x00000001805D90B0
			public float AdjustedDirection { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180487DA0-0x0000000180487DB0 0x00000001805D9090-0x00000001805D90A0
			public float SegmentAngle { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804935B0-0x00000001804935C0 0x00000001811F74C0-0x00000001811F74D0
			public float EndSegmentAngle { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180487D50-0x0000000180487D60 0x00000001805D90B0-0x00000001805D90C0
			public Vector3 EndSegmentUnitPosition { get; } // 0x00000001811F7460-0x00000001811F7480 
			public Vector3 StartTangent { get; } // 0x00000001811F74A0-0x00000001811F74C0 
			public Vector3 EndTangent { get; } // 0x00000001811F7480-0x00000001811F74A0 
			public Vector3 CenterNormal { get; } // 0x00000001811F7440-0x00000001811F7460 
	
			// Nested types
			public enum ArcDirection // TypeDefIndex: 13958
			{
				Backward = 0,
				Centered = 1,
				Forward = 2
			}
	
			// Constructors
			public ArcProperties(); // 0x00000001811F7370-0x00000001811F7440
	
			// Methods
			public void UpdateAdjusted(int FullCircleResolution, float BaseAngle); // 0x00000001811F7160-0x00000001811F7370
		}
	
		// Constructors
		public Arcs(); // 0x000000018036B6C0-0x000000018036B6D0
		static Arcs(); // 0x00000001811FB910-0x00000001811FBB20
	
		// Methods
		public static void AddSegment(ref VertexHelper vh, Vector2 center, Vector2 radius, Ellipses.EllipseProperties circleProperties, ArcProperties arcProperties, Color32 color, Vector2 uv, ref GeoUtils.UnitPositionData unitPositionData, GeoUtils.EdgeGradientData edgeGradientData); // 0x00000001811F9E30-0x00000001811FB910
		public static void AddArcRing(ref VertexHelper vh, Vector2 center, Vector2 radius, Ellipses.EllipseProperties ellipseProperties, ArcProperties arcProperties, GeoUtils.OutlineProperties outlineProperties, Color32 color, Vector2 uv, ref GeoUtils.UnitPositionData unitPositionData, GeoUtils.EdgeGradientData edgeGradientData); // 0x00000001811F74D0-0x00000001811F9E30
	}
}
