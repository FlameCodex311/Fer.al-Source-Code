/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace AillieoUtils.UI
{
	public class RadialLayoutGroup : LayoutGroup // TypeDefIndex: 15975
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ConstraintMode mAngleConstraint; // 0x58
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ConstraintMode mRadiusConstraint; // 0x5C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Direction mLayoutDir; // 0x60
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float mRadiusStart; // 0x64
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float mRadiusDelta; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float mRadiusRange; // 0x6C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float mAngleDelta; // 0x70
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float mAngleStart; // 0x74
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float mAngleCenter; // 0x78
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float mAngleRange; // 0x7C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool mChildRotate; // 0x80
		private List<RectTransform> childList; // 0x88
		private List<ILayoutIgnorer> ignoreList; // 0x90
		private static readonly Vector2 center; // 0x00
	
		// Properties
		public ConstraintMode AngleConstraint { get; set; } // 0x0000000180693DB0-0x0000000180693DC0 0x000000018215CE40-0x000000018215CE90
		public ConstraintMode RadiusConstraint { get; set; } // 0x00000001804D2E40-0x00000001804D2E50 0x000000018215D020-0x000000018215D070
		public Direction LayoutDir { get; set; } // 0x00000001804ADA80-0x00000001804ADA90 0x000000018215CFD0-0x000000018215D020
		public float RadiusStart { get; set; } // 0x000000018099EBD0-0x000000018099EBE0 0x000000018215D110-0x000000018215D160
		public float RadiusDelta { get; set; } // 0x00000001804C5F40-0x00000001804C5F50 0x000000018215D070-0x000000018215D0C0
		public float RadiusRange { get; set; } // 0x00000001804C5F30-0x00000001804C5F40 0x000000018215D0C0-0x000000018215D110
		public float AngleDelta { get; set; } // 0x000000018096DED0-0x000000018096DEE0 0x000000018215CE90-0x000000018215CEE0
		public float AngleStart { get; set; } // 0x0000000180F8A040-0x0000000180F8A050 0x000000018215CF30-0x000000018215CF80
		public float AngleCenter { get; set; } // 0x0000000180780010-0x0000000180780020 0x000000018215CDF0-0x000000018215CE40
		public float AngleRange { get; set; } // 0x0000000180780020-0x0000000180780030 0x000000018215CEE0-0x000000018215CF30
		public bool ChildRotate { get; set; } // 0x0000000180CCD970-0x0000000180CCD980 0x000000018215CF80-0x000000018215CFD0
	
		// Nested types
		public enum Direction // TypeDefIndex: 15976
		{
			Clockwise = 0,
			Counterclockwise = 1,
			Bidirectional = 2
		}
	
		public enum ConstraintMode // TypeDefIndex: 15977
		{
			Interval = 0,
			Range = 1
		}
	
		// Constructors
		public RadialLayoutGroup(); // 0x000000018215CD60-0x000000018215CDF0
		static RadialLayoutGroup(); // 0x000000018215CCF0-0x000000018215CD60
	
		// Methods
		public override void CalculateLayoutInputVertical(); // 0x00000001803774A0-0x00000001803774B0
		public override void CalculateLayoutInputHorizontal(); // 0x00000001803774A0-0x00000001803774B0
		public override void SetLayoutHorizontal(); // 0x000000018215CCE0-0x000000018215CCF0
		public override void SetLayoutVertical(); // 0x000000018215CCE0-0x000000018215CCF0
		private void CalculateChildrenPositions(); // 0x000000018215C4C0-0x000000018215C840
		private void EnsureParameters(int childCount); // 0x000000018215C8F0-0x000000018215C9F0
		private void EnsureAngleParameters(int childCount); // 0x000000018215C840-0x000000018215C8F0
		private void EnsureRadiusParameters(int childCount); // 0x000000018215C9F0-0x000000018215CA40
		private void ProcessOneChild(RectTransform child, float angle, float radius); // 0x000000018215CA40-0x000000018215CCE0
	}
}
