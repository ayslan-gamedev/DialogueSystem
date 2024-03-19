using System;
using UnityEngine;

namespace DialogueSystem.Runtime.DialogueStruct
{
    [Serializable]
    public struct Emotion
    {
        public EmotionTypes emotionType;
        public Sprite[] sprites;
    }
}
