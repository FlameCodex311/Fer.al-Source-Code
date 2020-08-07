/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FIMSpace.FSpine
{
	public class FSpineAnimator : UnityEngine.MonoBehaviour // TypeDefIndex: 10329
	{
		// Fields
		[Tooltip] // 0x00000001801D6C30-0x00000001801D6C60
		public List<Transform> SpineTransforms; // 0x18
		private List<FSpine_Point> proceduralPoints; // 0x20
		private List<FSpine_Point> ProceduralReferencePose; // 0x28
		private List<FSpine_Point> helperProceduralPoints; // 0x30
		private List<float> initialBoneDistances; // 0x38
		[Range] // 0x00000001801D6ED0-0x00000001801D6F30
		[Tooltip] // 0x00000001801D6ED0-0x00000001801D6F30
		public float BlendToOriginal; // 0x40
		[Tooltip] // 0x00000001801D70E0-0x00000001801D7110
		public bool LastBoneLeading; // 0x44
		private bool reversedChangeFlag; // 0x45
		private Vector3 lookUp; // 0x48
		[Tooltip] // 0x00000001801D7230-0x00000001801D7260
		public bool InversedVerticalRotation; // 0x54
		[Tooltip] // 0x00000001801D7390-0x00000001801D73C0
		public bool ConnectWithAnimator; // 0x55
		[Tooltip] // 0x00000001801D76B0-0x00000001801D76E0
		public bool AnimateLeadingBone; // 0x56
		[Tooltip] // 0x00000001801D78A0-0x00000001801D78D0
		public bool LeadingAnimateAfterMotion; // 0x57
		[Tooltip] // 0x00000001801D7AB0-0x00000001801D7AE0
		public bool PhysicalUpdate; // 0x58
		[Tooltip] // 0x00000001801D7D20-0x00000001801D7D50
		public bool AnchorToThis; // 0x59
		[Tooltip] // 0x00000001801D8000-0x00000001801D8030
		public Transform AnchorRoot; // 0x60
		[Tooltip] // 0x00000001801D8180-0x00000001801D81B0
		public Vector3 CustomAnchorRotationOffset; // 0x68
		[Tooltip] // 0x00000001801D8370-0x00000001801D83A0
		public bool QueueToLastUpdate; // 0x74
		[Tooltip] // 0x00000001801D8700-0x00000001801D8730
		public bool PositionsNotAnimated; // 0x75
		public List<bool> SelectivePosNotAnimated; // 0x78
		[Tooltip] // 0x00000001801D89C0-0x00000001801D89F0
		public bool RotationsNotAnimated; // 0x80
		public List<bool> SelectiveRotNotAnimated; // 0x88
		private int leadingBoneIndex; // 0x90
		private int reverser; // 0x94
		private int adjuster; // 0x98
		private List<FSpine_Point> staticCoordinates; // 0xA0
		private FSpine_FixingSet spineLookDirectionsSet; // 0xA8
		[Tooltip] // 0x00000001801D8B20-0x00000001801D8B50
		public List<Vector3> lookDirectionsAdditiveCorrection; // 0xB0
		[Tooltip] // 0x00000001801D8DA0-0x00000001801D8DD0
		public List<Vector3> ManualRotationOffsets; // 0xB8
		[Tooltip] // 0x00000001801D8DA0-0x00000001801D8DD0
		public List<Vector3> ManualPositionOffsets; // 0xC0
		[Tooltip] // 0x00000001801D9090-0x00000001801D90C0
		public bool RoundCorrection; // 0xC8
		private bool wasRoundCorrection; // 0xC9
		[Tooltip] // 0x00000001801D91F0-0x00000001801D9220
		public bool UnifyCorrection; // 0xCA
		private bool wasUnified; // 0xCB
		[Tooltip] // 0x00000001801D9360-0x00000001801D9390
		public bool StartAfterTPose; // 0xCC
		private Vector3 previousScale; // 0xD0
		private Transform[] anchorHelpers; // 0xE0
		private Transform anchorsContainer; // 0xE8
		private bool wasSourceAnimation; // 0xF0
		private bool initialized; // 0xF1
		private Vector3 previousPos; // 0xF4
		[Range] // 0x00000001801D96B0-0x00000001801D9700
		[Tooltip] // 0x00000001801D96B0-0x00000001801D9700
		public float PosSmoother; // 0x100
		[Range] // 0x00000001801D98C0-0x00000001801D9910
		[Tooltip] // 0x00000001801D98C0-0x00000001801D9910
		public float RotSmoother; // 0x104
		[Range] // 0x00000001801D9B00-0x00000001801D9B50
		[Tooltip] // 0x00000001801D9B00-0x00000001801D9B50
		public float AngleLimit; // 0x108
		[Range] // 0x00000001801D9C70-0x00000001801D9CC0
		[Tooltip] // 0x00000001801D9C70-0x00000001801D9CC0
		public float LimitSmoother; // 0x10C
		[Range] // 0x00000001801D9ED0-0x00000001801D9F20
		[Tooltip] // 0x00000001801D9ED0-0x00000001801D9F20
		public float StraightenSpeed; // 0x110
		public bool TurboStraighten; // 0x114
		[Range] // 0x00000001801DA190-0x00000001801DA1F0
		[Tooltip] // 0x00000001801DA190-0x00000001801DA1F0
		public float GoBackSpeed; // 0x118
		[Tooltip] // 0x00000001801DA310-0x00000001801DA340
		public Vector3 MainPivotOffset; // 0x11C
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Transform mainPivotOffsetTransform; // 0x128
		[Tooltip] // 0x00000001801DA5E0-0x00000001801DA610
		public Vector3 SegmentsPivotOffset; // 0x130
		[Tooltip] // 0x00000001801DAAB0-0x00000001801DAAE0
		public float DistancesMultiplier; // 0x13C
		public Transform rotationRef; // 0x140
	
		// Nested types
		[Serializable]
		public class FSpine_Point // TypeDefIndex: 10330
		{
			// Fields
			public Vector3 Position; // 0x10
			public Quaternion Rotation; // 0x1C
	
			// Constructors
			public FSpine_Point(); // 0x000000018173BC90-0x000000018173BD30
	
			// Methods
			public Vector3 TransformDirection(Vector3 dir); // 0x000000018173BBE0-0x000000018173BC90
		}
	
		[Serializable]
		public class FSpine_FixingSet // TypeDefIndex: 10331
		{
			// Fields
			public List<Vector3> Current; // 0x10
			public List<Vector3> Initial; // 0x18
			public List<Vector3> Rounded; // 0x20
			public List<Vector3> Reversed; // 0x28
			public List<Vector3> RoundedReversed; // 0x30
			public List<Vector3> Unified; // 0x38
	
			// Constructors
			public FSpine_FixingSet(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public List<Vector3> SetUnified(List<Vector3> toUnify); // 0x000000018173BA50-0x000000018173BB30
			internal void AddToAllNormal(Vector3 v); // 0x000000018173B670-0x000000018173B780
			internal FSpine_FixingSet Init(); // 0x000000018173B970-0x000000018173BA50
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <InitTPoseStartOffset>d__59 : IEnumerator<object> // TypeDefIndex: 10332
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FSpineAnimator <>4__this; // 0x20
			private int <counter>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <InitTPoseStartOffset>d__59(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181744FD0-0x0000000181745090
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181745090-0x00000001817450E0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <LateFixedUpdate>d__63 : IEnumerator<object> // TypeDefIndex: 10333
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FSpineAnimator <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <LateFixedUpdate>d__63(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001817450E0-0x0000000181745180
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181745180-0x00000001817451D0
		}
	
		// Constructors
		public FSpineAnimator(); // 0x0000000181732C40-0x0000000181732DB0
	
		// Methods
		private void Init(); // 0x000000018172D800-0x000000018172D8B0
		protected void ComputePredefinedVariables(); // 0x000000018172B1F0-0x000000018172C4B0
		protected virtual void PrepareSpinePoints(); // 0x000000018172E0E0-0x000000018172EBF0
		protected virtual void ConfigureBonesTransforms(); // 0x000000018172C4B0-0x000000018172C660
		private void OnEnable(); // 0x000000018172DC60-0x000000018172DCB0
		private void OnDisable(); // 0x000000018172DC20-0x000000018172DC60
		protected void Start(); // 0x00000001817323F0-0x0000000181732490
		[IteratorStateMachine] // 0x00000001801DAD00-0x00000001801DAD50
		private IEnumerator InitTPoseStartOffset(); // 0x000000018172D7A0-0x000000018172D800
		private void UpdateReverseHelpVariables(); // 0x0000000181732BC0-0x0000000181732C40
		private void ReposeSpine(); // 0x000000018172FB40-0x000000018172FD10
		private void LateUpdate(); // 0x000000018172D910-0x000000018172D920
		[IteratorStateMachine] // 0x00000001801DAE60-0x00000001801DAEB0
		private IEnumerator LateFixedUpdate(); // 0x000000018172D8B0-0x000000018172D910
		private void SpineMotion(); // 0x00000001817300F0-0x00000001817323F0
		private FSpine_Point GetLeadingBoneCoordinates(); // 0x000000018172CEB0-0x000000018172D7A0
		protected virtual void CalculateMotion(); // 0x000000018172A4C0-0x000000018172A580
		private void CalculateSpineBehaviourPosition(int index); // 0x000000018172A580-0x000000018172A920
		private void CalculateSpineBehaviourRotation(int index); // 0x000000018172A920-0x000000018172B1F0
		private void RefreshRefDirsOnReverse(); // 0x000000018172F7F0-0x000000018172F9B0
		private void RefreshDistances(); // 0x000000018172F210-0x000000018172F590
		private float SmootherValue(float val); // 0x0000000181730080-0x00000001817300F0
		protected Vector3 RoundPosDiff(Vector3 pos, int digits = 1 /* Metadata: 0x0077BAA5 */); // 0x000000018172FDB0-0x000000018172FEA0
		private Vector3 RoundToBiggestValue(Vector3 vec); // 0x000000018172FEA0-0x0000000181730080
		private void DrawFatRay(Vector3 origin, Vector3 dir); // 0x000000018172CAB0-0x000000018172CEB0
		private void DrawBoneLine(Vector3 origin, Vector3 dir); // 0x000000018172C6B0-0x000000018172CAB0
		public void RefreshSelectivePosNotAnimated(); // 0x000000018172F9B0-0x000000018172FA70
		public void RefreshSelectiveRotNotAnimated(); // 0x000000018172FA70-0x000000018172FB40
		public void RefreshManualPosOffs(); // 0x000000018172F590-0x000000018172F6C0
		public void RefreshManualRotOffs(); // 0x000000018172F6C0-0x000000018172F7F0
		public void OnDestroy(); // 0x000000018172D920-0x000000018172DC20
		private void RestoreBasePivotChildren(); // 0x000000018172FD10-0x000000018172FDB0
		private void OnValidate(); // 0x000000018172DCB0-0x000000018172E0E0
		private void RefreshDifferenceReference(); // 0x000000018172EBF0-0x000000018172F210
		public void TryAutoCorrect(Transform head = null); // 0x0000000181732490-0x0000000181732BC0
		public void DevLog(); // 0x000000018172C660-0x000000018172C6B0
	}
}
