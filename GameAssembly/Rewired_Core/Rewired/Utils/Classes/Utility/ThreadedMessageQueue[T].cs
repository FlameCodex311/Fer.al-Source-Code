/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal class ThreadedMessageQueue<T> : IDisposable // TypeDefIndex: 7065
	{
		// Fields
		private readonly int hMtRxXBbrWeYpezUQLLczRaToxZ;
		private readonly int GqCCenQTbFxsqZsybplDOPJvqBW;
		private readonly int wUnLlcywpCShTdpQqexYzWSCixo;
		private readonly bool DCubnnifBIfgImIgPMpGRLhIPLtf;
		private ThreadHelper habGSklQHfgBqWkyroQbBEtCUJR;
		private Queue<T> NHGluDnhuAFTtksKKBCDlzRFgXEa;
		private Queue<T> efPTRIgSUnnOmoHqTlMToopSdbd;
		private bool NUnAFZNgoriwvYnCEOYspThIrYA;
		private bool ZjOOLblNcYQwrXXNEEJgJyiCsWf;
		private Action<T> nwPujvjGcLDZmgYWVXBAmTnUCyTg;
		private bool vEblpmllYIOuQHCXVghuIpihdSG;
	
		// Constructors
		public ThreadedMessageQueue(int maxQueueSize, int threadRefreshRateFPS, int threadAutoKillTimeoutMS, bool threadBlockOnStartAndStop, Action<T> messageReceiverDelegate);
	
		// Methods
		public void Enqueue(T message);
		private bool DeRyKKaIFeIgBBjcstmktRxedrNm();
		private bool DAtaDXybNYHmfIBvCpqNGFfILOkf();
		private void LvcshbojhfLatrMhEAEpjsAdNsb();
		private void NLJJNAtrdXKtsPILrseWHDPkKKr();
		public void Dispose();
		~ThreadedMessageQueue();
		protected void Dispose(bool disposing);
	}
}
