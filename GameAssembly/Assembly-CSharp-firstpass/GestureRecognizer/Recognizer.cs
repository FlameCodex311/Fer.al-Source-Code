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

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace GestureRecognizer
{
	public class Recognizer : UnityEngine.MonoBehaviour // TypeDefIndex: 10042
	{
		// Fields
		private const int Detail = 100; // Metadata: 0x0077ACF7
		[Range] // 0x0000000180271E90-0x0000000180271EB0
		public int numberOfThreads; // 0x18
		public List<GesturePattern> patterns; // 0x20
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 10043
		{
			// Fields
			public Recognizer <>4__this; // 0x10
			public GestureData data; // 0x18
			public bool normalizeScale; // 0x20
			public RecognitionResult result; // 0x28
	
			// Constructors
			public <>c__DisplayClass5_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <RecognizeCoroutine>b__0(); // 0x0000000180D36420-0x0000000180D364B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <RecognizeCoroutine>d__5 : IEnumerator<object> // TypeDefIndex: 10044
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <RecognizeCoroutine>d__5(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180D35D80-0x0000000180D35FF0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180D35FF0-0x0000000180D36040
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 10045
		{
			// Fields
			public List<int> list; // 0x10
	
			// Constructors
			public <>c__DisplayClass7_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <GenPermutations>b__0(int a, int b); // 0x0000000180D364B0-0x0000000180D36590
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass8_0 // TypeDefIndex: 10046
		{
			// Fields
			public GestureData data; // 0x10
	
			// Constructors
			public <>c__DisplayClass8_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal GestureLine <makePermutation>b__0(int e); // 0x0000000180D36590-0x0000000180D36600
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass9_0 // TypeDefIndex: 10047
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
			public <>c__DisplayClass9_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal GestureData <findPattern>b__0(List<int> e); // 0x0000000180D36600-0x0000000180D36730
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass9_1 // TypeDefIndex: 10048
		{
			// Fields
			public int beginIndex; // 0x10
			public int endIndex; // 0x14
			public <>c__DisplayClass9_0 CS$<>8__locals1; // 0x18
	
			// Constructors
			public <>c__DisplayClass9_1(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <findPattern>b__1(); // 0x0000000180D36730-0x0000000180D36910
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 10049
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<Score, float> <>9__11_0; // 0x08
			public static Func<Score, float> <>9__11_1; // 0x10
			public static Func<Score, float> <>9__11_2; // 0x18
	
			// Constructors
			static <>c(); // 0x0000000180D36910-0x0000000180D36970
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal float <CalcScore>b__11_0(Score e); // 0x0000000180D36040-0x0000000180D36050
			internal float <CalcScore>b__11_1(Score e); // 0x0000000180D36050-0x0000000180D36070
			internal float <CalcScore>b__11_2(Score e); // 0x0000000180D36070-0x0000000180D36080
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass22_0 // TypeDefIndex: 10050
		{
			// Fields
			public Rect rect; // 0x10
			public Func<Vector2, Vector2> <>9__0; // 0x20
	
			// Constructors
			public <>c__DisplayClass22_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal Vector2 <NormalizeScale>b__0(Vector2 e); // 0x0000000180D36080-0x0000000180D360A0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass25_0 // TypeDefIndex: 10051
		{
			// Fields
			public float totalDist; // 0x10
	
			// Constructors
			public <>c__DisplayClass25_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal float <NormalizeDistribution>b__0(float e); // 0x0000000180D360A0-0x0000000180D360B0
		}
	
		// Constructors
		public Recognizer(); // 0x0000000180D2BD60-0x0000000180D2BD70
	
		// Methods
		public RecognitionResult Recognize(GestureData data, bool normalizeScale = true /* Metadata: 0x0077ACF1 */); // 0x0000000180D2B8C0-0x0000000180D2B9D0
		public void RecognizeAsync(GestureData data, Action<RecognitionResult> callback, bool normalizeScale = true /* Metadata: 0x0077ACF2 */); // 0x0000000180D2B790-0x0000000180D2B830
		[IteratorStateMachine] // 0x000000018028F920-0x000000018028F970
		private IEnumerator RecognizeCoroutine(GestureData data, Action<RecognitionResult> callback, bool normalizeScale); // 0x0000000180D2B830-0x0000000180D2B8C0
		private GestureData NormalizeData(GestureData data, bool normalizeScale); // 0x0000000180D2AF00-0x0000000180D2AF50
		private static List<List<int>> GenPermutations(List<int> list, int low = 0 /* Metadata: 0x0077ACF3 */); // 0x0000000180D2A770-0x0000000180D2ABD0
		private GestureData makePermutation(List<int> indexes, GestureData data); // 0x0000000180D2C120-0x0000000180D2C240
		private RecognitionResult findPattern(GestureData queryData, bool normalizeScale); // 0x0000000180D2BD70-0x0000000180D2C120
		private RecognitionResult SearchThroughPatterns(int beginIndex, int endIndex, GestureData queryData, bool normalizeScale, List<GestureData> permutations, List<GestureData> singlePermutation); // 0x0000000180D2B9D0-0x0000000180D2BD60
		private Score CalcScore(GestureData data1, GestureData data2, bool useLinesDirections); // 0x0000000180D29F10-0x0000000180D2A540
		private List<float> CalcAngles(List<Vector2> points); // 0x0000000180D28BF0-0x0000000180D28DD0
		private List<float> CalcCurvature(List<Vector2> points); // 0x0000000180D29100-0x0000000180D29370
		private Score CalcListScore(List<Vector2> points1, List<Vector2> points2, bool points2IsClosed); // 0x0000000180D297A0-0x0000000180D299B0
		private Score CalcCircularListScore(List<Vector2> points1, List<Vector2> points2); // 0x0000000180D28DD0-0x0000000180D28F70
		private Score CalcLinearListScore(List<Vector2> points1, List<Vector2> points2); // 0x0000000180D29370-0x0000000180D297A0
		private float CalcPositionDistance(List<Vector2> points1, List<Vector2> points2); // 0x0000000180D299B0-0x0000000180D29B30
		private float CalcCurvatureDistance(List<Vector2> points1, List<Vector2> points2); // 0x0000000180D28F70-0x0000000180D29100
		private float CalcAngleDistance(List<Vector2> points1, List<Vector2> points2); // 0x0000000180D28A50-0x0000000180D28BF0
		private Rect CalcRect(GestureData data); // 0x0000000180D29B30-0x0000000180D29F10
		private GestureData NormalizeClosedLines(GestureData data); // 0x0000000180D2ABD0-0x0000000180D2AF00
		private GestureData NormalizeScale(GestureData data); // 0x0000000180D2B490-0x0000000180D2B790
		private Vector2 FindByNormalized(List<Vector2> vs, List<float> ts, float t); // 0x0000000180D2A540-0x0000000180D2A770
		private GestureData NormalizeDistribution(GestureData data, int n); // 0x0000000180D2AF50-0x0000000180D2B1D0
		private List<Vector2> NormalizeDistribution(List<Vector2> path, int n); // 0x0000000180D2B1D0-0x0000000180D2B490
	}
}
