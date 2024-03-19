using System;

namespace DialogueSystem.Runtime.DialogueStruct
{
    [Serializable]
    public struct DialogueLine
    {
        public string name;
        public string dialogueText;
        public Emotion emotion;
        // TODO add events
    }
}
