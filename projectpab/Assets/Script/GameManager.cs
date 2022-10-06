using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject trashPrefab;
    public Transform leftTran;
    public Transform rightTran;
    // Start is called before the first frame update
    void Start()
    {
       
    InvokeRepeating("SpawnItem", 0, 2);
    }
  
    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
    public void SpawnItem()
    {
       float rndXValue = Random.Range(leftTran.position.x, rightTran.position.x);

       Vector2 spawnPos = new Vector2(rndXValue, leftTran.position.y);

       Instantiate(trashPrefab, spawnPos, Quaternion.identity );
    }
}

