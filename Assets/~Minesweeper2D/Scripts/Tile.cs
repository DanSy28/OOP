using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minesweeper2D
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class Tile : MonoBehaviour
    {
        public int x = 0;
        public int y = 0;
        public bool isMine = false;
        public bool isRevealed = false;
        [Header("References")]
        public Sprite[] emptySprites;
        public Sprite[] mineSprites;

        private SpriteRenderer rend;

        void Awake ()
        {
            rend = GetComponent<SpriteRenderer>();
        }
        void Start ()
        {
            isMine = Random.value < .05f;
        }

        public void Reveal(int adjacentMines, int MineState = 0)
        {
            isRevealed = true;
            if (isMine)
            {
                rend.sprite = mineSprites[MineState];
            }
            else
            {
                rend.sprite = emptySprites[adjacentMines];
            }
        }

    }


}
