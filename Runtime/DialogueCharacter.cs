using DialogueSystem.Struct;
using UnityEngine;

namespace DialogueSystem.Runtime
{
    [CreateAssetMenu(menuName = "Character", fileName = "Character")]
    public class DialogueCharacter : ScriptableObject
    {
        public Character character;
    }
}