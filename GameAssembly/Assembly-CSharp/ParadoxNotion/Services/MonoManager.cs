/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Services
{
	public class MonoManager : MonoBehaviour // TypeDefIndex: 15856
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action onUpdate; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action onLateUpdate; // 0x28
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action onFixedUpdate; // 0x30
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action onApplicationQuit; // 0x38
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action<bool> onApplicationPause; // 0x40
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action onGUI; // 0x48
		private static bool isQuiting; // 0x00
		private static MonoManager _current; // 0x08
	
		// Properties
		public static MonoManager current { get; } // 0x00000001804D81F0-0x00000001804D83B0 
	
		// Events
		public event Action onUpdate {
			add; // 0x00000001804D8150-0x00000001804D81F0
			remove; // 0x00000001804D86D0-0x00000001804D8770
		}
		public event Action onLateUpdate {
			add; // 0x00000001804D80B0-0x00000001804D8150
			remove; // 0x00000001804D8630-0x00000001804D86D0
		}
		public event Action onFixedUpdate {
			add; // 0x00000001804D7F70-0x00000001804D8010
			remove; // 0x00000001804D84F0-0x00000001804D8590
		}
		public event Action onApplicationQuit {
			add; // 0x00000001804D7ED0-0x00000001804D7F70
			remove; // 0x00000001804D8450-0x00000001804D84F0
		}
		public event Action<bool> onApplicationPause {
			add; // 0x00000001804D7E30-0x00000001804D7ED0
			remove; // 0x00000001804D83B0-0x00000001804D8450
		}
		public event Action onGUI {
			add; // 0x00000001804D8010-0x00000001804D80B0
			remove; // 0x00000001804D8590-0x00000001804D8630
		}
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 15857
		{
			NormalUpdate = 0,
			LateUpdate = 1,
			FixedUpdate = 2
		}
	
		// Constructors
		public MonoManager(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		[RuntimeInitializeOnLoadMethod] // 0x0000000180238AA0-0x0000000180238AC0
		public static void FastPlayModeReset(); // 0x00000001804D7AF0-0x00000001804D7B40
		[RuntimeInitializeOnLoadMethod] // 0x0000000180238AA0-0x0000000180238AC0
		private static void Purge(); // 0x00000001804D7C20-0x00000001804D7C60
		public static void Create(); // 0x00000001804D7AB0-0x00000001804D7AF0
		public void AddUpdateCall(UpdateMode mode, Action call); // 0x00000001804D77C0-0x00000001804D7970
		public void RemoveUpdateCall(UpdateMode mode, Action call); // 0x00000001804D7C60-0x00000001804D7E10
		protected void Awake(); // 0x00000001804D7970-0x00000001804D7AB0
		protected void OnApplicationQuit(); // 0x00000001804D7BD0-0x00000001804D7C20
		protected void OnApplicationPause(bool isPause); // 0x00000001804D7B80-0x00000001804D7BD0
		protected void Update(); // 0x00000001804D7E10-0x00000001804D7E30
		protected void LateUpdate(); // 0x00000001804D7B60-0x00000001804D7B80
		protected void FixedUpdate(); // 0x00000001804D7B40-0x00000001804D7B60
	}
}
