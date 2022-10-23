using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public float time = 2f;
    [SerializeField] private GameObject plateformGenerator;
    [SerializeField] private GameObject addScore;
   
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Debug.Log(time);
        if(time >=5){
            int pos= Random.Range(-6,-3);
            SpanwPlateform(new Vector2(33, pos) );
            SpanwScore(new Vector2(33, pos+1) );
            time =0;
        }
        
    }
    private void SpanwPlateform(Vector3 spawnPosition){
        Instantiate(plateformGenerator, spawnPosition, Quaternion.identity);
    }

    private void SpanwScore(Vector3 spawnPosition){
        Instantiate(addScore, spawnPosition, Quaternion.identity);
    }
}
