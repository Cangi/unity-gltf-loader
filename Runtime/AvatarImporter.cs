using System;
using UnityEngine;
using Siccity.GLTFUtility;

namespace ReadyPlayerMe
{
	public class AvatarImporter
	{
		private static readonly ImportSettings Settings = new ImportSettings() { useLegacyClips = false };

		public static void ImportAsync(byte[] bytes, Action<GameObject> onImportFinished)
		{
			Importer.ImportGLBAsync(bytes, Settings, onImportFinished);
		}

		public static GameObject Import(byte[] bytes)
		{
			return Importer.LoadFromBytes(bytes, Settings);
		}
	}
}
