using UnityEngine;
using DialogueSystem.Struct;

namespace DialogueSystem.Runtime
{
    [CreateAssetMenu(menuName = "Dialogue", fileName = "Dialogue/file")]
    public class Dialogue : ScriptableObject
    {
        public DialogueFile file;
    }
}
