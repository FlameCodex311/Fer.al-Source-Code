/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace AillieoUtils.UI
{
	public class RadialLayoutGroup : LayoutGroup // TypeDefIndex: 15368
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ConstraintMode mAngleConstraint; // 0x58
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ConstraintMode mRadiusConstraint; // 0x5C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Direction mLayoutDir; // 0x60
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float mRadiusStart; // 0x64
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float mRadiusDelta; // 0x68
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float mRadiusRange; // 0x6C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float mAngleDelta; // 0x70
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float mAngleStart; // 0x74
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float mAngleCenter; // 0x78
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float mAngleRange; // 0x7C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool mChildRotate; // 0x80
		private List<RectTransform> childList; // 0x88
		private List<ILayoutIgnorer> ignoreList; // 0x90
		private static readonly Vector2 center; // 0x00
	
		// Properties
		public ConstraintMode AngleConstraint { get; set; } // 0x000000018049CAA0-0x000000018049CAB0 0x0000000181411CA0-0x0000000181411CF0
		public ConstraintMode RadiusConstraint { get; set; } // 0x00000001804A3740-0x00000001804A3750 0x0000000181411E80-0x0000000181411ED0
		public Direction LayoutDir { get; set; } // 0x00000001804A3730-0x00000001804A3740 0x0000000181411E30-0x0000000181411E80
		public float RadiusStart { get; set; } // 0x0000000180487D10-0x0000000180487D20 0x0000000181411F70-0x0000000181411FC0
		public float RadiusDelta { get; set; } // 0x0000000180487D00-0x0000000180487D10 0x0000000181411ED0-0x0000000181411F20
		public float RadiusRange { get; set; } // 0x0000000180EF1650-0x0000000180EF1660 0x0000000181411F20-0x0000000181411F70
		public float AngleDelta { get; set; } // 0x0000000181128C90-0x0000000181128CA0 0x0000000181411CF0-0x0000000181411D40
		public float AngleStart { get; set; } // 0x0000000181411C40-0x0000000181411C50 0x0000000181411D90-0x0000000181411DE0
		public float AngleCenter { get; set; } // 0x0000000181411C20-0x0000000181411C30 0x0000000181411C50-0x0000000181411CA0
		public float AngleRange { get; set; } // 0x0000000181411C30-0x0000000181411C40 0x0000000181411D40-0x0000000181411D90
		public bool ChildRotate { get; set; } // 0x00000001805CC280-0x00000001805CC290 0x0000000181411DE0-0x0000000181411E30
	
		// Nested types
		public enum Direction // TypeDefIndex: 15369
		{
			Clockwise = 0,
			Counterclockwise = 1,
			Bidirectional = 2
		}
	
		public enum ConstraintMode // TypeDefIndex: 15370
		{
			Interval = 0,
			Range = 1
		}
	
		// Constructors
		public RadialLayoutGroup(); // 0x0000000181411B90-0x0000000181411C20
		static RadialLayoutGroup(); // 0x0000000181411B20-0x0000000181411B90
	
		// Methods
		public override void CalculateLayoutInputVertical(); // 0x00000001803581E0-0x00000001803581F0
		public override void CalculateLayoutInputHorizontal(); // 0x00000001803581E0-0x00000001803581F0
		public override void SetLayoutHorizontal(); // 0x0000000181411B10-0x0000000181411B20
		public override void SetLayoutVertical(); // 0x0000000181411B10-0x0000000181411B20
		private void CalculateChildrenPositions(); // 0x00000001814112E0-0x0000000181411670
		private void EnsureParameters(int childCount); // 0x0000000181411720-0x0000000181411820
		private void EnsureAngleParameters(int childCount); // 0x0000000181411670-0x0000000181411720
		private void EnsureRadiusParameters(int childCount); // 0x0000000181411820-0x0000000181411870
		private void ProcessOneChild(RectTransform child, float angle, float radius); // 0x0000000181411870-0x0000000181411B10
	}
}
