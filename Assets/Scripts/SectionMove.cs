using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionMove : MonoBehaviour
{

    //public GameObject sectionPrefab;
    public float sectionSpeed = 5;


    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position += new Vector3(0, 0, -1) * Time.deltaTime * sectionSpeed;
        StartCoroutine(sectionRemove());
    }


    IEnumerator sectionRemove()
    {
       

        yield return new WaitForSeconds(22f);
        Destroy(this.gameObject);
    }
}
