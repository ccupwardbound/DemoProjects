using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject squareOne;
    public GameObject squareTwo;

    private float TranslateSpeed;
    private float RotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        TranslateSpeed = 60f;
        RotateSpeed = 40f;
    }

    // Update is called once per frame
    void Update()
    {
        TranslateMe();
        RotateMe();
    }

    private void TranslateMe()
    {
        squareOne.transform.Translate(0, 0, Time.deltaTime * TranslateSpeed, Space.World);
        squareTwo.transform.Translate(0, 0, -Time.deltaTime * TranslateSpeed, Space.World);

        if (Mathf.Abs(squareOne.transform.position.z) > 60f || Mathf.Abs(squareTwo.transform.position.z) > 60F)
        {
            TranslateSpeed *= -1;
        }
    }

    private void RotateMe()
    {
        squareOne.transform.Rotate(0, Time.deltaTime * RotateSpeed, 0);
        squareTwo.transform.Rotate(0, -Time.deltaTime * RotateSpeed, 0);

        Debug.Log(squareOne.transform.rotation.y);

        if (Mathf.Abs(squareOne.transform.rotation.y) > .15F)
        {
            RotateSpeed *= -1;
        }
    }
}
