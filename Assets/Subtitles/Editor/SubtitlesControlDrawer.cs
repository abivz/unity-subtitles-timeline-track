using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(SubtitlesControlBehaviour))]
public class SubtitlesControlDrawer : PropertyDrawer
{
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return EditorGUI.GetPropertyHeight(property, label, true);
    }
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        var subtitlesIndexProperty = property.FindPropertyRelative("SubtitlesIndex");
        EditorGUILayout.PropertyField(subtitlesIndexProperty);
    }
}