using System;

namespace DialogueSystem.Struct
{
    [Serializable]
    public struct DialogueFile
    {
        public DialogueLine[] dialogueTexts;
        public DialogueChoice[] dialogueChoices;
    }
}