/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Config;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001801D2C60-0x00000001801D2CD0
	[CustomObfuscation] // 0x00000001801D2C60-0x00000001801D2CD0
	internal class UpdateLoopDataSet<T> // TypeDefIndex: 5930
		where T : class
	{
		// Fields
		private const int CLLnQINqTMTQVzlhFAFgHOPGrfz = 0; // Metadata: 0x0076382C
		private ImxYRenFXHvEsddAbhnPSGhjcJJ IOSOipdrMRjjDWsxWpyEXiaFCiD;
		private int kswtyGmohuOlSPFexjaYYjNtnYw;
		public readonly int fixedUpdateSetIndex;
		private readonly int[] lSNIHeHuthvpdsUkLYNMQLmHAaG;
		private readonly ImxYRenFXHvEsddAbhnPSGhjcJJ[] otizAYZCokzxsCxXuUdnNnkkePI;
		private UpdateLoopType aJpcdRablpjHizUUMntZPgPhvFC;
	
		// Properties
		public T Current { get; }
		public int Count { get; }
		public T this[int index] { get => default; set {} }
	
		// Nested types
		private class ImxYRenFXHvEsddAbhnPSGhjcJJ // TypeDefIndex: 5931
		{
			// Fields
			public readonly UpdateLoopType wWvAsBevxHsqtvaIJuSLgaJqAjGk;
			public T INvimzVaioFjwNQRVBRIVLeIhgc;
	
			// Constructors
			public ImxYRenFXHvEsddAbhnPSGhjcJJ(UpdateLoopType updateLoop);
		}
	
		// Constructors
		public UpdateLoopDataSet(UpdateLoopSetting updateLoops);
		public UpdateLoopDataSet(UpdateLoopSetting updateLoops, Func<T> instantiatorDelegate);
	
		// Methods
		public void SetUpdateLoop(UpdateLoopType updateLoop);
		public T Get(int index);
		public T Get(UpdateLoopType updateLoop);
		public void Set(int index, T item);
		protected UpdateLoopType GetUpdateLoopType(int index);
	}
}
