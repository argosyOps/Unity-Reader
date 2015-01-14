using UnityEngine;
using UnityEditor;

public class ExportBundle : MonoBehaviour {
	[MenuItem ("Assets/Build AssetBundle From Selection - Track dependencies")]
	static void DoExport() {
		string str = EditorUtility.SaveFilePanel("Save Bundle...", Application.dataPath, Selection.activeObject.name, "assetbundle");
		if (str.Length != 0) {
			BuildPipeline.BuildAssetBundle(Selection.activeObject, Selection.objects, str, BuildAssetBundleOptions.CompleteAssets, BuildTarget.iPhone);
		}
	}
}