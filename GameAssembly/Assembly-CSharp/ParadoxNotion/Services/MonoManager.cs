/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Services
{
	public class MonoManager : MonoBehaviour // TypeDefIndex: 15271
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action onUpdate; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action onLateUpdate; // 0x28
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action onFixedUpdate; // 0x30
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action onGUI; // 0x38
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action onApplicationQuit; // 0x40
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action<bool> onApplicationPause; // 0x48
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static bool <isQuiting>k__BackingField; // 0x00
		private static MonoManager _current; // 0x08
	
		// Properties
		public static bool isQuiting { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018116B470-0x000000018116B4B0 0x000000018116B870-0x000000018116B8B0
		public static MonoManager current { get; } // 0x000000018116B310-0x000000018116B470 
	
		// Events
		public event Action onUpdate {
			add; // 0x000000018116B270-0x000000018116B310
			remove; // 0x000000018116B7D0-0x000000018116B870
		}
		public event Action onLateUpdate {
			add; // 0x000000018116B1D0-0x000000018116B270
			remove; // 0x000000018116B730-0x000000018116B7D0
		}
		public event Action onFixedUpdate {
			add; // 0x000000018116B090-0x000000018116B130
			remove; // 0x000000018116B5F0-0x000000018116B690
		}
		public event Action onGUI {
			add; // 0x000000018116B130-0x000000018116B1D0
			remove; // 0x000000018116B690-0x000000018116B730
		}
		public event Action onApplicationQuit {
			add; // 0x000000018116AFF0-0x000000018116B090
			remove; // 0x000000018116B550-0x000000018116B5F0
		}
		public event Action<bool> onApplicationPause {
			add; // 0x000000018116AF50-0x000000018116AFF0
			remove; // 0x000000018116B4B0-0x000000018116B550
		}
	
		// Constructors
		public MonoManager(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		[RuntimeInitializeOnLoadMethod] // 0x00000001800C1A80-0x00000001800C1AA0
		public static void FastPlayModeReset(); // 0x000000018116AE40-0x000000018116AEB0
		public static void Create(); // 0x000000018116AE00-0x000000018116AE40
		protected void OnApplicationQuit(); // 0x000000018116AF00-0x000000018116AF50
		protected void OnApplicationPause(bool isPause); // 0x000000018116AEB0-0x000000018116AF00
		protected void Awake(); // 0x000000018116ACC0-0x000000018116AE00
		protected void Update(); // 0x0000000180DDB0D0-0x0000000180DDB0F0
		protected void LateUpdate(); // 0x0000000180DDB0B0-0x0000000180DDB0D0
		protected void FixedUpdate(); // 0x0000000180626E60-0x0000000180626E80
	}
}
