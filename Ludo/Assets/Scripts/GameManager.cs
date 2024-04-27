using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform StartPos;
    [SerializeField] private GameObject[] Redpawns;
    private void Update()
    {
        if (DiceRoll.Instance.DiceNum == 5 && DiceRoll.Instance.DiceRolled)
        {
            Redpawns[Random.Range(0, Redpawns.Length)].transform.position = StartPos.position;
        }

        if(DiceRoll.Instance.DiceRolled)
        {
            DiceRoll.Instance.DiceRolled = false;
        }
    }
}
