/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace GestureRecognizer
{
	public class Recognizer : UnityEngine.MonoBehaviour // TypeDefIndex: 9588
	{
		// Fields
		private const int Detail = 100; // Metadata: 0x00745245
		[Range] // 0x00000001800EA000-0x00000001800EA020
		public int numberOfThreads; // 0x18
		public List<GesturePattern> patterns; // 0x20
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 9589
		{
			// Fields
			public Recognizer <>4__this; // 0x10
			public GestureData data; // 0x18
			public bool normalizeScale; // 0x20
			public RecognitionResult result; // 0x28
	
			// Constructors
			public <>c__DisplayClass5_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <RecognizeCoroutine>b__0(); // 0x000000018165B090-0x000000018165B120
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <RecognizeCoroutine>d__5 : IEnumerator<object> // TypeDefIndex: 9590
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Recognizer <>4__this; // 0x20
			public GestureData data; // 0x28
			public bool normalizeScale; // 0x30
			private <>c__DisplayClass5_0 <>8__1; // 0x38
			public Action<RecognitionResult> callback; // 0x40
			private Stopwatch <timer>5__2; // 0x48
			private Thread <thread>5__3; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <RecognizeCoroutine>d__5(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018165A9D0-0x000000018165AC50
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018165AC50-0x000000018165ACA0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 9591
		{
			// Fields
			public List<int> list; // 0x10
	
			// Constructors
			public <>c__DisplayClass7_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <GenPermutations>b__0(int a, int b); // 0x000000018165B120-0x000000018165B210
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass8_0 // TypeDefIndex: 9592
		{
			// Fields
			public GestureData data; // 0x10
	
			// Constructors
			public <>c__DisplayClass8_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal GestureLine <makePermutation>b__0(int e); // 0x000000018165B210-0x000000018165B280
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass9_0 // TypeDefIndex: 9593
		{
			// Fields
			public Recognizer <>4__this; // 0x10
			public GestureData queryData; // 0x18
			public bool normalizeScale; // 0x20
			public List<GestureData> permutations; // 0x28
			public List<GestureData> singlePermutation; // 0x30
			public Score bestScore; // 0x38
			public GesturePattern bestGesture; // 0x48
	
			// Constructors
			public <>c__DisplayClass9_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal GestureData <findPattern>b__0(List<int> e); // 0x000000018165B280-0x000000018165B3C0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass9_1 // TypeDefIndex: 9594
		{
			// Fields
			public int beginIndex; // 0x10
			public int endIndex; // 0x14
			public <>c__DisplayClass9_0 CS$<>8__locals1; // 0x18
	
			// Constructors
			public <>c__DisplayClass9_1(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <findPattern>b__1(); // 0x000000018165B3C0-0x000000018165B5B0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 9595
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<Score, float> <>9__11_0; // 0x08
			public static Func<Score, float> <>9__11_1; // 0x10
			public static Func<Score, float> <>9__11_2; // 0x18
	
			// Constructors
			static <>c(); // 0x000000018165B5B0-0x000000018165B610
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal float <CalcScore>b__11_0(Score e); // 0x000000018165ACA0-0x000000018165ACB0
			internal float <CalcScore>b__11_1(Score e); // 0x000000018165ACB0-0x000000018165ACD0
			internal float <CalcScore>b__11_2(Score e); // 0x000000018165ACD0-0x000000018165ACE0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass22_0 // TypeDefIndex: 9596
		{
			// Fields
			public Rect rect; // 0x10
			public Func<Vector2, Vector2> <>9__0; // 0x20
	
			// Constructors
			public <>c__DisplayClass22_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal Vector2 <NormalizeScale>b__0(Vector2 e); // 0x000000018165ACE0-0x000000018165AD00
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass25_0 // TypeDefIndex: 9597
		{
			// Fields
			public float totalDist; // 0x10
	
			// Constructors
			public <>c__DisplayClass25_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal float <NormalizeDistribution>b__0(float e); // 0x000000018165AD00-0x000000018165AD10
		}
	
		// Constructors
		public Recognizer(); // 0x00000001816580E0-0x00000001816580F0
	
		// Methods
		public RecognitionResult Recognize(GestureData data, bool normalizeScale = true /* Metadata: 0x0074523F */); // 0x0000000181657C30-0x0000000181657D40
		public void RecognizeAsync(GestureData data, Action<RecognitionResult> callback, bool normalizeScale = true /* Metadata: 0x00745240 */); // 0x0000000181657B00-0x0000000181657BA0
		[IteratorStateMachine] // 0x00000001800EA100-0x00000001800EA150
		private IEnumerator RecognizeCoroutine(GestureData data, Action<RecognitionResult> callback, bool normalizeScale); // 0x0000000181657BA0-0x0000000181657C30
		private GestureData NormalizeData(GestureData data, bool normalizeScale); // 0x0000000181657250-0x00000001816572A0
		private static List<List<int>> GenPermutations(List<int> list, int low = 0 /* Metadata: 0x00745241 */); // 0x0000000181656AA0-0x0000000181656F20
		private GestureData makePermutation(List<int> indexes, GestureData data); // 0x00000001816584C0-0x00000001816585E0
		private RecognitionResult findPattern(GestureData queryData, bool normalizeScale); // 0x00000001816580F0-0x00000001816584C0
		private RecognitionResult SearchThroughPatterns(int beginIndex, int endIndex, GestureData queryData, bool normalizeScale, List<GestureData> permutations, List<GestureData> singlePermutation); // 0x0000000181657D40-0x00000001816580E0
		private Score CalcScore(GestureData data1, GestureData data2, bool useLinesDirections); // 0x0000000181656220-0x0000000181656870
		private List<float> CalcAngles(List<Vector2> points); // 0x0000000181654EC0-0x00000001816550A0
		private List<float> CalcCurvature(List<Vector2> points); // 0x00000001816553D0-0x0000000181655650
		private Score CalcListScore(List<Vector2> points1, List<Vector2> points2, bool points2IsClosed); // 0x0000000181655A90-0x0000000181655CB0
		private Score CalcCircularListScore(List<Vector2> points1, List<Vector2> points2); // 0x00000001816550A0-0x0000000181655240
		private Score CalcLinearListScore(List<Vector2> points1, List<Vector2> points2); // 0x0000000181655650-0x0000000181655A90
		private float CalcPositionDistance(List<Vector2> points1, List<Vector2> points2); // 0x0000000181655CB0-0x0000000181655E30
		private float CalcCurvatureDistance(List<Vector2> points1, List<Vector2> points2); // 0x0000000181655240-0x00000001816553D0
		private float CalcAngleDistance(List<Vector2> points1, List<Vector2> points2); // 0x0000000181654D10-0x0000000181654EC0
		private Rect CalcRect(GestureData data); // 0x0000000181655E30-0x0000000181656220
		private GestureData NormalizeClosedLines(GestureData data); // 0x0000000181656F20-0x0000000181657250
		private GestureData NormalizeScale(GestureData data); // 0x00000001816577F0-0x0000000181657B00
		private Vector2 FindByNormalized(List<Vector2> vs, List<float> ts, float t); // 0x0000000181656870-0x0000000181656AA0
		private GestureData NormalizeDistribution(GestureData data, int n); // 0x00000001816572A0-0x0000000181657520
		private List<Vector2> NormalizeDistribution(List<Vector2> path, int n); // 0x0000000181657520-0x00000001816577F0
	}
}
