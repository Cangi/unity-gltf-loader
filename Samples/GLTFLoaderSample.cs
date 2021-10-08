using UnityEngine;
using ReadyPlayerMe;

public class GLTFLoaderSample : MonoBehaviour
{
	// Start is called before the first frame update
	private void Start()
	{
		// Using glb file with .bytes extension in Resources folder here
		// You can replace the importer parameter with result of web request
		TextAsset asset = Resources.Load<TextAsset>("avatar");

		// Import asynchronously
		AvatarImporter.ImportAsync(asset.bytes, OnImportFinished);

		// Import directly, locks main thread
		GameObject avatar = AvatarImporter.Import(asset.bytes);
		avatar.name = "Loaded Direct";
		avatar.transform.position = new Vector3(0.3f, 0, 0);
	}
	
	private void OnImportFinished(GameObject avatar)
	{
		avatar.name = "Loaded Async";
		avatar.transform.position = new Vector3(-0.3f, 0, 0);
	}
}
