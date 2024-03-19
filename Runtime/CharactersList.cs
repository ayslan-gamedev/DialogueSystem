using System.Collections.Generic;
using UnityEngine;
using DialogueSystem.Struct;
using UnityEngine.Serialization;

namespace DialogueSystem.Runtime
{
    [CreateAssetMenu(menuName = "Characters", fileName = "Characters")]
    public class CharactersList : ScriptableObject
    {
        public List<Character> characters;
        
    }
}