using System;

namespace DialogueSystem.Struct
{
    [Serializable]
    public class Character
    {
        public string name;
        public Emotion[] characterEmotions;
    }
}