using System;
using UnityEngine;

namespace DialogueSystem.Struct
{
    [Serializable]
    public struct Emotion
    {
        public EmotionType emotionType;
        public Sprite[] sprites;
    }
}
