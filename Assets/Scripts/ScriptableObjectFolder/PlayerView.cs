using System;
using TMPro;
using UnityEngine;

namespace ScriptableObjectFolder
{
    public class PlayerView : MonoBehaviour
    {
        public Player player;
        public TextMeshProUGUI characterName;
        public TextMeshProUGUI level;
        public GameObject cube;

        private void Start()
        {
            SetupCharacter();
        }

        public void SetupCharacter()
        {
            transform.localScale = Vector3.one * player.size;
            characterName.text = player.characterName;
            level.text = player.level.ToString();
            cube.GetComponent<MeshRenderer>().material.color = player.cubeColor;
        }
    }
}