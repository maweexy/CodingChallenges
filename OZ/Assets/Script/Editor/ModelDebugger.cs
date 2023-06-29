using UnityEngine;
using UnityEditor;

public class ModelDebugger : EditorWindow
{
    [MenuItem("DevTools/ModelDebugger")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(ModelDebugger));
    }

    public MeshFilter[] meshFilters;
    private Vector2 scrollPosition;
    // Update is called once per frame
    private void OnGUI()
    {
        GUILayout.Label("List of all Mesh Renderers", EditorStyles.boldLabel);

        scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition);

        if (GUILayout.Button("Grab All Booties"))
        {
            meshFilters = FindObjectsOfType<MeshFilter>();
        }

        foreach (MeshFilter filter in meshFilters)
        {
            EditorGUILayout.ObjectField(filter.gameObject.name, filter, typeof(MeshFilter), true);

            MeshFilter trifilter = filter.GetComponent<MeshFilter>();
            if (trifilter != null && trifilter.sharedMesh != null)
            {
                int triangleCount = trifilter.sharedMesh.triangles.Length / 3;
                EditorGUILayout.LabelField("Triangle Count: " + triangleCount);
            }
        }
        EditorGUILayout.EndScrollView();
    }
}
