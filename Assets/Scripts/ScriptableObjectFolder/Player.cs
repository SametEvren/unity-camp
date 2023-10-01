using UnityEngine;
using UnityEngine.Serialization;

namespace ScriptableObjectFolder
{
    [CreateAssetMenu(fileName = "New Player")]
    public class Player : ScriptableObject
    {
        public string characterName;
        public float size;
        public int level;
        public Color cubeColor;
    }
}
