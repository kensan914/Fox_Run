using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformEffect : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setTransform()
    {
        gameObject.SetActive(true);
        animator.SetBool("transform", true);
        StartCoroutine("countTramsformTime");
    }

    IEnumerator countTramsformTime()
    {
        yield return new WaitForSeconds(0.3f);
        gameObject.SetActive(false);
    }
}
