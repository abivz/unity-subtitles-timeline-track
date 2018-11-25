using UnityEngine;
using UnityEditor;
using UnityEditorInternal;

[CustomEditor(typeof(SubtitlesAsset))]
public class SubtitlesAssetEditor : Editor 
{
    const string SUBTITLES_ASSET_ARRAY_FIELD_NAME = "Subtitles";
    const bool LIST_DRAGGABLE = true;
    const bool LIST_DISPLAY_HEADER = true;
    const bool LIST_DISPLAY_ADD_BUTTON = true;
    const bool LIST_DISPLAY_REMOVE_BUTTON = true;

    ReorderableList _list;
	
	void OnEnable()
    {
		_list = new ReorderableList(serializedObject, 
        		serializedObject.FindProperty(SUBTITLES_ASSET_ARRAY_FIELD_NAME), 
        		LIST_DRAGGABLE, LIST_DISPLAY_HEADER, LIST_DISPLAY_ADD_BUTTON, LIST_DISPLAY_REMOVE_BUTTON);

        _list.drawElementCallback = OnListDrawElement;
	}
	
	public override void OnInspectorGUI()
    {
		serializedObject.Update();
		_list.DoLayoutList();
		serializedObject.ApplyModifiedProperties();
	}

    void OnListDrawElement(Rect rect, int index, bool isActive, bool isFocused)
    {
        var subtitlesString = _list.serializedProperty.GetArrayElementAtIndex(index);

        DrawProperty(new Rect(rect.x, rect.y, rect.width, EditorGUIUtility.singleLineHeight), subtitlesString);
    }

    void DrawProperty(Rect rect, SerializedProperty serializedProperty)
    {
        EditorGUI.PropertyField(rect, serializedProperty, GUIContent.none);
    }
}