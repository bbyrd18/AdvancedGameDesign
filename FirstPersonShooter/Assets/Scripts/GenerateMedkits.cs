using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMedkits : MonoBehaviour
{
public GameObject theMedkit ;
    public int xPos;
    public int zPos;
    public int MedkitCount;

    private void Start()
    {
        StartCoroutine(SpawnMedkits());
    }

    private IEnumerator SpawnMedkits()
    {
        while (MedkitCount < 2)
        {
            xPos = Random.Range(-36, 37);
            zPos = Random.Range(-43, 44);
            Instantiate(theMedkit, new Vector3 (xPos, 2.38f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(1);
            MedkitCount += 1;
        }
    }
}
