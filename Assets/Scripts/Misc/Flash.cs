using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

    [SerializeField] private Material whiteFlash;
    [SerializeField] private float restoreDefaultMatTime = .2f;

    private Material DefaultMat;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        DefaultMat = spriteRenderer.material;


    }

    public float getRestoreMatTime()
    {
        return restoreDefaultMatTime;
    }

    public IEnumerator FlashRoutine()
    {
        spriteRenderer.material = whiteFlash;
        yield return new WaitForSeconds(restoreDefaultMatTime);
        spriteRenderer.material = DefaultMat;
    }
}
