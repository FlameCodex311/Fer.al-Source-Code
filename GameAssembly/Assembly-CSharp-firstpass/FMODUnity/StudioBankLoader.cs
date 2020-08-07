/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMODUnity
{
	[AddComponentMenu] // 0x00000001801CFF40-0x00000001801CFF70
	public class StudioBankLoader : UnityEngine.MonoBehaviour // TypeDefIndex: 10310
	{
		// Fields
		public LoaderGameEvent LoadEvent; // 0x18
		public LoaderGameEvent UnloadEvent; // 0x1C
		[BankRef] // 0x00000001801CEA70-0x00000001801CEA80
		public List<string> Banks; // 0x20
		public string CollisionTag; // 0x28
		public bool PreloadSamples; // 0x30
		private bool isQuitting; // 0x31
	
		// Constructors
		public StudioBankLoader(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void HandleGameEvent(LoaderGameEvent gameEvent); // 0x0000000180D33630-0x0000000180D33670
		private void Start(); // 0x0000000180D33A40-0x0000000180D33AD0
		private void OnApplicationQuit(); // 0x0000000180D33830-0x0000000180D33840
		private void OnDestroy(); // 0x0000000180D33840-0x0000000180D33880
		private void OnTriggerEnter(Collider other); // 0x0000000180D338F0-0x0000000180D33960
		private void OnTriggerExit(Collider other); // 0x0000000180D339D0-0x0000000180D33A40
		private void OnTriggerEnter2D(Collider2D other); // 0x0000000180D33880-0x0000000180D338F0
		private void OnTriggerExit2D(Collider2D other); // 0x0000000180D33960-0x0000000180D339D0
		public void Load(); // 0x0000000180D33670-0x0000000180D33830
		public void Unload(); // 0x0000000180D33AD0-0x0000000180D33C10
	}
}
