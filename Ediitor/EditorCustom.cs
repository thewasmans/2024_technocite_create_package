using UnityEditor;
using UnityEngine;

namespace com.thewasmans.projectcreator
{
    public class EditorCustom : Editor
    {
        void Start()
        {
            Debug.Log("Start Editor");
        }

        void Update()
        {
            Debug.Log("Update Editor");
        }
    }
}
