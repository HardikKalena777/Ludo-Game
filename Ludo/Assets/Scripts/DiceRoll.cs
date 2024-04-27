using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    public static DiceRoll Instance { get; private set; }
    public Sprite[] DiceFaces;
    public int DiceNum;
    public bool DiceRolled;
    [SerializeField] private SpriteRenderer SpriteRenderer;

    private void Awake()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        Instance = this;
        DiceRolled = false;
    }

    private void Update()
    {
        
    }
    public void OnClickSprite()
    {
        DiceNum = Random.Range(0, DiceFaces.Length);
        SpriteRenderer.sprite = DiceFaces[DiceNum];
        DiceRolled = true;
    }
}
