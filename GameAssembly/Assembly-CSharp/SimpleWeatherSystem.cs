/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using DG.Tweening.Core;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SimpleWeatherSystem : ManagedBehaviour // TypeDefIndex: 14286
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static SimpleWeatherSystem <instance>k__BackingField; // 0x00
	public Renderer skybox; // 0x50
	public Renderer skyboxBottom; // 0x58
	public Renderer cloudLayer1; // 0x60
	public Renderer cloudLayer2; // 0x68
	public Renderer backgroundObj; // 0x70
	public Light mainSceneLight; // 0x78
	[EnumList] // 0x0000000180207880-0x00000001802078F0
	[Space] // 0x0000000180207880-0x00000001802078F0
	public List<WeatherData> weatherData; // 0x80
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WeatherState <currentWeather>k__BackingField; // 0x88
	private Material _skyboxMaterial; // 0x90
	private Material _skyboxBottomMaterial; // 0x98
	private Material _cloudLayer1Material; // 0xA0
	private Material _cloudLayer2Material; // 0xA8
	private Material _backgroundObjMaterial; // 0xB0
	private bool _activeSceneSet; // 0xB8

	// Properties
	public static SimpleWeatherSystem instance { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018076E880-0x000000018076E8C0 0x000000018076E8C0-0x000000018076E900
	public WeatherState currentWeather { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803CCE20-0x00000001803CCE30 0x00000001803CCEB0-0x00000001803CCEC0

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <WaitForScene>d__24 : IEnumerator<object> // TypeDefIndex: 14287
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SimpleWeatherSystem <>4__this; // 0x20
		public Action inCallback; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <WaitForScene>d__24(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180777B80-0x0000000180777C80
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180777C80-0x0000000180777CD0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass28_0 // TypeDefIndex: 14288
	{
		// Fields
		public SkyboxColorInfo skyboxColors; // 0x10

		// Constructors
		public <>c__DisplayClass28_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <UpdateSkyboxColors>b__0(); // 0x0000000180777580-0x0000000180777A70
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14289
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static DOGetter<Color> <>9__28_1; // 0x08
		public static DOSetter<Color> <>9__28_2; // 0x10
		public static DOGetter<float> <>9__28_3; // 0x18
		public static DOSetter<float> <>9__28_4; // 0x20
		public static DOGetter<float> <>9__28_5; // 0x28
		public static DOSetter<float> <>9__28_6; // 0x30

		// Constructors
		static <>c(); // 0x0000000180777AC0-0x0000000180777B20
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal Color <UpdateSkyboxColors>b__28_1(); // 0x00000001804ECC10-0x00000001804ECC40
		internal void <UpdateSkyboxColors>b__28_2(Color x); // 0x00000001804ECC40-0x00000001804ECC60
		internal float <UpdateSkyboxColors>b__28_3(); // 0x0000000180777200-0x0000000180777210
		internal void <UpdateSkyboxColors>b__28_4(float x); // 0x0000000180777210-0x0000000180777220
		internal float <UpdateSkyboxColors>b__28_5(); // 0x00000001804ECC60-0x00000001804ECC70
		internal void <UpdateSkyboxColors>b__28_6(float x); // 0x00000001804ECC70-0x00000001804ECC80
	}

	// Constructors
	public SimpleWeatherSystem(); // 0x000000018076E820-0x000000018076E880

	// Methods
	public override void MStart(); // 0x000000018076D9A0-0x000000018076D9F0
	public override void MOnDestroy(); // 0x000000018076D960-0x000000018076D9A0
	public override void MUpdate(); // 0x000000018076D9F0-0x000000018076DAF0
	[IteratorStateMachine] // 0x0000000180208460-0x00000001802084B0
	private IEnumerator WaitForScene(Action inCallback); // 0x000000018076E7B0-0x000000018076E820
	public void SetWeatherState(WeatherState inState); // 0x000000018076DAF0-0x000000018076DCF0
	private void UpdateGameObjectRefs(WeatherData inData, bool inEnabled); // 0x000000018076E070-0x000000018076E290
	private void StopCurrentWeatherFx(); // 0x000000018076DEB0-0x000000018076E070
	private void UpdateSkyboxColors(SkyboxColorInfo skyboxColors); // 0x000000018076E290-0x000000018076E7B0
	private void SetupSkyboxMaterials(); // 0x000000018076DCF0-0x000000018076DEB0
	[DeMethodButton] // 0x0000000180208640-0x00000001802086A0
	private void ChangeWeatherNow(); // 0x000000018076D940-0x000000018076D960
	private void PickNextWeatherState(); // 0x000000018076D940-0x000000018076D960
}

