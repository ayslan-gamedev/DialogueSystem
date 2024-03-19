using System;

namespace DialogueSystem.Runtime.DialogueStruct
{
    [Serializable]
    public struct DialogueFile
    {
        public DialogueLine[] dialogueTexts;
        public DialogueChoice[] dialogueChoices;
    }
}