using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectBox : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rockPrefab;
    public GameObject emptyGameObject0;
    public GameObject emptyGameObject1;
    public GameObject emptyGameObject2;
    public GameObject emptyGameObject3;
    public GameObject emptyGameObject4;
    public GameObject emptyGameObject5;
    public GameObject emptyGameObject6;
    public GameObject emptyGameObject7;
    
    private int ranInt;
    void Start()
    {
        print("started");
    }
    private void OnCollisionEnter(Collision other)
    {
        //print("ENTERRRRRRRRRRRRREDDDDDDDDDDDDDD");
        if (other.gameObject.CompareTag("Rock"))
        {
            //print("ROCKKKKKKKKKKKKKKKKKKKKKKKKKKKKK");
            Destroy(other.gameObject);
            generateInt();
            if (ranInt == 0)
            {
                Instantiate(rockPrefab, emptyGameObject0.transform.position, Quaternion.identity);
            }
            else if (ranInt == 1)
            {
                Instantiate(rockPrefab, emptyGameObject1.transform.position, Quaternion.identity);
            }
            else if (ranInt == 2)
            {
                Instantiate(rockPrefab, emptyGameObject2.transform.position, Quaternion.identity);
            }
            else if (ranInt == 3)
            {
                Instantiate(rockPrefab, emptyGameObject3.transform.position, Quaternion.identity);
            }
            else if (ranInt == 4)
            {
                Instantiate(rockPrefab, emptyGameObject4.transform.position, Quaternion.identity);
            }
            else if (ranInt == 5)
            {
                Instantiate(rockPrefab, emptyGameObject5.transform.position, Quaternion.identity);
            }
            else if (ranInt == 6)
            {
                Instantiate(rockPrefab, emptyGameObject6.transform.position, Quaternion.identity);
            }
            else
            {
                Instantiate(rockPrefab, emptyGameObject7.transform.position, Quaternion.identity);
            }
            //print(ranInt);
        }
    }
    private void generateInt()
    {
        ranInt = Random.Range(0, 8);
    }
}
