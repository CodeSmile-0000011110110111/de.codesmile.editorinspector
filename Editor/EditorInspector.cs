using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace CodeSmileEditor
{
    public class EditorInspector : EditorWindow
    {
        [SerializeField]
        private VisualTreeAsset m_VisualTreeAsset = default;

        [MenuItem("Window/CodeSmile/Editor Inspector")]
        public static void ShowExample()
        {
            EditorInspector window = GetWindow<EditorInspector>();
            window.titleContent = new GUIContent("Editor Inspector");
        }

        public void CreateGUI()
        {
            rootVisualElement.Add(m_VisualTreeAsset.Instantiate());
        }
    }
}
